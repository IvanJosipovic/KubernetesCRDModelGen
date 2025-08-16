using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>ApplicationInsightsStandardWebTest is the Schema for the ApplicationInsightsStandardWebTests API. Manages a Application Insights Standard WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationInsightsStandardWebTestList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApplicationInsightsStandardWebTest>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationInsightsStandardWebTestList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "applicationinsightsstandardwebtests";
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
    public IList<V1beta1ApplicationInsightsStandardWebTest> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecForProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are 'GET', 'POST', 'PUT', 'PATCH', and 'DELETE'. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecForProviderValidationRulesContent>? Content { get; set; }

    /// <summary>The expected status code of the response. Default is '200', '0' means 'response code &lt; 400'</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecForProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdRef")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRef? ApplicationInsightsIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdSelector")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelector? ApplicationInsightsIdSelector { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecForProviderRequest>? Request { get; set; }

    /// <summary>The name of the Resource Group where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecForProviderValidationRules>? ValidationRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecInitProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are 'GET', 'POST', 'PUT', 'PATCH', and 'DELETE'. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecInitProviderValidationRulesContent>? Content { get; set; }

    /// <summary>The expected status code of the response. Default is '200', '0' means 'response code &lt; 400'</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecInitProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdRef")]
    public V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRef? ApplicationInsightsIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdSelector")]
    public V1beta1ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelector? ApplicationInsightsIdSelector { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecInitProviderRequest>? Request { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public IList<V1beta1ApplicationInsightsStandardWebTestSpecInitProviderValidationRules>? ValidationRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ApplicationInsightsStandardWebTestSpec defines the desired state of ApplicationInsightsStandardWebTest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationInsightsStandardWebTestSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationInsightsStandardWebTestSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationInsightsStandardWebTestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationInsightsStandardWebTestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusAtProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusAtProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ApplicationInsightsStandardWebTestStatusAtProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are 'GET', 'POST', 'PUT', 'PATCH', and 'DELETE'. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusAtProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusAtProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1ApplicationInsightsStandardWebTestStatusAtProviderValidationRulesContent>? Content { get; set; }

    /// <summary>The expected status code of the response. Default is '200', '0' means 'response code &lt; 400'</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusAtProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The ID of the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1ApplicationInsightsStandardWebTestStatusAtProviderRequest>? Request { get; set; }

    /// <summary>The name of the Resource Group where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
    [JsonPropertyName("syntheticMonitorId")]
    public string? SyntheticMonitorId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public IList<V1beta1ApplicationInsightsStandardWebTestStatusAtProviderValidationRules>? ValidationRules { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatusConditions
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

/// <summary>ApplicationInsightsStandardWebTestStatus defines the observed state of ApplicationInsightsStandardWebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsStandardWebTestStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationInsightsStandardWebTestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationInsightsStandardWebTestStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ApplicationInsightsStandardWebTest is the Schema for the ApplicationInsightsStandardWebTests API. Manages a Application Insights Standard WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationInsightsStandardWebTest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationInsightsStandardWebTestSpec>, IStatus<V1beta1ApplicationInsightsStandardWebTestStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationInsightsStandardWebTest";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "applicationinsightsstandardwebtests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationInsightsStandardWebTestSpec defines the desired state of ApplicationInsightsStandardWebTest</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationInsightsStandardWebTestSpec Spec { get; set; }

    /// <summary>ApplicationInsightsStandardWebTestStatus defines the observed state of ApplicationInsightsStandardWebTest.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationInsightsStandardWebTestStatus? Status { get; set; }
}