using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.m.upbound.io;
#nullable enable
/// <summary>Diagnostic is the Schema for the Diagnostics API. Manages an API Management Service Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Diagnostic>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DiagnosticList";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "diagnostics";
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
    public IList<V1beta1Diagnostic> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementLoggerIdRefPolicy
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
/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiagnosticSpecForProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy
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
/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementLoggerIdSelector
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
    public V1beta1DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementNameRefPolicy
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
/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiagnosticSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementNameSelectorPolicy
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
/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderApiManagementNameSelector
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
    public V1beta1DiagnosticSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecForProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecForProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecForProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecForProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecForProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecForProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecForProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecForProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecForProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecForProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiagnosticSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProviderResourceGroupNameSelector
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
    public V1beta1DiagnosticSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecForProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta1DiagnosticSpecForProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta1DiagnosticSpecForProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>The Name of the API Management Service where this Diagnostic should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1DiagnosticSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1DiagnosticSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta1DiagnosticSpecForProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta1DiagnosticSpecForProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta1DiagnosticSpecForProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta1DiagnosticSpecForProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1DiagnosticSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1DiagnosticSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy
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
/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy
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
/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdSelector
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
    public V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecInitProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecInitProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecInitProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecInitProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecInitProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticSpecInitProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecInitProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta1DiagnosticSpecInitProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta1DiagnosticSpecInitProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta1DiagnosticSpecInitProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta1DiagnosticSpecInitProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta1DiagnosticSpecInitProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpecProviderConfigRef
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
public partial class V1beta1DiagnosticSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DiagnosticSpec defines the desired state of Diagnostic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DiagnosticSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DiagnosticSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DiagnosticSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DiagnosticSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticStatusAtProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticStatusAtProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticStatusAtProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticStatusAtProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticStatusAtProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1DiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1DiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta1DiagnosticStatusAtProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusAtProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>The Name of the API Management Service where this Diagnostic should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta1DiagnosticStatusAtProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta1DiagnosticStatusAtProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta1DiagnosticStatusAtProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta1DiagnosticStatusAtProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>The ID of the API Management Diagnostic.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatusConditions
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
/// <summary>DiagnosticStatus defines the observed state of Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DiagnosticStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DiagnosticStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Diagnostic is the Schema for the Diagnostics API. Manages an API Management Service Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Diagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DiagnosticSpec>, IStatus<V1beta1DiagnosticStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Diagnostic";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "diagnostics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiagnosticSpec defines the desired state of Diagnostic</summary>
    [JsonPropertyName("spec")]
    public V1beta1DiagnosticSpec Spec { get; set; }

    /// <summary>DiagnosticStatus defines the observed state of Diagnostic.</summary>
    [JsonPropertyName("status")]
    public V1beta1DiagnosticStatus? Status { get; set; }
}
#nullable disable
