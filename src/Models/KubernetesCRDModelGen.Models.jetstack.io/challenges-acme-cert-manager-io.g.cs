using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acme.certmanager.io;
/// <summary>References a properly configured ACME-type Issuer which should be used to create this Challenge. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Challenge will be marked as failed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecIssuerRef
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

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AcmeDNSAccountSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AcmeDNS
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("accountSecretRef")]
    public V1ChallengeSpecSolverDns01AcmeDNSAccountSecretRef AccountSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AkamaiAccessTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AkamaiClientSecretSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AkamaiClientTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the Akamai DNS zone management API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Akamai
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1ChallengeSpecSolverDns01AkamaiAccessTokenSecretRef AccessTokenSecretRef { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1ChallengeSpecSolverDns01AkamaiClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("clientTokenSecretRef")]
    public V1ChallengeSpecSolverDns01AkamaiClientTokenSecretRef ClientTokenSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceConsumerDomain")]
    public string ServiceConsumerDomain { get; set; }
}

/// <summary>Auth: Azure Service Principal: A reference to a Secret containing the password associated with the Service Principal. If set, ClientID and TenantID must also be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AzureDNSClientSecretSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>name of the Azure environment (default AzurePublicCloud)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ChallengeSpecSolverDns01AzureDNSEnvironmentEnum
{
    [EnumMember(Value = "AzurePublicCloud"), JsonStringEnumMemberName("AzurePublicCloud")]
    /// <summary>AzurePublicCloud</summary>
    AzurePublicCloud,
    [EnumMember(Value = "AzureChinaCloud"), JsonStringEnumMemberName("AzureChinaCloud")]
    /// <summary>AzureChinaCloud</summary>
    AzureChinaCloud,
    [EnumMember(Value = "AzureGermanCloud"), JsonStringEnumMemberName("AzureGermanCloud")]
    /// <summary>AzureGermanCloud</summary>
    AzureGermanCloud,
    [EnumMember(Value = "AzureUSGovernmentCloud"), JsonStringEnumMemberName("AzureUSGovernmentCloud")]
    /// <summary>AzureUSGovernmentCloud</summary>
    AzureUSGovernmentCloud
}

/// <summary>Auth: Azure Workload Identity or Azure Managed Service Identity: Settings to enable Azure Workload Identity or Azure Managed Service Identity If set, ClientID, ClientSecret and TenantID must not be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AzureDNSManagedIdentity
{
    /// <summary>client ID of the managed identity, can not be used at the same time as resourceID</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>resource ID of the managed identity, can not be used at the same time as clientID Cannot be used for Azure Managed Service Identity</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary>Use the Microsoft Azure DNS API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01AzureDNS
{
    /// <summary>Auth: Azure Service Principal: The ClientID of the Azure Service Principal used to authenticate with Azure DNS. If set, ClientSecret and TenantID must also be set.</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>Auth: Azure Service Principal: A reference to a Secret containing the password associated with the Service Principal. If set, ClientID and TenantID must also be set.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1ChallengeSpecSolverDns01AzureDNSClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>name of the Azure environment (default AzurePublicCloud)</summary>
    [JsonPropertyName("environment")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ChallengeSpecSolverDns01AzureDNSEnvironmentEnum>))]
    public V1ChallengeSpecSolverDns01AzureDNSEnvironmentEnum? Environment { get; set; }

    /// <summary>name of the DNS zone that should be used</summary>
    [JsonPropertyName("hostedZoneName")]
    public string? HostedZoneName { get; set; }

    /// <summary>Auth: Azure Workload Identity or Azure Managed Service Identity: Settings to enable Azure Workload Identity or Azure Managed Service Identity If set, ClientID, ClientSecret and TenantID must not be set.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1ChallengeSpecSolverDns01AzureDNSManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>resource group the DNS zone is located in</summary>
    [JsonPropertyName("resourceGroupName")]
    public string ResourceGroupName { get; set; }

    /// <summary>ID of the Azure subscription</summary>
    [JsonPropertyName("subscriptionID")]
    public string SubscriptionID { get; set; }

    /// <summary>Auth: Azure Service Principal: The TenantID of the Azure Service Principal used to authenticate with Azure DNS. If set, ClientID and ClientSecret must also be set.</summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01CloudDNSServiceAccountSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the Google Cloud DNS API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01CloudDNS
{
    /// <summary>HostedZoneName is an optional field that tells cert-manager in which Cloud DNS zone the challenge record has to be created. If left empty cert-manager will automatically choose a zone.</summary>
    [JsonPropertyName("hostedZoneName")]
    public string? HostedZoneName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("serviceAccountSecretRef")]
    public V1ChallengeSpecSolverDns01CloudDNSServiceAccountSecretRef? ServiceAccountSecretRef { get; set; }
}

/// <summary>API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01CloudflareApiKeySecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>API token used to authenticate with Cloudflare.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01CloudflareApiTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the Cloudflare API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Cloudflare
{
    /// <summary>API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.</summary>
    [JsonPropertyName("apiKeySecretRef")]
    public V1ChallengeSpecSolverDns01CloudflareApiKeySecretRef? ApiKeySecretRef { get; set; }

    /// <summary>API token used to authenticate with Cloudflare.</summary>
    [JsonPropertyName("apiTokenSecretRef")]
    public V1ChallengeSpecSolverDns01CloudflareApiTokenSecretRef? ApiTokenSecretRef { get; set; }

    /// <summary>Email of the account, only required when using API key based authentication.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ChallengeSpecSolverDns01CnameStrategyEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None,
    [EnumMember(Value = "Follow"), JsonStringEnumMemberName("Follow")]
    /// <summary>Follow</summary>
    Follow
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01DigitaloceanTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the DigitalOcean DNS API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Digitalocean
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1ChallengeSpecSolverDns01DigitaloceanTokenSecretRef TokenSecretRef { get; set; }
}

/// <summary>The name of the secret containing the TSIG value. If ``tsigKeyName`` is defined, this field is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Rfc2136TsigSecretSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Rfc2136
{
    /// <summary>The IP address or hostname of an authoritative DNS server supporting RFC2136 in the form host:port. If the host is an IPv6 address it must be enclosed in square brackets (e.g [2001:db8::1]) ; port is optional. This field is required.</summary>
    [JsonPropertyName("nameserver")]
    public string Nameserver { get; set; }

    /// <summary>The TSIG Algorithm configured in the DNS supporting RFC2136. Used only when ``tsigSecretSecretRef`` and ``tsigKeyName`` are defined. Supported values are (case-insensitive): ``HMACMD5`` (default), ``HMACSHA1``, ``HMACSHA256`` or ``HMACSHA512``.</summary>
    [JsonPropertyName("tsigAlgorithm")]
    public string? TsigAlgorithm { get; set; }

    /// <summary>The TSIG Key name configured in the DNS. If ``tsigSecretSecretRef`` is defined, this field is required.</summary>
    [JsonPropertyName("tsigKeyName")]
    public string? TsigKeyName { get; set; }

    /// <summary>The name of the secret containing the TSIG value. If ``tsigKeyName`` is defined, this field is required.</summary>
    [JsonPropertyName("tsigSecretSecretRef")]
    public V1ChallengeSpecSolverDns01Rfc2136TsigSecretSecretRef? TsigSecretSecretRef { get; set; }
}

/// <summary>The SecretAccessKey is used for authentication. If set, pull the AWS access key ID from a key within a Kubernetes Secret. Cannot be set when AccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53AccessKeyIDSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A reference to a service account that will be used to request a bound token (also known as "projected token"). To use this field, you must configure an RBAC rule to let cert-manager request a token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53AuthKubernetesServiceAccountRef
{
    /// <summary>TokenAudiences is an optional list of audiences to include in the token passed to AWS. The default token consisting of the issuer's namespace and name is always included. If unset the audience defaults to `sts.amazonaws.com`.</summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>Name of the ServiceAccount used to request a token.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kubernetes authenticates with Route53 using AssumeRoleWithWebIdentity by passing a bound ServiceAccount token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53AuthKubernetes
{
    /// <summary>A reference to a service account that will be used to request a bound token (also known as "projected token"). To use this field, you must configure an RBAC rule to let cert-manager request a token.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1ChallengeSpecSolverDns01Route53AuthKubernetesServiceAccountRef ServiceAccountRef { get; set; }
}

/// <summary>Auth configures how cert-manager authenticates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53Auth
{
    /// <summary>Kubernetes authenticates with Route53 using AssumeRoleWithWebIdentity by passing a bound ServiceAccount token.</summary>
    [JsonPropertyName("kubernetes")]
    public V1ChallengeSpecSolverDns01Route53AuthKubernetes Kubernetes { get; set; }
}

/// <summary>The SecretAccessKey is used for authentication. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53SecretAccessKeySecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Use the AWS Route53 API to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Route53
{
    /// <summary>The AccessKeyID is used for authentication. Cannot be set when SecretAccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
    [JsonPropertyName("accessKeyID")]
    public string? AccessKeyID { get; set; }

    /// <summary>The SecretAccessKey is used for authentication. If set, pull the AWS access key ID from a key within a Kubernetes Secret. Cannot be set when AccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
    [JsonPropertyName("accessKeyIDSecretRef")]
    public V1ChallengeSpecSolverDns01Route53AccessKeyIDSecretRef? AccessKeyIDSecretRef { get; set; }

    /// <summary>Auth configures how cert-manager authenticates.</summary>
    [JsonPropertyName("auth")]
    public V1ChallengeSpecSolverDns01Route53Auth? Auth { get; set; }

    /// <summary>If set, the provider will manage only this zone in Route53 and will not do an lookup using the route53:ListHostedZonesByName api call.</summary>
    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>Always set the region when using AccessKeyID and SecretAccessKey</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Role is a Role ARN which the Route53 provider will assume using either the explicit credentials AccessKeyID/SecretAccessKey or the inferred credentials from environment variables, shared credentials file or AWS Instance metadata</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>The SecretAccessKey is used for authentication. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1ChallengeSpecSolverDns01Route53SecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

/// <summary>Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01Webhook
{
    /// <summary>Additional configuration that should be passed to the webhook apiserver when challenges are processed. This can contain arbitrary JSON data. Secret values should not be specified in this stanza. If secret values are needed (e.g. credentials for a DNS service), you should use a SecretKeySelector to reference a Secret resource. For details on the schema of this field, consult the webhook provider implementation's documentation.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>The API group name that should be used when POSTing ChallengePayload resources to the webhook apiserver. This should be the same as the GroupName specified in the webhook provider implementation.</summary>
    [JsonPropertyName("groupName")]
    public string GroupName { get; set; }

    /// <summary>The name of the solver to use, as defined in the webhook provider implementation. This will typically be the name of the provider, e.g. 'cloudflare'.</summary>
    [JsonPropertyName("solverName")]
    public string SolverName { get; set; }
}

/// <summary>Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverDns01
{
    /// <summary>Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("acmeDNS")]
    public V1ChallengeSpecSolverDns01AcmeDNS? AcmeDNS { get; set; }

    /// <summary>Use the Akamai DNS zone management API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("akamai")]
    public V1ChallengeSpecSolverDns01Akamai? Akamai { get; set; }

    /// <summary>Use the Microsoft Azure DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("azureDNS")]
    public V1ChallengeSpecSolverDns01AzureDNS? AzureDNS { get; set; }

    /// <summary>Use the Google Cloud DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("cloudDNS")]
    public V1ChallengeSpecSolverDns01CloudDNS? CloudDNS { get; set; }

    /// <summary>Use the Cloudflare API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("cloudflare")]
    public V1ChallengeSpecSolverDns01Cloudflare? Cloudflare { get; set; }

    /// <summary>CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.</summary>
    [JsonPropertyName("cnameStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ChallengeSpecSolverDns01CnameStrategyEnum>))]
    public V1ChallengeSpecSolverDns01CnameStrategyEnum? CnameStrategy { get; set; }

    /// <summary>Use the DigitalOcean DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("digitalocean")]
    public V1ChallengeSpecSolverDns01Digitalocean? Digitalocean { get; set; }

    /// <summary>Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.</summary>
    [JsonPropertyName("rfc2136")]
    public V1ChallengeSpecSolverDns01Rfc2136? Rfc2136 { get; set; }

    /// <summary>Use the AWS Route53 API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("route53")]
    public V1ChallengeSpecSolverDns01Route53? Route53 { get; set; }

    /// <summary>Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.</summary>
    [JsonPropertyName("webhook")]
    public V1ChallengeSpecSolverDns01Webhook? Webhook { get; set; }
}

/// <summary>ParentReference identifies an API object (usually a Gateway) that can be considered a parent of this resource (usually a route). There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   This API may be extended in the future to support additional kinds of parent resources.   The API object must be valid in the cluster; the Group and Kind must be registered in the cluster for this reference to be valid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01GatewayHTTPRouteParentRefs
{
    /// <summary>Group is the group of the referent. When unspecified, "gateway.networking.k8s.io" is inferred. To set the core API group (such as for a "Service" kind referent), Group must be explicitly set to "" (empty string).   Support: Core</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent.   There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   Support for other resources is Implementation-Specific.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.   Support: Core</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the referent. When unspecified, this refers to the local namespace of the Route.   Note that there are specific rules for ParentRefs which cross namespace boundaries. Cross-namespace references are only valid if they are explicitly allowed by something in the namespace they are referring to. For example: Gateway has the AllowedRoutes field, and ReferenceGrant provides a generic way to enable any other kind of cross-namespace reference.   &lt;gateway:experimental:description&gt; ParentRefs from a Route to a Service in the same namespace are "producer" routes, which apply default routing rules to inbound connections from any namespace to the Service.   ParentRefs from a Route to a Service in a different namespace are "consumer" routes, and these routing rules are only applied to outbound connections originating from the same namespace as the Route, for which the intended destination of the connections are a Service targeted as a ParentRef of the Route. &lt;/gateway:experimental:description&gt;   Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port is the network port this Route targets. It can be interpreted differently based on the type of parent resource.   When the parent resource is a Gateway, this targets all listeners listening on the specified port that also support this kind of Route(and select this Route). It's not recommended to set `Port` unless the networking behaviors specified in a Route must apply to a specific port as opposed to a listener(s) whose port(s) may be changed. When both Port and SectionName are specified, the name and port of the selected listener must match both specified values.   &lt;gateway:experimental:description&gt; When the parent resource is a Service, this targets a specific port in the Service spec. When both Port (experimental) and SectionName are specified, the name and port of the selected port must match both specified values. &lt;/gateway:experimental:description&gt;   Implementations MAY choose to support other parent resources. Implementations supporting other types of parent resources MUST clearly document how/if Port is interpreted.   For the purpose of status, an attachment is considered successful as long as the parent resource accepts it partially. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Extended</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SectionName is the name of a section within the target resource. In the following resources, SectionName is interpreted as the following:   * Gateway: Listener name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values. * Service: Port name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values.   Implementations MAY choose to support attaching Routes to other resources. If that is the case, they MUST clearly document how SectionName is interpreted.   When unspecified (empty string), this will reference the entire resource. For the purpose of status, an attachment is considered successful if at least one section in the parent resource accepts it. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Core</summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

/// <summary>The Gateway API is a sig-network community API that models service networking in Kubernetes (https://gateway-api.sigs.k8s.io/). The Gateway solver will create HTTPRoutes with the specified labels in the same namespace as the challenge. This solver is experimental, and fields / behaviour may change in the future.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01GatewayHTTPRoute
{
    /// <summary>Custom labels that will be applied to HTTPRoutes created by cert-manager while solving HTTP-01 challenges.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>When solving an HTTP-01 challenge, cert-manager creates an HTTPRoute. cert-manager needs to know which parentRefs should be used when creating the HTTPRoute. Usually, the parentRef references a Gateway. See: https://gateway-api.sigs.k8s.io/api-types/httproute/#attaching-to-gateways</summary>
    [JsonPropertyName("parentRefs")]
    public IList<V1ChallengeSpecSolverHttp01GatewayHTTPRouteParentRefs>? ParentRefs { get; set; }

    /// <summary>Optional service type for Kubernetes solver service. Supported values are NodePort or ClusterIP. If unset, defaults to NodePort.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }
}

/// <summary>ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressIngressTemplateMetadata
{
    /// <summary>Annotations that should be added to the created ACME HTTP01 solver ingress.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels that should be added to the created ACME HTTP01 solver ingress.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressIngressTemplate
{
    /// <summary>ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
    [JsonPropertyName("metadata")]
    public V1ChallengeSpecSolverHttp01IngressIngressTemplateMetadata? Metadata { get; set; }
}

/// <summary>ObjectMeta overrides for the pod used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateMetadata
{
    /// <summary>Annotations that should be added to the create ACME HTTP01 solver pods.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels that should be added to the created ACME HTTP01 solver pods.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If specified, the pod's scheduling constraints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecImagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpecTolerations
{
    /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PodSpec defines overrides for the HTTP01 challenge solver pod. Check ACMEChallengeSolverHTTP01IngressPodSpec to find out currently supported fields. All other fields will be ignored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplateSpec
{
    /// <summary>If specified, the pod's scheduling constraints</summary>
    [JsonPropertyName("affinity")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>If specified, the pod's imagePullSecrets</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>If specified, the pod's priorityClassName.</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>If specified, the pod's service account</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>If specified, the pod's tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1ChallengeSpecSolverHttp01IngressPodTemplateSpecTolerations>? Tolerations { get; set; }
}

/// <summary>Optional pod template used to configure the ACME challenge solver pods used for HTTP01 challenges.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01IngressPodTemplate
{
    /// <summary>ObjectMeta overrides for the pod used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
    [JsonPropertyName("metadata")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateMetadata? Metadata { get; set; }

    /// <summary>PodSpec defines overrides for the HTTP01 challenge solver pod. Check ACMEChallengeSolverHTTP01IngressPodSpec to find out currently supported fields. All other fields will be ignored.</summary>
    [JsonPropertyName("spec")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplateSpec? Spec { get; set; }
}

/// <summary>The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01Ingress
{
    /// <summary>This field configures the annotation `kubernetes.io/ingress.class` when creating Ingress resources to solve ACME challenges that use this challenge solver. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>This field configures the field `ingressClassName` on the created Ingress resources used to solve ACME challenges that use this challenge solver. This is the recommended way of configuring the ingress class. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("ingressClassName")]
    public string? IngressClassName { get; set; }

    /// <summary>Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges.</summary>
    [JsonPropertyName("ingressTemplate")]
    public V1ChallengeSpecSolverHttp01IngressIngressTemplate? IngressTemplate { get; set; }

    /// <summary>The name of the ingress resource that should have ACME challenge solving routes inserted into it in order to solve HTTP01 challenges. This is typically used in conjunction with ingress controllers like ingress-gce, which maintains a 1:1 mapping between external IPs and ingress resources. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional pod template used to configure the ACME challenge solver pods used for HTTP01 challenges.</summary>
    [JsonPropertyName("podTemplate")]
    public V1ChallengeSpecSolverHttp01IngressPodTemplate? PodTemplate { get; set; }

    /// <summary>Optional service type for Kubernetes solver service. Supported values are NodePort or ClusterIP. If unset, defaults to NodePort.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }
}

/// <summary>Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverHttp01
{
    /// <summary>The Gateway API is a sig-network community API that models service networking in Kubernetes (https://gateway-api.sigs.k8s.io/). The Gateway solver will create HTTPRoutes with the specified labels in the same namespace as the challenge. This solver is experimental, and fields / behaviour may change in the future.</summary>
    [JsonPropertyName("gatewayHTTPRoute")]
    public V1ChallengeSpecSolverHttp01GatewayHTTPRoute? GatewayHTTPRoute { get; set; }

    /// <summary>The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.</summary>
    [JsonPropertyName("ingress")]
    public V1ChallengeSpecSolverHttp01Ingress? Ingress { get; set; }
}

/// <summary>Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolverSelector
{
    /// <summary>List of DNSNames that this solver will be used to solve. If specified and a match is found, a dnsNames selector will take precedence over a dnsZones selector. If multiple solvers match with the same dnsNames value, the solver with the most matching labels in matchLabels will be selected. If neither has more matches, the solver defined earlier in the list will be selected.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>List of DNSZones that this solver will be used to solve. The most specific DNS zone match specified here will take precedence over other DNS zone matches, so a solver specifying sys.example.com will be selected over one specifying example.com for the domain www.sys.example.com. If multiple solvers match with the same dnsZones value, the solver with the most matching labels in matchLabels will be selected. If neither has more matches, the solver defined earlier in the list will be selected.</summary>
    [JsonPropertyName("dnsZones")]
    public IList<string>? DnsZones { get; set; }

    /// <summary>A label selector that is used to refine the set of certificate's that this challenge solver will apply to.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Contains the domain solving configuration that should be used to solve this challenge resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpecSolver
{
    /// <summary>Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.</summary>
    [JsonPropertyName("dns01")]
    public V1ChallengeSpecSolverDns01? Dns01 { get; set; }

    /// <summary>Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.</summary>
    [JsonPropertyName("http01")]
    public V1ChallengeSpecSolverHttp01? Http01 { get; set; }

    /// <summary>Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.</summary>
    [JsonPropertyName("selector")]
    public V1ChallengeSpecSolverSelector? Selector { get; set; }
}

/// <summary>The type of ACME challenge this resource represents. One of "HTTP-01" or "DNS-01".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ChallengeSpecTypeEnum
{
    [EnumMember(Value = "HTTP-01"), JsonStringEnumMemberName("HTTP-01")]
    /// <summary>HTTP-01</summary>
    HTTP01,
    [EnumMember(Value = "DNS-01"), JsonStringEnumMemberName("DNS-01")]
    /// <summary>DNS-01</summary>
    DNS01
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ChallengeSpec
{
    /// <summary>The URL to the ACME Authorization resource that this challenge is a part of.</summary>
    [JsonPropertyName("authorizationURL")]
    public string AuthorizationURL { get; set; }

    /// <summary>dnsName is the identifier that this challenge is for, e.g. example.com. If the requested DNSName is a 'wildcard', this field MUST be set to the non-wildcard domain, e.g. for `*.example.com`, it must be `example.com`.</summary>
    [JsonPropertyName("dnsName")]
    public string DnsName { get; set; }

    /// <summary>References a properly configured ACME-type Issuer which should be used to create this Challenge. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Challenge will be marked as failed.</summary>
    [JsonPropertyName("issuerRef")]
    public V1ChallengeSpecIssuerRef IssuerRef { get; set; }

    /// <summary>The ACME challenge key for this challenge For HTTP01 challenges, this is the value that must be responded with to complete the HTTP01 challenge in the format: `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;`. For DNS01 challenges, this is the base64 encoded SHA256 sum of the `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;` text that must be set as the TXT record content.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Contains the domain solving configuration that should be used to solve this challenge resource.</summary>
    [JsonPropertyName("solver")]
    public V1ChallengeSpecSolver Solver { get; set; }

    /// <summary>The ACME challenge token for this challenge. This is the raw value returned from the ACME server.</summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }

    /// <summary>The type of ACME challenge this resource represents. One of "HTTP-01" or "DNS-01".</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ChallengeSpecTypeEnum>))]
    public V1ChallengeSpecTypeEnum Type { get; set; }

    /// <summary>The URL of the ACME Challenge resource for this challenge. This can be used to lookup details about the status of this challenge.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>wildcard will be true if this challenge is for a wildcard identifier, for example '*.example.com'.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>Contains the current 'state' of the challenge. If not set, the state of the challenge is unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ChallengeStatusStateEnum
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
public partial class V1ChallengeStatus
{
    /// <summary>presented will be set to true if the challenge values for this challenge are currently 'presented'. This *does not* imply the self check is passing. Only that the values have been 'submitted' for the appropriate challenge mechanism (i.e. the DNS01 TXT record has been presented, or the HTTP01 configuration has been configured).</summary>
    [JsonPropertyName("presented")]
    public bool? Presented { get; set; }

    /// <summary>Used to denote whether this challenge should be processed or not. This field will only be set to true by the 'scheduling' component. It will only be set to false by the 'challenges' controller, after the challenge has reached a final state or timed out. If this field is set to false, the challenge controller will not take any more action.</summary>
    [JsonPropertyName("processing")]
    public bool? Processing { get; set; }

    /// <summary>Contains human readable information on why the Challenge is in the current state.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Contains the current 'state' of the challenge. If not set, the state of the challenge is unknown.</summary>
    [JsonPropertyName("state")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ChallengeStatusStateEnum>))]
    public V1ChallengeStatusStateEnum? State { get; set; }
}

/// <summary>Challenge is a type to represent a Challenge request with an ACME server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Challenge : IKubernetesObject<V1ObjectMeta>, ISpec<V1ChallengeSpec>, IStatus<V1ChallengeStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Challenge";
    public const string KubeGroup = "acme.cert-manager.io";
    public const string KubePluralName = "challenges";
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
    public V1ChallengeSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1ChallengeStatus? Status { get; set; }
}