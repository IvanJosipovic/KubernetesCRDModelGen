using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatchevents.aws.upbound.io;
/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersApiKeyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersApiKey
{
    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersApiKeyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersBasicPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersBasic
{
    /// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersBasicPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>A username for the authorization.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersBodyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersBodyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersHeaderValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersHeaderValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersQueryStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersQueryStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary>The client secret for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthClientParametersClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthClientParameters
{
    /// <summary>The client ID for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The client secret for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersOauthClientParametersClientSecretSecretRef? ClientSecretSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersBodyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersBodyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersHeaderValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersHeaderValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersQueryStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersQueryStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParametersOauth
{
    /// <summary>The URL to the authorization endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Contains the client parameters for OAuth authorization. Contains the following two parameters.</summary>
    [JsonPropertyName("clientParameters")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauthClientParameters>? ClientParameters { get; set; }

    /// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>OAuth Http Parameters are additional credentials used to sign the request to the authorization endpoint to exchange the OAuth Client information for an access token. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("oauthHttpParameters")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauthOauthHttpParameters>? OauthHttpParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAuthParameters
{
    /// <summary>Parameters used for API_KEY authorization. An API key to include in the header for each authentication request. A maximum of 1 are allowed. Conflicts with basic and oauth. Documented below.</summary>
    [JsonPropertyName("apiKey")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersApiKey>? ApiKey { get; set; }

    /// <summary>Parameters used for BASIC authorization. A maximum of 1 are allowed. Conflicts with api_key and oauth. Documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersBasic>? Basic { get; set; }

    /// <summary>Invocation Http Parameters are additional credentials used to sign each Invocation of the ApiDestination created from this Connection. If the ApiDestination Rule Target has additional HttpParameters, the values will be merged together, with the Connection Invocation Http Parameters taking precedence. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("invocationHttpParameters")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersInvocationHttpParameters>? InvocationHttpParameters { get; set; }

    /// <summary>Parameters used for OAUTH_CLIENT_CREDENTIALS authorization. A maximum of 1 are allowed. Conflicts with basic and api_key. Documented below.</summary>
    [JsonPropertyName("oauth")]
    public IList<V1beta1ConnectionSpecForProviderAuthParametersOauth>? Oauth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderInvocationConnectivityParametersResourceParameters
{
    /// <summary>ARN of the Amazon VPC Lattice resource configuration for the resource endpoint.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderInvocationConnectivityParameters
{
    /// <summary>The parameters for EventBridge to use when invoking the resource endpoint. Documented below.</summary>
    [JsonPropertyName("resourceParameters")]
    public IList<V1beta1ConnectionSpecForProviderInvocationConnectivityParametersResourceParameters>? ResourceParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderKmsKeyIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderKmsKeyIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderKmsKeyIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderKmsKeyIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderKmsKeyIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderKmsKeyIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProvider
{
    /// <summary>Parameters used for authorization. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("authParameters")]
    public IList<V1beta1ConnectionSpecForProviderAuthParameters>? AuthParameters { get; set; }

    /// <summary>Type of authorization to use for the connection. One of API_KEY,BASIC,OAUTH_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Description for the connection. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Parameters to use for invoking a private API. Documented below.</summary>
    [JsonPropertyName("invocationConnectivityParameters")]
    public IList<V1beta1ConnectionSpecForProviderInvocationConnectivityParameters>? InvocationConnectivityParameters { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt this connection. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyIdentifier.</summary>
    [JsonPropertyName("kmsKeyIdentifierRef")]
    public V1beta1ConnectionSpecForProviderKmsKeyIdentifierRef? KmsKeyIdentifierRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyIdentifier.</summary>
    [JsonPropertyName("kmsKeyIdentifierSelector")]
    public V1beta1ConnectionSpecForProviderKmsKeyIdentifierSelector? KmsKeyIdentifierSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersApiKeyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersApiKey
{
    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersApiKeyValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersBasicPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersBasic
{
    /// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersBasicPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>A username for the authorization.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersBodyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersBodyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersHeaderValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersHeaderValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersQueryStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersQueryStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary>The client secret for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthClientParametersClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthClientParameters
{
    /// <summary>The client ID for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The client secret for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersOauthClientParametersClientSecretSecretRef ClientSecretSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersBodyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersBodyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersHeaderValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersHeaderValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersQueryStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Header Value. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersQueryStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParametersOauth
{
    /// <summary>The URL to the authorization endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Contains the client parameters for OAuth authorization. Contains the following two parameters.</summary>
    [JsonPropertyName("clientParameters")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauthClientParameters>? ClientParameters { get; set; }

    /// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>OAuth Http Parameters are additional credentials used to sign the request to the authorization endpoint to exchange the OAuth Client information for an access token. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("oauthHttpParameters")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauthOauthHttpParameters>? OauthHttpParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAuthParameters
{
    /// <summary>Parameters used for API_KEY authorization. An API key to include in the header for each authentication request. A maximum of 1 are allowed. Conflicts with basic and oauth. Documented below.</summary>
    [JsonPropertyName("apiKey")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersApiKey>? ApiKey { get; set; }

    /// <summary>Parameters used for BASIC authorization. A maximum of 1 are allowed. Conflicts with api_key and oauth. Documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersBasic>? Basic { get; set; }

    /// <summary>Invocation Http Parameters are additional credentials used to sign each Invocation of the ApiDestination created from this Connection. If the ApiDestination Rule Target has additional HttpParameters, the values will be merged together, with the Connection Invocation Http Parameters taking precedence. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("invocationHttpParameters")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersInvocationHttpParameters>? InvocationHttpParameters { get; set; }

    /// <summary>Parameters used for OAUTH_CLIENT_CREDENTIALS authorization. A maximum of 1 are allowed. Conflicts with basic and api_key. Documented below.</summary>
    [JsonPropertyName("oauth")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParametersOauth>? Oauth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderInvocationConnectivityParametersResourceParameters
{
    /// <summary>ARN of the Amazon VPC Lattice resource configuration for the resource endpoint.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderInvocationConnectivityParameters
{
    /// <summary>The parameters for EventBridge to use when invoking the resource endpoint. Documented below.</summary>
    [JsonPropertyName("resourceParameters")]
    public IList<V1beta1ConnectionSpecInitProviderInvocationConnectivityParametersResourceParameters>? ResourceParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderKmsKeyIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderKmsKeyIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderKmsKeyIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderKmsKeyIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderKmsKeyIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderKmsKeyIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProvider
{
    /// <summary>Parameters used for authorization. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("authParameters")]
    public IList<V1beta1ConnectionSpecInitProviderAuthParameters>? AuthParameters { get; set; }

    /// <summary>Type of authorization to use for the connection. One of API_KEY,BASIC,OAUTH_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Description for the connection. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Parameters to use for invoking a private API. Documented below.</summary>
    [JsonPropertyName("invocationConnectivityParameters")]
    public IList<V1beta1ConnectionSpecInitProviderInvocationConnectivityParameters>? InvocationConnectivityParameters { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt this connection. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyIdentifier.</summary>
    [JsonPropertyName("kmsKeyIdentifierRef")]
    public V1beta1ConnectionSpecInitProviderKmsKeyIdentifierRef? KmsKeyIdentifierRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyIdentifier.</summary>
    [JsonPropertyName("kmsKeyIdentifierSelector")]
    public V1beta1ConnectionSpecInitProviderKmsKeyIdentifierSelector? KmsKeyIdentifierSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecProviderConfigRefPolicy
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
public partial class V1beta1ConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConnectionSpec defines the desired state of Connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersApiKey
{
    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersBasic
{
    /// <summary>A username for the authorization.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauthClientParameters
{
    /// <summary>The client ID for the credentials to use for authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersBody
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersHeader
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersQueryString
{
    /// <summary>Specified whether the value is secret.</summary>
    [JsonPropertyName("isValueSecret")]
    public bool? IsValueSecret { get; set; }

    /// <summary>Header Name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParameters
{
    /// <summary>Contains additional body string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("body")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersBody>? Body { get; set; }

    /// <summary>Contains additional header parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersHeader>? Header { get; set; }

    /// <summary>Contains additional query string parameters for the connection. You can include up to 100 additional body string parameters per request. Each additional parameter counts towards the event payload size, which cannot exceed 64 KB. Each parameter can contain the following:</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParametersQueryString>? QueryString { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParametersOauth
{
    /// <summary>The URL to the authorization endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Contains the client parameters for OAuth authorization. Contains the following two parameters.</summary>
    [JsonPropertyName("clientParameters")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauthClientParameters>? ClientParameters { get; set; }

    /// <summary>A password for the authorization. Created and stored in AWS Secrets Manager.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>OAuth Http Parameters are additional credentials used to sign the request to the authorization endpoint to exchange the OAuth Client information for an access token. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("oauthHttpParameters")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauthOauthHttpParameters>? OauthHttpParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAuthParameters
{
    /// <summary>Parameters used for API_KEY authorization. An API key to include in the header for each authentication request. A maximum of 1 are allowed. Conflicts with basic and oauth. Documented below.</summary>
    [JsonPropertyName("apiKey")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersApiKey>? ApiKey { get; set; }

    /// <summary>Parameters used for BASIC authorization. A maximum of 1 are allowed. Conflicts with api_key and oauth. Documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersBasic>? Basic { get; set; }

    /// <summary>Invocation Http Parameters are additional credentials used to sign each Invocation of the ApiDestination created from this Connection. If the ApiDestination Rule Target has additional HttpParameters, the values will be merged together, with the Connection Invocation Http Parameters taking precedence. Secret values are stored and managed by AWS Secrets Manager. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("invocationHttpParameters")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersInvocationHttpParameters>? InvocationHttpParameters { get; set; }

    /// <summary>Parameters used for OAUTH_CLIENT_CREDENTIALS authorization. A maximum of 1 are allowed. Conflicts with basic and api_key. Documented below.</summary>
    [JsonPropertyName("oauth")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParametersOauth>? Oauth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderInvocationConnectivityParametersResourceParameters
{
    /// <summary>The Amazon Resource Name (ARN) of the connection.</summary>
    [JsonPropertyName("resourceAssociationArn")]
    public string? ResourceAssociationArn { get; set; }

    /// <summary>ARN of the Amazon VPC Lattice resource configuration for the resource endpoint.</summary>
    [JsonPropertyName("resourceConfigurationArn")]
    public string? ResourceConfigurationArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderInvocationConnectivityParameters
{
    /// <summary>The parameters for EventBridge to use when invoking the resource endpoint. Documented below.</summary>
    [JsonPropertyName("resourceParameters")]
    public IList<V1beta1ConnectionStatusAtProviderInvocationConnectivityParametersResourceParameters>? ResourceParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the connection.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Parameters used for authorization. A maximum of 1 are allowed. Documented below.</summary>
    [JsonPropertyName("authParameters")]
    public IList<V1beta1ConnectionStatusAtProviderAuthParameters>? AuthParameters { get; set; }

    /// <summary>Type of authorization to use for the connection. One of API_KEY,BASIC,OAUTH_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Description for the connection. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Parameters to use for invoking a private API. Documented below.</summary>
    [JsonPropertyName("invocationConnectivityParameters")]
    public IList<V1beta1ConnectionStatusAtProviderInvocationConnectivityParameters>? InvocationConnectivityParameters { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt this connection. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the secret created from the authorization parameters specified for the connection.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusConditions
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

/// <summary>ConnectionStatus defines the observed state of Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. Provides an EventBridge connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Connection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectionSpec>, IStatus<V1beta1ConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Connection";
    public const string KubeGroup = "cloudwatchevents.aws.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionSpec defines the desired state of Connection</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectionSpec Spec { get; set; }

    /// <summary>ConnectionStatus defines the observed state of Connection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectionStatus? Status { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. Provides an EventBridge connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Connection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectionList";
    public const string KubeGroup = "cloudwatchevents.aws.upbound.io";
    public const string KubePluralName = "connections";
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
    public IList<V1beta1Connection> Items { get; set; }
}