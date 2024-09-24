using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.aws.upbound.io;
public enum V1beta1IntegrationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1IntegrationSpecForProviderApiIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderApiIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderApiIdRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderApiIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderApiIdRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderApiIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderApiIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderConnectionIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderCredentialsArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderCredentialsArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderCredentialsArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderCredentialsArnRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderCredentialsArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderCredentialsArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderIntegrationUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderIntegrationUriRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderIntegrationUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderIntegrationUriRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderIntegrationUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecForProviderIntegrationUriSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderResponseParameters
{
    /// <summary>Key-value map. The key of this map identifies the location of the request parameter to change, and how to change it. The corresponding value specifies the new data for the parameter. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("mappings")]
    public IDictionary<string, string>? Mappings { get; set; }

    /// <summary>HTTP status code in the range 200-599.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

public partial class V1beta1IntegrationSpecForProviderTlsConfig
{
    /// <summary>If you specify a server name, API Gateway uses it to verify the hostname on the integration's certificate. The server name is also included in the TLS handshake to support Server Name Indication (SNI) or virtual hosting.</summary>
    [JsonPropertyName("serverNameToVerify")]
    public string? ServerNameToVerify { get; set; }
}

public partial class V1beta1IntegrationSpecForProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1IntegrationSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1IntegrationSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>ID of the VPC link for a private integration. Supported only for HTTP APIs. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a VPCLink in apigatewayv2 to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1IntegrationSpecForProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCLink in apigatewayv2 to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1IntegrationSpecForProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>Type of the network connection to the integration endpoint. Valid values: INTERNET, VPC_LINK. Default is INTERNET.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>How to handle response payload content type conversions. Valid values: CONVERT_TO_BINARY, CONVERT_TO_TEXT. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("contentHandlingStrategy")]
    public string? ContentHandlingStrategy { get; set; }

    /// <summary>Credentials required for the integration, if any.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Reference to a Role in iam to populate credentialsArn.</summary>
    [JsonPropertyName("credentialsArnRef")]
    public V1beta1IntegrationSpecForProviderCredentialsArnRef? CredentialsArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate credentialsArn.</summary>
    [JsonPropertyName("credentialsArnSelector")]
    public V1beta1IntegrationSpecForProviderCredentialsArnSelector? CredentialsArnSelector { get; set; }

    /// <summary>Description of the integration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Integration's HTTP method. Must be specified if integration_type is not MOCK.</summary>
    [JsonPropertyName("integrationMethod")]
    public string? IntegrationMethod { get; set; }

    /// <summary>AWS service action to invoke. Supported only for HTTP APIs when integration_type is AWS_PROXY. See the AWS service integration reference documentation for supported values. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("integrationSubtype")]
    public string? IntegrationSubtype { get; set; }

    /// <summary>Integration type of an integration. Valid values: AWS (supported only for WebSocket APIs), AWS_PROXY, HTTP (supported only for WebSocket APIs), HTTP_PROXY, MOCK (supported only for WebSocket APIs). For an HTTP API private integration, use HTTP_PROXY.</summary>
    [JsonPropertyName("integrationType")]
    public string? IntegrationType { get; set; }

    /// <summary>URI of the Lambda function for a Lambda proxy integration, when integration_type is AWS_PROXY. For an HTTP integration, specify a fully-qualified URL. For an HTTP API private integration, specify the ARN of an Application Load Balancer listener, Network Load Balancer listener, or AWS Cloud Map service.</summary>
    [JsonPropertyName("integrationUri")]
    public string? IntegrationUri { get; set; }

    /// <summary>Reference to a Function in lambda to populate integrationUri.</summary>
    [JsonPropertyName("integrationUriRef")]
    public V1beta1IntegrationSpecForProviderIntegrationUriRef? IntegrationUriRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate integrationUri.</summary>
    [JsonPropertyName("integrationUriSelector")]
    public V1beta1IntegrationSpecForProviderIntegrationUriSelector? IntegrationUriSelector { get; set; }

    /// <summary>Pass-through behavior for incoming requests based on the Content-Type header in the request, and the available mapping templates specified as the request_templates attribute. Valid values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, NEVER. Default is WHEN_NO_MATCH. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    /// <summary>The format of the payload sent to an integration. Valid values: 1.0, 2.0. Default is 1.0.</summary>
    [JsonPropertyName("payloadFormatVersion")]
    public string? PayloadFormatVersion { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>For WebSocket APIs, a key-value map specifying request parameters that are passed from the method request to the backend. For HTTP APIs with a specified integration_subtype, a key-value map specifying parameters that are passed to AWS_PROXY integrations. For HTTP APIs without a specified integration_subtype, a key-value map specifying how to transform HTTP requests before sending them to the backend. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    /// <summary>Map of Velocity templates that are applied on the request payload based on the value of the Content-Type header sent by the client. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    /// <summary>Mappings to transform the HTTP response from a backend integration before returning the response to clients. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("responseParameters")]
    public IList<V1beta1IntegrationSpecForProviderResponseParameters>? ResponseParameters { get; set; }

    /// <summary>The template selection expression for the integration.</summary>
    [JsonPropertyName("templateSelectionExpression")]
    public string? TemplateSelectionExpression { get; set; }

    /// <summary>Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50 and 30,000 milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket APIs and 30 seconds for HTTP APIs.</summary>
    [JsonPropertyName("timeoutMilliseconds")]
    public double? TimeoutMilliseconds { get; set; }

    /// <summary>TLS configuration for a private integration. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("tlsConfig")]
    public IList<V1beta1IntegrationSpecForProviderTlsConfig>? TlsConfig { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderApiIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderApiIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderApiIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderApiIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderConnectionIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderCredentialsArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderCredentialsArnRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderCredentialsArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderCredentialsArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderIntegrationUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderIntegrationUriRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolveEnum>))]
    public V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderIntegrationUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecInitProviderIntegrationUriSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderResponseParameters
{
    /// <summary>Key-value map. The key of this map identifies the location of the request parameter to change, and how to change it. The corresponding value specifies the new data for the parameter. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("mappings")]
    public IDictionary<string, string>? Mappings { get; set; }

    /// <summary>HTTP status code in the range 200-599.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

public partial class V1beta1IntegrationSpecInitProviderTlsConfig
{
    /// <summary>If you specify a server name, API Gateway uses it to verify the hostname on the integration's certificate. The server name is also included in the TLS handshake to support Server Name Indication (SNI) or virtual hosting.</summary>
    [JsonPropertyName("serverNameToVerify")]
    public string? ServerNameToVerify { get; set; }
}

public partial class V1beta1IntegrationSpecInitProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1IntegrationSpecInitProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1IntegrationSpecInitProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>ID of the VPC link for a private integration. Supported only for HTTP APIs. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a VPCLink in apigatewayv2 to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1IntegrationSpecInitProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCLink in apigatewayv2 to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1IntegrationSpecInitProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>Type of the network connection to the integration endpoint. Valid values: INTERNET, VPC_LINK. Default is INTERNET.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>How to handle response payload content type conversions. Valid values: CONVERT_TO_BINARY, CONVERT_TO_TEXT. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("contentHandlingStrategy")]
    public string? ContentHandlingStrategy { get; set; }

    /// <summary>Credentials required for the integration, if any.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Reference to a Role in iam to populate credentialsArn.</summary>
    [JsonPropertyName("credentialsArnRef")]
    public V1beta1IntegrationSpecInitProviderCredentialsArnRef? CredentialsArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate credentialsArn.</summary>
    [JsonPropertyName("credentialsArnSelector")]
    public V1beta1IntegrationSpecInitProviderCredentialsArnSelector? CredentialsArnSelector { get; set; }

    /// <summary>Description of the integration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Integration's HTTP method. Must be specified if integration_type is not MOCK.</summary>
    [JsonPropertyName("integrationMethod")]
    public string? IntegrationMethod { get; set; }

    /// <summary>AWS service action to invoke. Supported only for HTTP APIs when integration_type is AWS_PROXY. See the AWS service integration reference documentation for supported values. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("integrationSubtype")]
    public string? IntegrationSubtype { get; set; }

    /// <summary>Integration type of an integration. Valid values: AWS (supported only for WebSocket APIs), AWS_PROXY, HTTP (supported only for WebSocket APIs), HTTP_PROXY, MOCK (supported only for WebSocket APIs). For an HTTP API private integration, use HTTP_PROXY.</summary>
    [JsonPropertyName("integrationType")]
    public string? IntegrationType { get; set; }

    /// <summary>URI of the Lambda function for a Lambda proxy integration, when integration_type is AWS_PROXY. For an HTTP integration, specify a fully-qualified URL. For an HTTP API private integration, specify the ARN of an Application Load Balancer listener, Network Load Balancer listener, or AWS Cloud Map service.</summary>
    [JsonPropertyName("integrationUri")]
    public string? IntegrationUri { get; set; }

    /// <summary>Reference to a Function in lambda to populate integrationUri.</summary>
    [JsonPropertyName("integrationUriRef")]
    public V1beta1IntegrationSpecInitProviderIntegrationUriRef? IntegrationUriRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate integrationUri.</summary>
    [JsonPropertyName("integrationUriSelector")]
    public V1beta1IntegrationSpecInitProviderIntegrationUriSelector? IntegrationUriSelector { get; set; }

    /// <summary>Pass-through behavior for incoming requests based on the Content-Type header in the request, and the available mapping templates specified as the request_templates attribute. Valid values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, NEVER. Default is WHEN_NO_MATCH. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    /// <summary>The format of the payload sent to an integration. Valid values: 1.0, 2.0. Default is 1.0.</summary>
    [JsonPropertyName("payloadFormatVersion")]
    public string? PayloadFormatVersion { get; set; }

    /// <summary>For WebSocket APIs, a key-value map specifying request parameters that are passed from the method request to the backend. For HTTP APIs with a specified integration_subtype, a key-value map specifying parameters that are passed to AWS_PROXY integrations. For HTTP APIs without a specified integration_subtype, a key-value map specifying how to transform HTTP requests before sending them to the backend. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    /// <summary>Map of Velocity templates that are applied on the request payload based on the value of the Content-Type header sent by the client. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    /// <summary>Mappings to transform the HTTP response from a backend integration before returning the response to clients. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("responseParameters")]
    public IList<V1beta1IntegrationSpecInitProviderResponseParameters>? ResponseParameters { get; set; }

    /// <summary>The template selection expression for the integration.</summary>
    [JsonPropertyName("templateSelectionExpression")]
    public string? TemplateSelectionExpression { get; set; }

    /// <summary>Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50 and 30,000 milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket APIs and 30 seconds for HTTP APIs.</summary>
    [JsonPropertyName("timeoutMilliseconds")]
    public double? TimeoutMilliseconds { get; set; }

    /// <summary>TLS configuration for a private integration. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("tlsConfig")]
    public IList<V1beta1IntegrationSpecInitProviderTlsConfig>? TlsConfig { get; set; }
}

public enum V1beta1IntegrationSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1IntegrationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IntegrationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1IntegrationSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1IntegrationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IntegrationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IntegrationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1IntegrationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1IntegrationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IntegrationSpecDeletionPolicyEnum>))]
    public V1beta1IntegrationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IntegrationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IntegrationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IntegrationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IntegrationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IntegrationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IntegrationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1IntegrationStatusAtProviderResponseParameters
{
    /// <summary>Key-value map. The key of this map identifies the location of the request parameter to change, and how to change it. The corresponding value specifies the new data for the parameter. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("mappings")]
    public IDictionary<string, string>? Mappings { get; set; }

    /// <summary>HTTP status code in the range 200-599.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

public partial class V1beta1IntegrationStatusAtProviderTlsConfig
{
    /// <summary>If you specify a server name, API Gateway uses it to verify the hostname on the integration's certificate. The server name is also included in the TLS handshake to support Server Name Indication (SNI) or virtual hosting.</summary>
    [JsonPropertyName("serverNameToVerify")]
    public string? ServerNameToVerify { get; set; }
}

public partial class V1beta1IntegrationStatusAtProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ID of the VPC link for a private integration. Supported only for HTTP APIs. Must be between 1 and 1024 characters in length.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Type of the network connection to the integration endpoint. Valid values: INTERNET, VPC_LINK. Default is INTERNET.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>How to handle response payload content type conversions. Valid values: CONVERT_TO_BINARY, CONVERT_TO_TEXT. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("contentHandlingStrategy")]
    public string? ContentHandlingStrategy { get; set; }

    /// <summary>Credentials required for the integration, if any.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Description of the integration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Integration identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Integration's HTTP method. Must be specified if integration_type is not MOCK.</summary>
    [JsonPropertyName("integrationMethod")]
    public string? IntegrationMethod { get; set; }

    /// <summary>The integration response selection expression for the integration.</summary>
    [JsonPropertyName("integrationResponseSelectionExpression")]
    public string? IntegrationResponseSelectionExpression { get; set; }

    /// <summary>AWS service action to invoke. Supported only for HTTP APIs when integration_type is AWS_PROXY. See the AWS service integration reference documentation for supported values. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("integrationSubtype")]
    public string? IntegrationSubtype { get; set; }

    /// <summary>Integration type of an integration. Valid values: AWS (supported only for WebSocket APIs), AWS_PROXY, HTTP (supported only for WebSocket APIs), HTTP_PROXY, MOCK (supported only for WebSocket APIs). For an HTTP API private integration, use HTTP_PROXY.</summary>
    [JsonPropertyName("integrationType")]
    public string? IntegrationType { get; set; }

    /// <summary>URI of the Lambda function for a Lambda proxy integration, when integration_type is AWS_PROXY. For an HTTP integration, specify a fully-qualified URL. For an HTTP API private integration, specify the ARN of an Application Load Balancer listener, Network Load Balancer listener, or AWS Cloud Map service.</summary>
    [JsonPropertyName("integrationUri")]
    public string? IntegrationUri { get; set; }

    /// <summary>Pass-through behavior for incoming requests based on the Content-Type header in the request, and the available mapping templates specified as the request_templates attribute. Valid values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, NEVER. Default is WHEN_NO_MATCH. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    /// <summary>The format of the payload sent to an integration. Valid values: 1.0, 2.0. Default is 1.0.</summary>
    [JsonPropertyName("payloadFormatVersion")]
    public string? PayloadFormatVersion { get; set; }

    /// <summary>For WebSocket APIs, a key-value map specifying request parameters that are passed from the method request to the backend. For HTTP APIs with a specified integration_subtype, a key-value map specifying parameters that are passed to AWS_PROXY integrations. For HTTP APIs without a specified integration_subtype, a key-value map specifying how to transform HTTP requests before sending them to the backend. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    /// <summary>Map of Velocity templates that are applied on the request payload based on the value of the Content-Type header sent by the client. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    /// <summary>Mappings to transform the HTTP response from a backend integration before returning the response to clients. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("responseParameters")]
    public IList<V1beta1IntegrationStatusAtProviderResponseParameters>? ResponseParameters { get; set; }

    /// <summary>The template selection expression for the integration.</summary>
    [JsonPropertyName("templateSelectionExpression")]
    public string? TemplateSelectionExpression { get; set; }

    /// <summary>Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50 and 30,000 milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket APIs and 30 seconds for HTTP APIs.</summary>
    [JsonPropertyName("timeoutMilliseconds")]
    public double? TimeoutMilliseconds { get; set; }

    /// <summary>TLS configuration for a private integration. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("tlsConfig")]
    public IList<V1beta1IntegrationStatusAtProviderTlsConfig>? TlsConfig { get; set; }
}

public partial class V1beta1IntegrationStatusConditions
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

public partial class V1beta1IntegrationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IntegrationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IntegrationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Integration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IntegrationSpec>, IStatus<V1beta1IntegrationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Integration";
    public const string KubeGroup = "apigatewayv2.aws.upbound.io";
    public const string KubePluralName = "integrations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IntegrationSpec defines the desired state of Integration</summary>
    [JsonPropertyName("spec")]
    public V1beta1IntegrationSpec Spec { get; set; }

    /// <summary>IntegrationStatus defines the observed state of Integration.</summary>
    [JsonPropertyName("status")]
    public V1beta1IntegrationStatus? Status { get; set; }
}