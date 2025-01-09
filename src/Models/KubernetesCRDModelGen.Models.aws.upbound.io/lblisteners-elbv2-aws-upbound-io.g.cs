using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. Detailed below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionAuthenticateOidcClientSecretSecretRef
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
public partial class V1beta1LBListenerSpecForProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LBListenerSpecForProviderDefaultActionAuthenticateOidcClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicy
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
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicy
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
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. Detailed below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicy
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
public partial class V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicy
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
public partial class V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. Detailed below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. Detailed below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn. Detailed below.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. Detailed below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerSpecForProviderDefaultActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta1LBListenerSpecForProviderDefaultActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderLoadBalancerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderLoadBalancerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderLoadBalancerArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderLoadBalancerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderLoadBalancerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecForProviderLoadBalancerArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether client certificate expiry is ignored. Default is false.</summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, verify and passthrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecForProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1LBListenerSpecForProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnRef")]
    public V1beta1LBListenerSpecForProviderLoadBalancerArnRef? LoadBalancerArnRef { get; set; }

    /// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnSelector")]
    public V1beta1LBListenerSpecForProviderLoadBalancerArnSelector? LoadBalancerArnSelector { get; set; }

    /// <summary>The mutual authentication configuration information. Detailed below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public IList<V1beta1LBListenerSpecForProviderMutualAuthentication>? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, and TCP_UDP. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. Detailed below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateOidcClientSecretSecretRef
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
public partial class V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateOidcClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicy
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
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicy
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
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. Detailed below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicy
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
public partial class V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicy
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
public partial class V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. Detailed below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. Detailed below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn. Detailed below.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. Detailed below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta1LBListenerSpecInitProviderDefaultActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderLoadBalancerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderLoadBalancerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderLoadBalancerArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderLoadBalancerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderLoadBalancerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecInitProviderLoadBalancerArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether client certificate expiry is ignored. Default is false.</summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, verify and passthrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecInitProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1LBListenerSpecInitProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnRef")]
    public V1beta1LBListenerSpecInitProviderLoadBalancerArnRef? LoadBalancerArnRef { get; set; }

    /// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnSelector")]
    public V1beta1LBListenerSpecInitProviderLoadBalancerArnSelector? LoadBalancerArnSelector { get; set; }

    /// <summary>The mutual authentication configuration information. Detailed below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public IList<V1beta1LBListenerSpecInitProviderMutualAuthentication>? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, and TCP_UDP. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecProviderConfigRefPolicy
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
public partial class V1beta1LBListenerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1LBListenerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LBListenerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LBListenerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LBListenerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LBListenerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LBListenerSpec defines the desired state of LBListener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LBListenerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LBListenerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LBListenerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LBListenerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LBListenerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. Detailed below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. Detailed below.</summary>
    [JsonPropertyName("stickiness")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionForwardStickiness>? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. Detailed below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. Detailed below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionAuthenticateCognito>? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. Detailed below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionAuthenticateOidc>? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionFixedResponse>? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. Cannot be specified with target_group_arn. Detailed below.</summary>
    [JsonPropertyName("forward")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionForward>? Forward { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. Detailed below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultActionRedirect>? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Cannot be specified with forward.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito and authenticate-oidc.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether client certificate expiry is ignored. Default is false.</summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, verify and passthrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusAtProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the listener (matches id).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta1LBListenerStatusAtProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>ARN of the listener (matches arn).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>The mutual authentication configuration information. Detailed below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public IList<V1beta1LBListenerStatusAtProviderMutualAuthentication>? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, and TCP_UDP. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatusConditions
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

/// <summary>LBListenerStatus defines the observed state of LBListener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LBListenerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LBListenerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LBListenerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LBListener is the Schema for the LBListeners API. Provides a Load Balancer Listener resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LBListener : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LBListenerSpec>, IStatus<V1beta1LBListenerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LBListener";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblisteners";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBListenerSpec defines the desired state of LBListener</summary>
    [JsonPropertyName("spec")]
    public V1beta1LBListenerSpec Spec { get; set; }

    /// <summary>LBListenerStatus defines the observed state of LBListener.</summary>
    [JsonPropertyName("status")]
    public V1beta1LBListenerStatus? Status { get; set; }
}