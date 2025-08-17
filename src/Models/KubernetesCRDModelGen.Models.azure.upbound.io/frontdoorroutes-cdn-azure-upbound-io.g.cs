using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
#nullable enable
/// <summary>FrontdoorRoute is the Schema for the FrontdoorRoutes API. Manages a Front Door (standard/premium) Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorRouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorRoute>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorRouteList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorroutes";
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
    public IList<V1beta1FrontdoorRoute> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicy
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
/// <summary>Reference to a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicy
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
/// <summary>Selector for a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicy
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
/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicy
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
/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecForProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public IList<V1beta1FrontdoorRouteSpecForProviderCache>? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>References to FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefs>? CdnFrontdoorCustomDomainIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsSelector")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelector? CdnFrontdoorCustomDomainIdsSelector { get; set; }

    /// <summary>The resource ID of the Front Door Endpoint where this Front Door Route should exist. Changing this forces a new Front Door Route to be created.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointId")]
    public string? CdnFrontdoorEndpointId { get; set; }

    /// <summary>Reference to a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointIdRef")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRef? CdnFrontdoorEndpointIdRef { get; set; }

    /// <summary>Selector for a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointIdSelector")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelector? CdnFrontdoorEndpointIdSelector { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>References to FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefs>? CdnFrontdoorOriginIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsSelector")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelector? CdnFrontdoorOriginIdsSelector { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>References to FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefs>? CdnFrontdoorRuleSetIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsSelector")]
    public V1beta1FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelector? CdnFrontdoorRuleSetIdsSelector { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicy
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
/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicy
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
/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicy
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
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicy
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
/// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecInitProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public IList<V1beta1FrontdoorRouteSpecInitProviderCache>? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>References to FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefs>? CdnFrontdoorCustomDomainIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsSelector")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelector? CdnFrontdoorCustomDomainIdsSelector { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>References to FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefs>? CdnFrontdoorOriginIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsSelector")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelector? CdnFrontdoorOriginIdsSelector { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>References to FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsRefs")]
    public IList<V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefs>? CdnFrontdoorRuleSetIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsSelector")]
    public V1beta1FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelector? CdnFrontdoorRuleSetIdsSelector { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecProviderConfigRefPolicy
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
public partial class V1beta1FrontdoorRouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRouteSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpecWriteConnectionSecretToRef
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
/// <summary>FrontdoorRouteSpec defines the desired state of FrontdoorRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorRouteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorRouteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorRouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorRouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteStatusAtProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteStatusAtProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public IList<V1beta1FrontdoorRouteStatusAtProviderCache>? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>The resource ID of the Front Door Endpoint where this Front Door Route should exist. Changing this forces a new Front Door Route to be created.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointId")]
    public string? CdnFrontdoorEndpointId { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>The ID of the Front Door Route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteStatusConditions
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
/// <summary>FrontdoorRouteStatus defines the observed state of FrontdoorRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRouteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorRouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorRouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FrontdoorRoute is the Schema for the FrontdoorRoutes API. Manages a Front Door (standard/premium) Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorRouteSpec>, IStatus<V1beta1FrontdoorRouteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorRoute";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorRouteSpec defines the desired state of FrontdoorRoute</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorRouteSpec Spec { get; set; }

    /// <summary>FrontdoorRouteStatus defines the observed state of FrontdoorRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorRouteStatus? Status { get; set; }
}
#nullable disable
