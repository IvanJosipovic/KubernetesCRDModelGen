using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
/// <summary>LBListenerRule is the Schema for the LBListenerRules API. Provides a Load Balancer Listener Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LBListenerRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LBListenerRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LBListenerRuleList";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblistenerrules";
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
    public IList<V1beta1LBListenerRule> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnRef")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRef? UserPoolArnRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnSelector")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelector? UserPoolArnSelector { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdRef")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRef? UserPoolClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdSelector")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelector? UserPoolClientIdSelector { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainRef")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRef? UserPoolDomainRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainSelector")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelector? UserPoolDomainSelector { get; set; }
}

/// <summary>The OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateOidcClientSecretSecretRef
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
public partial class V1beta1LBListenerRuleSpecForProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LBListenerRuleSpecForProviderActionAuthenticateOidcClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerRuleSpecForProviderActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta1LBListenerRuleSpecForProviderActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionHostHeader
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). If the same header appears multiple times in the request they will be searched in order until a match is found. Only one pattern needs to match for the condition to be satisfied. To require that all of the strings are a match, create one condition block per string.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionPathPattern
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderCondition
{
    /// <summary>Contains a single values item which is a list of host header patterns to match. The maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("hostHeader")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionHostHeader>? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionHttpHeader>? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionHttpRequestMethod>? HttpRequestMethod { get; set; }

    /// <summary>Contains a single values item which is a list of path patterns to match against the request URL. Maximum size of each pattern is 128 characters. Comparison is case sensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Path pattern is compared only to the path of the URL, not to its query string. To compare against the query string, use a query_string condition.</summary>
    [JsonPropertyName("pathPattern")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionPathPattern>? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public IList<V1beta1LBListenerRuleSpecForProviderConditionSourceIp>? SourceIp { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderListenerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderListenerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderListenerArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderListenerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProviderListenerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecForProviderListenerArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecForProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LBListenerRuleSpecForProviderAction>? Action { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1LBListenerRuleSpecForProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnRef")]
    public V1beta1LBListenerRuleSpecForProviderListenerArnRef? ListenerArnRef { get; set; }

    /// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnSelector")]
    public V1beta1LBListenerRuleSpecForProviderListenerArnSelector? ListenerArnSelector { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRef? UserPoolArnRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnSelector")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelector? UserPoolArnSelector { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRef? UserPoolClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdSelector")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelector? UserPoolClientIdSelector { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRef? UserPoolDomainRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainSelector")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelector? UserPoolDomainSelector { get; set; }
}

/// <summary>The OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateOidcClientSecretSecretRef
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
public partial class V1beta1LBListenerRuleSpecInitProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionAuthenticateOidcClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerRuleSpecInitProviderActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta1LBListenerRuleSpecInitProviderActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionHostHeader
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). If the same header appears multiple times in the request they will be searched in order until a match is found. Only one pattern needs to match for the condition to be satisfied. To require that all of the strings are a match, create one condition block per string.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionPathPattern
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderCondition
{
    /// <summary>Contains a single values item which is a list of host header patterns to match. The maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("hostHeader")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionHostHeader>? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionHttpHeader>? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionHttpRequestMethod>? HttpRequestMethod { get; set; }

    /// <summary>Contains a single values item which is a list of path patterns to match against the request URL. Maximum size of each pattern is 128 characters. Comparison is case sensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Path pattern is compared only to the path of the URL, not to its query string. To compare against the query string, use a query_string condition.</summary>
    [JsonPropertyName("pathPattern")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionPathPattern>? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public IList<V1beta1LBListenerRuleSpecInitProviderConditionSourceIp>? SourceIp { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderListenerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderListenerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderListenerArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderListenerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProviderListenerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecInitProviderListenerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecInitProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LBListenerRuleSpecInitProviderAction>? Action { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1LBListenerRuleSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnRef")]
    public V1beta1LBListenerRuleSpecInitProviderListenerArnRef? ListenerArnRef { get; set; }

    /// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnSelector")]
    public V1beta1LBListenerRuleSpecInitProviderListenerArnSelector? ListenerArnSelector { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecProviderConfigRefPolicy
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
public partial class V1beta1LBListenerRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LBListenerRuleSpec defines the desired state of LBListenerRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LBListenerRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LBListenerRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LBListenerRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LBListenerRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerRuleStatusAtProviderActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionHostHeader
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). If the same header appears multiple times in the request they will be searched in order until a match is found. Only one pattern needs to match for the condition to be satisfied. To require that all of the strings are a match, create one condition block per string.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionPathPattern
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal '*' or '?' character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProviderCondition
{
    /// <summary>Contains a single values item which is a list of host header patterns to match. The maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("hostHeader")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionHostHeader>? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionHttpHeader>? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionHttpRequestMethod>? HttpRequestMethod { get; set; }

    /// <summary>Contains a single values item which is a list of path patterns to match against the request URL. Maximum size of each pattern is 128 characters. Comparison is case sensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Path pattern is compared only to the path of the URL, not to its query string. To compare against the query string, use a query_string condition.</summary>
    [JsonPropertyName("pathPattern")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionPathPattern>? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public IList<V1beta1LBListenerRuleStatusAtProviderConditionSourceIp>? SourceIp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusAtProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LBListenerRuleStatusAtProviderAction>? Action { get; set; }

    /// <summary>The ARN of the rule (matches id)</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1LBListenerRuleStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the rule (matches arn)</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatusConditions
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

/// <summary>LBListenerRuleStatus defines the observed state of LBListenerRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LBListenerRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LBListenerRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LBListenerRule is the Schema for the LBListenerRules API. Provides a Load Balancer Listener Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LBListenerRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LBListenerRuleSpec>, IStatus<V1beta1LBListenerRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LBListenerRule";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblistenerrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBListenerRuleSpec defines the desired state of LBListenerRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1LBListenerRuleSpec Spec { get; set; }

    /// <summary>LBListenerRuleStatus defines the observed state of LBListenerRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1LBListenerRuleStatus? Status { get; set; }
}