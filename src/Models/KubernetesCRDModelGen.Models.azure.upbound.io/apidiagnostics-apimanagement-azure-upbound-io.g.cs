using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>APIDiagnostic is the Schema for the APIDiagnostics API. Manages a API Management Service API Diagnostics Logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1APIDiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V1beta1APIDiagnostic>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "APIDiagnosticList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apidiagnostics";
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
    public IList<V1beta1APIDiagnostic> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiManagementNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderApiNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderApiNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1APIDiagnosticSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1APIDiagnosticSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecForProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>The name of the API Management Service instance. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1APIDiagnosticSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>The name of the API on which to configure the Diagnostics Logs. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>Reference to a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameRef")]
    public V1beta1APIDiagnosticSpecForProviderApiNameRef? ApiNameRef { get; set; }

    /// <summary>Selector for a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameSelector")]
    public V1beta1APIDiagnosticSpecForProviderApiNameSelector? ApiNameSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendRequest>? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public IList<V1beta1APIDiagnosticSpecForProviderBackendResponse>? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendRequest>? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public IList<V1beta1APIDiagnosticSpecForProviderFrontendResponse>? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The name of the Resource Group where the API Management Service API Diagnostics Logs should exist. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1APIDiagnosticSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1APIDiagnosticSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecInitProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta1APIDiagnosticSpecInitProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendRequest>? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public IList<V1beta1APIDiagnosticSpecInitProviderBackendResponse>? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendRequest>? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public IList<V1beta1APIDiagnosticSpecInitProviderFrontendResponse>? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecProviderConfigRefPolicy
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
public partial class V1beta1APIDiagnosticSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIDiagnosticSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>APIDiagnosticSpec defines the desired state of APIDiagnostic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1APIDiagnosticSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1APIDiagnosticSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1APIDiagnosticSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1APIDiagnosticSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendRequestDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendResponseDataMasking>? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusAtProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The ID (name) of the Diagnostics Logger.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>The name of the API Management Service instance. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>The name of the API on which to configure the Diagnostics Logs. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendRequest>? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public IList<V1beta1APIDiagnosticStatusAtProviderBackendResponse>? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendRequest>? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public IList<V1beta1APIDiagnosticStatusAtProviderFrontendResponse>? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>The ID of the API Management Service API Diagnostics Logs.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url. Defaults to Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The name of the Resource Group where the API Management Service API Diagnostics Logs should exist. Changing this forces a new API Management Service API Diagnostics Logs to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatusConditions
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

/// <summary>APIDiagnosticStatus defines the observed state of APIDiagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIDiagnosticStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1APIDiagnosticStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1APIDiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>APIDiagnostic is the Schema for the APIDiagnostics API. Manages a API Management Service API Diagnostics Logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1APIDiagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1APIDiagnosticSpec>, IStatus<V1beta1APIDiagnosticStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "APIDiagnostic";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apidiagnostics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIDiagnosticSpec defines the desired state of APIDiagnostic</summary>
    [JsonPropertyName("spec")]
    public V1beta1APIDiagnosticSpec Spec { get; set; }

    /// <summary>APIDiagnosticStatus defines the observed state of APIDiagnostic.</summary>
    [JsonPropertyName("status")]
    public V1beta1APIDiagnosticStatus? Status { get; set; }
}