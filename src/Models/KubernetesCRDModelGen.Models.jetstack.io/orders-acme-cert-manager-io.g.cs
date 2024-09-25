using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acme.certmanager.io;
/// <summary>IssuerRef references a properly configured ACME-type Issuer which should be used to create this Order. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Order will be marked as failed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1OrderSpecIssuerRef
{
    /// <summary>Group of the resource being referred to.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind of the resource being referred to.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the resource being referred to.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1OrderSpec
{
    /// <summary>CommonName is the common name as specified on the DER encoded CSR. If specified, this value must also be present in `dnsNames` or `ipAddresses`. This field must match the corresponding field on the DER encoded CSR.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>DNSNames is a list of DNS names that should be included as part of the Order validation process. This field must match the corresponding field on the DER encoded CSR.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Duration is the duration for the not after date for the requested certificate. this is set on order creation as pe the ACME spec.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>IPAddresses is a list of IP addresses that should be included as part of the Order validation process. This field must match the corresponding field on the DER encoded CSR.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>IssuerRef references a properly configured ACME-type Issuer which should be used to create this Order. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Order will be marked as failed.</summary>
    [JsonPropertyName("issuerRef")]
    public V1OrderSpecIssuerRef IssuerRef { get; set; }

    /// <summary>Certificate signing request bytes in DER encoding. This will be used when finalizing the order. This field must be set on the order.</summary>
    [JsonPropertyName("request")]
    public string Request { get; set; }
}

/// <summary>Challenge specifies a challenge offered by the ACME server for an Order. An appropriate Challenge resource can be created to perform the ACME challenge process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1OrderStatusAuthorizationsChallenges
{
    /// <summary>Token is the token that must be presented for this challenge. This is used to compute the 'key' that must also be presented.</summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }

    /// <summary>Type is the type of challenge being offered, e.g. 'http-01', 'dns-01', 'tls-sni-01', etc. This is the raw value retrieved from the ACME server. Only 'http-01' and 'dns-01' are supported by cert-manager, other values will be ignored.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>URL is the URL of this challenge. It can be used to retrieve additional metadata about the Challenge from the ACME server.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>InitialState is the initial state of the ACME authorization when first fetched from the ACME server. If an Authorization is already 'valid', the Order controller will not create a Challenge resource for the authorization. This will occur when working with an ACME server that enables 'authz reuse' (such as Let's Encrypt's production endpoint). If not set and 'identifier' is set, the state is assumed to be pending and a Challenge will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1OrderStatusAuthorizationsInitialStateEnum
{
    [EnumMember(Value = "valid"), JsonStringEnumMemberName("valid")]
    /// <summary>valid</summary>
    Valid,
    [EnumMember(Value = "ready"), JsonStringEnumMemberName("ready")]
    /// <summary>ready</summary>
    Ready,
    [EnumMember(Value = "pending"), JsonStringEnumMemberName("pending")]
    /// <summary>pending</summary>
    Pending,
    [EnumMember(Value = "processing"), JsonStringEnumMemberName("processing")]
    /// <summary>processing</summary>
    Processing,
    [EnumMember(Value = "invalid"), JsonStringEnumMemberName("invalid")]
    /// <summary>invalid</summary>
    Invalid,
    [EnumMember(Value = "expired"), JsonStringEnumMemberName("expired")]
    /// <summary>expired</summary>
    Expired,
    [EnumMember(Value = "errored"), JsonStringEnumMemberName("errored")]
    /// <summary>errored</summary>
    Errored
}

/// <summary>ACMEAuthorization contains data returned from the ACME server on an authorization that must be completed in order validate a DNS name on an ACME Order resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1OrderStatusAuthorizations
{
    /// <summary>Challenges specifies the challenge types offered by the ACME server. One of these challenge types will be selected when validating the DNS name and an appropriate Challenge resource will be created to perform the ACME challenge process.</summary>
    [JsonPropertyName("challenges")]
    public IList<V1OrderStatusAuthorizationsChallenges>? Challenges { get; set; }

    /// <summary>Identifier is the DNS name to be validated as part of this authorization</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>InitialState is the initial state of the ACME authorization when first fetched from the ACME server. If an Authorization is already 'valid', the Order controller will not create a Challenge resource for the authorization. This will occur when working with an ACME server that enables 'authz reuse' (such as Let's Encrypt's production endpoint). If not set and 'identifier' is set, the state is assumed to be pending and a Challenge will be created.</summary>
    [JsonPropertyName("initialState")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1OrderStatusAuthorizationsInitialStateEnum>))]
    public V1OrderStatusAuthorizationsInitialStateEnum? InitialState { get; set; }

    /// <summary>URL is the URL of the Authorization that must be completed</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>Wildcard will be true if this authorization is for a wildcard DNS name. If this is true, the identifier will be the *non-wildcard* version of the DNS name. For example, if '*.example.com' is the DNS name being validated, this field will be 'true' and the 'identifier' field will be 'example.com'.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>State contains the current state of this Order resource. States 'success' and 'expired' are 'final'</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1OrderStatusStateEnum
{
    [EnumMember(Value = "valid"), JsonStringEnumMemberName("valid")]
    /// <summary>valid</summary>
    Valid,
    [EnumMember(Value = "ready"), JsonStringEnumMemberName("ready")]
    /// <summary>ready</summary>
    Ready,
    [EnumMember(Value = "pending"), JsonStringEnumMemberName("pending")]
    /// <summary>pending</summary>
    Pending,
    [EnumMember(Value = "processing"), JsonStringEnumMemberName("processing")]
    /// <summary>processing</summary>
    Processing,
    [EnumMember(Value = "invalid"), JsonStringEnumMemberName("invalid")]
    /// <summary>invalid</summary>
    Invalid,
    [EnumMember(Value = "expired"), JsonStringEnumMemberName("expired")]
    /// <summary>expired</summary>
    Expired,
    [EnumMember(Value = "errored"), JsonStringEnumMemberName("errored")]
    /// <summary>errored</summary>
    Errored
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1OrderStatus
{
    /// <summary>Authorizations contains data returned from the ACME server on what authorizations must be completed in order to validate the DNS names specified on the Order.</summary>
    [JsonPropertyName("authorizations")]
    public IList<V1OrderStatusAuthorizations>? Authorizations { get; set; }

    /// <summary>Certificate is a copy of the PEM encoded certificate for this Order. This field will be populated after the order has been successfully finalized with the ACME server, and the order has transitioned to the 'valid' state.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>FailureTime stores the time that this order failed. This is used to influence garbage collection and back-off.</summary>
    [JsonPropertyName("failureTime")]
    public string? FailureTime { get; set; }

    /// <summary>FinalizeURL of the Order. This is used to obtain certificates for this order once it has been completed.</summary>
    [JsonPropertyName("finalizeURL")]
    public string? FinalizeURL { get; set; }

    /// <summary>Reason optionally provides more information about a why the order is in the current state.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>State contains the current state of this Order resource. States 'success' and 'expired' are 'final'</summary>
    [JsonPropertyName("state")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1OrderStatusStateEnum>))]
    public V1OrderStatusStateEnum? State { get; set; }

    /// <summary>URL of the Order. This will initially be empty when the resource is first created. The Order controller will populate this field when the Order is first processed. This field will be immutable after it is initially set.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Order is a type to represent an Order with an ACME server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Order : IKubernetesObject<V1ObjectMeta>, ISpec<V1OrderSpec>, IStatus<V1OrderStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Order";
    public const string KubeGroup = "acme.cert-manager.io";
    public const string KubePluralName = "orders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1OrderSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1OrderStatus? Status { get; set; }
}