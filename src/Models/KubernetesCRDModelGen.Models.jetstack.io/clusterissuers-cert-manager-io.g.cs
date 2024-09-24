using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certmanager.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ClusterIssuerSpecAcmeExternalAccountBindingKeyAlgorithmEnum
{
    [EnumMember(Value = "HS256"), JsonStringEnumMemberName("HS256")]
    /// <summary>HS256</summary>
    HS256,
    [EnumMember(Value = "HS384"), JsonStringEnumMemberName("HS384")]
    /// <summary>HS384</summary>
    HS384,
    [EnumMember(Value = "HS512"), JsonStringEnumMemberName("HS512")]
    /// <summary>HS512</summary>
    HS512
}

/// <summary>keySecretRef is a Secret Key Selector referencing a data item in a Kubernetes Secret which holds the symmetric MAC key of the External Account Binding. The `key` is the index string that is paired with the key data in the Secret and should not be confused with the key data itself, or indeed with the External Account Binding keyID above. The secret key stored in the Secret **must** be un-padded, base64 URL encoded data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeExternalAccountBindingKeySecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ExternalAccountBinding is a reference to a CA external account of the ACME server. If set, upon registration cert-manager will attempt to associate the given external account credentials with the registered ACME account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeExternalAccountBinding
{
    /// <summary>Deprecated: keyAlgorithm field exists for historical compatibility reasons and should not be used. The algorithm is now hardcoded to HS256 in golang/x/crypto/acme.</summary>
    [JsonPropertyName("keyAlgorithm")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ClusterIssuerSpecAcmeExternalAccountBindingKeyAlgorithmEnum>))]
    public V1ClusterIssuerSpecAcmeExternalAccountBindingKeyAlgorithmEnum? KeyAlgorithm { get; set; }

    /// <summary>keyID is the ID of the CA key that the External Account is bound to.</summary>
    [JsonPropertyName("keyID")]
    public string KeyID { get; set; }

    /// <summary>keySecretRef is a Secret Key Selector referencing a data item in a Kubernetes Secret which holds the symmetric MAC key of the External Account Binding. The `key` is the index string that is paired with the key data in the Secret and should not be confused with the key data itself, or indeed with the External Account Binding keyID above. The secret key stored in the Secret **must** be un-padded, base64 URL encoded data.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1ClusterIssuerSpecAcmeExternalAccountBindingKeySecretRef KeySecretRef { get; set; }
}

/// <summary>PrivateKey is the name of a Kubernetes Secret resource that will be used to store the automatically generated ACME account private key. Optionally, a `key` may be specified to select a specific entry within the named Secret resource. If `key` is not specified, a default of `tls.key` will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmePrivateKeySecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AcmeDNS
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("accountSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef AccountSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }
}

/// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Akamai
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef AccessTokenSecretRef { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("clientTokenSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef ClientTokenSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceConsumerDomain")]
    public string ServiceConsumerDomain { get; set; }
}

/// <summary>Auth: Azure Service Principal: A reference to a Secret containing the password associated with the Service Principal. If set, ClientID and TenantID must also be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01AzureDNSClientSecretSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ClusterIssuerSpecAcmeSolversDns01AzureDNSEnvironmentEnum
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AzureDNSManagedIdentity
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01AzureDNS
{
    /// <summary>Auth: Azure Service Principal: The ClientID of the Azure Service Principal used to authenticate with Azure DNS. If set, ClientSecret and TenantID must also be set.</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>Auth: Azure Service Principal: A reference to a Secret containing the password associated with the Service Principal. If set, ClientID and TenantID must also be set.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01AzureDNSClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>name of the Azure environment (default AzurePublicCloud)</summary>
    [JsonPropertyName("environment")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ClusterIssuerSpecAcmeSolversDns01AzureDNSEnvironmentEnum>))]
    public V1ClusterIssuerSpecAcmeSolversDns01AzureDNSEnvironmentEnum? Environment { get; set; }

    /// <summary>name of the DNS zone that should be used</summary>
    [JsonPropertyName("hostedZoneName")]
    public string? HostedZoneName { get; set; }

    /// <summary>Auth: Azure Workload Identity or Azure Managed Service Identity: Settings to enable Azure Workload Identity or Azure Managed Service Identity If set, ClientID, ClientSecret and TenantID must not be set.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1ClusterIssuerSpecAcmeSolversDns01AzureDNSManagedIdentity? ManagedIdentity { get; set; }

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
public partial class V1ClusterIssuerSpecAcmeSolversDns01CloudDNSServiceAccountSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01CloudDNS
{
    /// <summary>HostedZoneName is an optional field that tells cert-manager in which Cloud DNS zone the challenge record has to be created. If left empty cert-manager will automatically choose a zone.</summary>
    [JsonPropertyName("hostedZoneName")]
    public string? HostedZoneName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("serviceAccountSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01CloudDNSServiceAccountSecretRef? ServiceAccountSecretRef { get; set; }
}

/// <summary>API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01CloudflareApiKeySecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01CloudflareApiTokenSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Cloudflare
{
    /// <summary>API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.</summary>
    [JsonPropertyName("apiKeySecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01CloudflareApiKeySecretRef? ApiKeySecretRef { get; set; }

    /// <summary>API token used to authenticate with Cloudflare.</summary>
    [JsonPropertyName("apiTokenSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01CloudflareApiTokenSecretRef? ApiTokenSecretRef { get; set; }

    /// <summary>Email of the account, only required when using API key based authentication.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ClusterIssuerSpecAcmeSolversDns01CnameStrategyEnum
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01DigitaloceanTokenSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Digitalocean
{
    /// <summary>A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01DigitaloceanTokenSecretRef TokenSecretRef { get; set; }
}

/// <summary>The name of the secret containing the TSIG value. If ``tsigKeyName`` is defined, this field is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01Rfc2136TsigSecretSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Rfc2136
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
    public V1ClusterIssuerSpecAcmeSolversDns01Rfc2136TsigSecretSecretRef? TsigSecretSecretRef { get; set; }
}

/// <summary>The SecretAccessKey is used for authentication. If set, pull the AWS access key ID from a key within a Kubernetes Secret. Cannot be set when AccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53AccessKeyIDSecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53AuthKubernetesServiceAccountRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53AuthKubernetes
{
    /// <summary>A reference to a service account that will be used to request a bound token (also known as "projected token"). To use this field, you must configure an RBAC rule to let cert-manager request a token.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01Route53AuthKubernetesServiceAccountRef ServiceAccountRef { get; set; }
}

/// <summary>Auth configures how cert-manager authenticates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53Auth
{
    /// <summary>Kubernetes authenticates with Route53 using AssumeRoleWithWebIdentity by passing a bound ServiceAccount token.</summary>
    [JsonPropertyName("kubernetes")]
    public V1ClusterIssuerSpecAcmeSolversDns01Route53AuthKubernetes Kubernetes { get; set; }
}

/// <summary>The SecretAccessKey is used for authentication. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53SecretAccessKeySecretRef
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01Route53
{
    /// <summary>The AccessKeyID is used for authentication. Cannot be set when SecretAccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
    [JsonPropertyName("accessKeyID")]
    public string? AccessKeyID { get; set; }

    /// <summary>The SecretAccessKey is used for authentication. If set, pull the AWS access key ID from a key within a Kubernetes Secret. Cannot be set when AccessKeyID is set. If neither the Access Key nor Key ID are set, we fall-back to using env vars, shared credentials file or AWS Instance metadata, see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials</summary>
    [JsonPropertyName("accessKeyIDSecretRef")]
    public V1ClusterIssuerSpecAcmeSolversDns01Route53AccessKeyIDSecretRef? AccessKeyIDSecretRef { get; set; }

    /// <summary>Auth configures how cert-manager authenticates.</summary>
    [JsonPropertyName("auth")]
    public V1ClusterIssuerSpecAcmeSolversDns01Route53Auth? Auth { get; set; }

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
    public V1ClusterIssuerSpecAcmeSolversDns01Route53SecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

/// <summary>Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversDns01Webhook
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
public partial class V1ClusterIssuerSpecAcmeSolversDns01
{
    /// <summary>Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("acmeDNS")]
    public V1ClusterIssuerSpecAcmeSolversDns01AcmeDNS? AcmeDNS { get; set; }

    /// <summary>Use the Akamai DNS zone management API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("akamai")]
    public V1ClusterIssuerSpecAcmeSolversDns01Akamai? Akamai { get; set; }

    /// <summary>Use the Microsoft Azure DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("azureDNS")]
    public V1ClusterIssuerSpecAcmeSolversDns01AzureDNS? AzureDNS { get; set; }

    /// <summary>Use the Google Cloud DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("cloudDNS")]
    public V1ClusterIssuerSpecAcmeSolversDns01CloudDNS? CloudDNS { get; set; }

    /// <summary>Use the Cloudflare API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("cloudflare")]
    public V1ClusterIssuerSpecAcmeSolversDns01Cloudflare? Cloudflare { get; set; }

    /// <summary>CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.</summary>
    [JsonPropertyName("cnameStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ClusterIssuerSpecAcmeSolversDns01CnameStrategyEnum>))]
    public V1ClusterIssuerSpecAcmeSolversDns01CnameStrategyEnum? CnameStrategy { get; set; }

    /// <summary>Use the DigitalOcean DNS API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("digitalocean")]
    public V1ClusterIssuerSpecAcmeSolversDns01Digitalocean? Digitalocean { get; set; }

    /// <summary>Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.</summary>
    [JsonPropertyName("rfc2136")]
    public V1ClusterIssuerSpecAcmeSolversDns01Rfc2136? Rfc2136 { get; set; }

    /// <summary>Use the AWS Route53 API to manage DNS01 challenge records.</summary>
    [JsonPropertyName("route53")]
    public V1ClusterIssuerSpecAcmeSolversDns01Route53? Route53 { get; set; }

    /// <summary>Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.</summary>
    [JsonPropertyName("webhook")]
    public V1ClusterIssuerSpecAcmeSolversDns01Webhook? Webhook { get; set; }
}

/// <summary>ParentReference identifies an API object (usually a Gateway) that can be considered a parent of this resource (usually a route). There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   This API may be extended in the future to support additional kinds of parent resources.   The API object must be valid in the cluster; the Group and Kind must be registered in the cluster for this reference to be valid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteParentRefs
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRoute
{
    /// <summary>Custom labels that will be applied to HTTPRoutes created by cert-manager while solving HTTP-01 challenges.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>When solving an HTTP-01 challenge, cert-manager creates an HTTPRoute. cert-manager needs to know which parentRefs should be used when creating the HTTPRoute. Usually, the parentRef references a Gateway. See: https://gateway-api.sigs.k8s.io/api-types/httproute/#attaching-to-gateways</summary>
    [JsonPropertyName("parentRefs")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteParentRefs>? ParentRefs { get; set; }

    /// <summary>Optional service type for Kubernetes solver service. Supported values are NodePort or ClusterIP. If unset, defaults to NodePort.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }
}

/// <summary>ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadata
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplate
{
    /// <summary>ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
    [JsonPropertyName("metadata")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadata? Metadata { get; set; }
}

/// <summary>ObjectMeta overrides for the pod used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If specified, the pod's scheduling constraints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecImagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerations
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
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec
{
    /// <summary>If specified, the pod's scheduling constraints</summary>
    [JsonPropertyName("affinity")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>If specified, the pod's imagePullSecrets</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

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
    public IList<V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerations>? Tolerations { get; set; }
}

/// <summary>Optional pod template used to configure the ACME challenge solver pods used for HTTP01 challenges.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplate
{
    /// <summary>ObjectMeta overrides for the pod used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.</summary>
    [JsonPropertyName("metadata")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata? Metadata { get; set; }

    /// <summary>PodSpec defines overrides for the HTTP01 challenge solver pod. Check ACMEChallengeSolverHTTP01IngressPodSpec to find out currently supported fields. All other fields will be ignored.</summary>
    [JsonPropertyName("spec")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec? Spec { get; set; }
}

/// <summary>The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01Ingress
{
    /// <summary>This field configures the annotation `kubernetes.io/ingress.class` when creating Ingress resources to solve ACME challenges that use this challenge solver. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>This field configures the field `ingressClassName` on the created Ingress resources used to solve ACME challenges that use this challenge solver. This is the recommended way of configuring the ingress class. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("ingressClassName")]
    public string? IngressClassName { get; set; }

    /// <summary>Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges.</summary>
    [JsonPropertyName("ingressTemplate")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplate? IngressTemplate { get; set; }

    /// <summary>The name of the ingress resource that should have ACME challenge solving routes inserted into it in order to solve HTTP01 challenges. This is typically used in conjunction with ingress controllers like ingress-gce, which maintains a 1:1 mapping between external IPs and ingress resources. Only one of `class`, `name` or `ingressClassName` may be specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional pod template used to configure the ACME challenge solver pods used for HTTP01 challenges.</summary>
    [JsonPropertyName("podTemplate")]
    public V1ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplate? PodTemplate { get; set; }

    /// <summary>Optional service type for Kubernetes solver service. Supported values are NodePort or ClusterIP. If unset, defaults to NodePort.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }
}

/// <summary>Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversHttp01
{
    /// <summary>The Gateway API is a sig-network community API that models service networking in Kubernetes (https://gateway-api.sigs.k8s.io/). The Gateway solver will create HTTPRoutes with the specified labels in the same namespace as the challenge. This solver is experimental, and fields / behaviour may change in the future.</summary>
    [JsonPropertyName("gatewayHTTPRoute")]
    public V1ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRoute? GatewayHTTPRoute { get; set; }

    /// <summary>The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.</summary>
    [JsonPropertyName("ingress")]
    public V1ClusterIssuerSpecAcmeSolversHttp01Ingress? Ingress { get; set; }
}

/// <summary>Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolversSelector
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

/// <summary>An ACMEChallengeSolver describes how to solve ACME challenges for the issuer it is part of. A selector may be provided to use different solving strategies for different DNS names. Only one of HTTP01 or DNS01 must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcmeSolvers
{
    /// <summary>Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.</summary>
    [JsonPropertyName("dns01")]
    public V1ClusterIssuerSpecAcmeSolversDns01? Dns01 { get; set; }

    /// <summary>Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.</summary>
    [JsonPropertyName("http01")]
    public V1ClusterIssuerSpecAcmeSolversHttp01? Http01 { get; set; }

    /// <summary>Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.</summary>
    [JsonPropertyName("selector")]
    public V1ClusterIssuerSpecAcmeSolversSelector? Selector { get; set; }
}

/// <summary>ACME configures this issuer to communicate with a RFC8555 (ACME) server to obtain signed x509 certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecAcme
{
    /// <summary>Base64-encoded bundle of PEM CAs which can be used to validate the certificate chain presented by the ACME server. Mutually exclusive with SkipTLSVerify; prefer using CABundle to prevent various kinds of security vulnerabilities. If CABundle and SkipTLSVerify are unset, the system certificate bundle inside the container is used to validate the TLS connection.</summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Enables or disables generating a new ACME account key. If true, the Issuer resource will *not* request a new account but will expect the account key to be supplied via an existing secret. If false, the cert-manager system will generate a new ACME account key for the Issuer. Defaults to false.</summary>
    [JsonPropertyName("disableAccountKeyGeneration")]
    public bool? DisableAccountKeyGeneration { get; set; }

    /// <summary>Email is the email address to be associated with the ACME account. This field is optional, but it is strongly recommended to be set. It will be used to contact you in case of issues with your account or certificates, including expiry notification emails. This field may be updated after the account is initially registered.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Enables requesting a Not After date on certificates that matches the duration of the certificate. This is not supported by all ACME servers like Let's Encrypt. If set to true when the ACME server does not support it, it will create an error on the Order. Defaults to false.</summary>
    [JsonPropertyName("enableDurationFeature")]
    public bool? EnableDurationFeature { get; set; }

    /// <summary>ExternalAccountBinding is a reference to a CA external account of the ACME server. If set, upon registration cert-manager will attempt to associate the given external account credentials with the registered ACME account.</summary>
    [JsonPropertyName("externalAccountBinding")]
    public V1ClusterIssuerSpecAcmeExternalAccountBinding? ExternalAccountBinding { get; set; }

    /// <summary>PreferredChain is the chain to use if the ACME server outputs multiple. PreferredChain is no guarantee that this one gets delivered by the ACME endpoint. For example, for Let's Encrypt's DST crosssign you would use: "DST Root CA X3" or "ISRG Root X1" for the newer Let's Encrypt root CA. This value picks the first certificate bundle in the combined set of ACME default and alternative chains that has a root-most certificate with this value as its issuer's commonname.</summary>
    [JsonPropertyName("preferredChain")]
    public string? PreferredChain { get; set; }

    /// <summary>PrivateKey is the name of a Kubernetes Secret resource that will be used to store the automatically generated ACME account private key. Optionally, a `key` may be specified to select a specific entry within the named Secret resource. If `key` is not specified, a default of `tls.key` will be used.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1ClusterIssuerSpecAcmePrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>Server is the URL used to access the ACME server's 'directory' endpoint. For example, for Let's Encrypt's staging endpoint, you would use: "https://acme-staging-v02.api.letsencrypt.org/directory". Only ACME v2 endpoints (i.e. RFC 8555) are supported.</summary>
    [JsonPropertyName("server")]
    public string Server { get; set; }

    /// <summary>INSECURE: Enables or disables validation of the ACME server TLS certificate. If true, requests to the ACME server will not have the TLS certificate chain validated. Mutually exclusive with CABundle; prefer using CABundle to prevent various kinds of security vulnerabilities. Only enable this option in development environments. If CABundle and SkipTLSVerify are unset, the system certificate bundle inside the container is used to validate the TLS connection. Defaults to false.</summary>
    [JsonPropertyName("skipTLSVerify")]
    public bool? SkipTLSVerify { get; set; }

    /// <summary>Solvers is a list of challenge solvers that will be used to solve ACME challenges for the matching domains. Solver configurations must be provided in order to obtain certificates from an ACME server. For more information, see: https://cert-manager.io/docs/configuration/acme/</summary>
    [JsonPropertyName("solvers")]
    public IList<V1ClusterIssuerSpecAcmeSolvers>? Solvers { get; set; }
}

/// <summary>CA configures this issuer to sign certificates using a signing CA keypair stored in a Secret resource. This is used to build internal PKIs that are managed by cert-manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecCa
{
    /// <summary>The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set, certificates will be issued without distribution points set.</summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }

    /// <summary>IssuingCertificateURLs is a list of URLs which this issuer should embed into certificates it creates. See https://www.rfc-editor.org/rfc/rfc5280#section-4.2.2.1 for more details. As an example, such a URL might be "http://ca.domain.com/ca.crt".</summary>
    [JsonPropertyName("issuingCertificateURLs")]
    public IList<string>? IssuingCertificateURLs { get; set; }

    /// <summary>The OCSP server list is an X.509 v3 extension that defines a list of URLs of OCSP responders. The OCSP responders can be queried for the revocation status of an issued certificate. If not set, the certificate will be issued with no OCSP servers set. For example, an OCSP server URL could be "http://ocsp.int-x3.letsencrypt.org".</summary>
    [JsonPropertyName("ocspServers")]
    public IList<string>? OcspServers { get; set; }

    /// <summary>SecretName is the name of the secret used to sign Certificates issued by this Issuer.</summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary>SelfSigned configures this issuer to 'self sign' certificates using the private key used to create the CertificateRequest object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecSelfSigned
{
    /// <summary>The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set certificate will be issued without CDP. Values are strings.</summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }
}

/// <summary>Reference to a key in a Secret that contains the App Role secret used to authenticate with Vault. The `key` field must be specified and denotes which entry within the Secret resource is used as the app role secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthAppRoleSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthAppRole
{
    /// <summary>Path where the App Role authentication backend is mounted in Vault, e.g: "approle"</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>RoleID configured in the App Role authentication backend when setting up the authentication backend in Vault.</summary>
    [JsonPropertyName("roleId")]
    public string RoleId { get; set; }

    /// <summary>Reference to a key in a Secret that contains the App Role secret used to authenticate with Vault. The `key` field must be specified and denotes which entry within the Secret resource is used as the app role secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1ClusterIssuerSpecVaultAuthAppRoleSecretRef SecretRef { get; set; }
}

/// <summary>The required Secret field containing a Kubernetes ServiceAccount JWT used for authenticating with Vault. Use of 'ambient credentials' is not supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthKubernetesSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A reference to a service account that will be used to request a bound token (also known as "projected token"). Compared to using "secretRef", using this field means that you don't rely on statically bound tokens. To use this field, you must configure an RBAC rule to let cert-manager request a token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthKubernetesServiceAccountRef
{
    /// <summary>TokenAudiences is an optional list of extra audiences to include in the token passed to Vault. The default token consisting of the issuer's namespace and name is always included.</summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>Name of the ServiceAccount used to request a token.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthKubernetes
{
    /// <summary>The Vault mountPath here is the mount path to use when authenticating with Vault. For example, setting a value to `/v1/auth/foo`, will use the path `/v1/auth/foo/login` to authenticate with Vault. If unspecified, the default value "/v1/auth/kubernetes" will be used.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>A required field containing the Vault Role to assume. A Role binds a Kubernetes ServiceAccount with a set of Vault policies.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }

    /// <summary>The required Secret field containing a Kubernetes ServiceAccount JWT used for authenticating with Vault. Use of 'ambient credentials' is not supported.</summary>
    [JsonPropertyName("secretRef")]
    public V1ClusterIssuerSpecVaultAuthKubernetesSecretRef? SecretRef { get; set; }

    /// <summary>A reference to a service account that will be used to request a bound token (also known as "projected token"). Compared to using "secretRef", using this field means that you don't rely on statically bound tokens. To use this field, you must configure an RBAC rule to let cert-manager request a token.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1ClusterIssuerSpecVaultAuthKubernetesServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary>TokenSecretRef authenticates with Vault by presenting a token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuthTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Auth configures how cert-manager authenticates with the Vault server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultAuth
{
    /// <summary>AppRole authenticates with Vault using the App Role auth mechanism, with the role and secret stored in a Kubernetes Secret resource.</summary>
    [JsonPropertyName("appRole")]
    public V1ClusterIssuerSpecVaultAuthAppRole? AppRole { get; set; }

    /// <summary>Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.</summary>
    [JsonPropertyName("kubernetes")]
    public V1ClusterIssuerSpecVaultAuthKubernetes? Kubernetes { get; set; }

    /// <summary>TokenSecretRef authenticates with Vault by presenting a token.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1ClusterIssuerSpecVaultAuthTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>Reference to a Secret containing a bundle of PEM-encoded CAs to use when verifying the certificate chain presented by Vault when using HTTPS. Mutually exclusive with CABundle. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection. If no key for the Secret is specified, cert-manager will default to 'ca.crt'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultCaBundleSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Reference to a Secret containing a PEM-encoded Client Certificate to use when the Vault server requires mTLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultClientCertSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Reference to a Secret containing a PEM-encoded Client Private Key to use when the Vault server requires mTLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVaultClientKeySecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Vault configures this issuer to sign certificates using a HashiCorp Vault PKI backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVault
{
    /// <summary>Auth configures how cert-manager authenticates with the Vault server.</summary>
    [JsonPropertyName("auth")]
    public V1ClusterIssuerSpecVaultAuth Auth { get; set; }

    /// <summary>Base64-encoded bundle of PEM CAs which will be used to validate the certificate chain presented by Vault. Only used if using HTTPS to connect to Vault and ignored for HTTP connections. Mutually exclusive with CABundleSecretRef. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection.</summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Reference to a Secret containing a bundle of PEM-encoded CAs to use when verifying the certificate chain presented by Vault when using HTTPS. Mutually exclusive with CABundle. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection. If no key for the Secret is specified, cert-manager will default to 'ca.crt'.</summary>
    [JsonPropertyName("caBundleSecretRef")]
    public V1ClusterIssuerSpecVaultCaBundleSecretRef? CaBundleSecretRef { get; set; }

    /// <summary>Reference to a Secret containing a PEM-encoded Client Certificate to use when the Vault server requires mTLS.</summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1ClusterIssuerSpecVaultClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>Reference to a Secret containing a PEM-encoded Client Private Key to use when the Vault server requires mTLS.</summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1ClusterIssuerSpecVaultClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>Name of the vault namespace. Namespaces is a set of features within Vault Enterprise that allows Vault environments to support Secure Multi-tenancy. e.g: "ns1" More about namespaces can be found here https://www.vaultproject.io/docs/enterprise/namespaces</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Path is the mount path of the Vault PKI backend's `sign` endpoint, e.g: "my_pki_mount/sign/my-role-name".</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Server is the connection address for the Vault server, e.g: "https://vault.example.com:8200".</summary>
    [JsonPropertyName("server")]
    public string Server { get; set; }
}

/// <summary>APITokenSecretRef is a secret key selector for the Venafi Cloud API token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVenafiCloudApiTokenSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVenafiCloud
{
    /// <summary>APITokenSecretRef is a secret key selector for the Venafi Cloud API token.</summary>
    [JsonPropertyName("apiTokenSecretRef")]
    public V1ClusterIssuerSpecVenafiCloudApiTokenSecretRef ApiTokenSecretRef { get; set; }

    /// <summary>URL is the base URL for Venafi Cloud. Defaults to "https://api.venafi.cloud/v1".</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>CredentialsRef is a reference to a Secret containing the username and password for the TPP server. The secret must contain two keys, 'username' and 'password'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVenafiTppCredentialsRef
{
    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVenafiTpp
{
    /// <summary>Base64-encoded bundle of PEM CAs which will be used to validate the certificate chain presented by the TPP server. Only used if using HTTPS; ignored for HTTP. If undefined, the certificate bundle in the cert-manager controller container is used to validate the chain.</summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>CredentialsRef is a reference to a Secret containing the username and password for the TPP server. The secret must contain two keys, 'username' and 'password'.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1ClusterIssuerSpecVenafiTppCredentialsRef CredentialsRef { get; set; }

    /// <summary>URL is the base URL for the vedsdk endpoint of the Venafi TPP instance, for example: "https://tpp.example.com/vedsdk".</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Venafi configures this issuer to sign certificates using a Venafi TPP or Venafi Cloud policy zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpecVenafi
{
    /// <summary>Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.</summary>
    [JsonPropertyName("cloud")]
    public V1ClusterIssuerSpecVenafiCloud? Cloud { get; set; }

    /// <summary>TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.</summary>
    [JsonPropertyName("tpp")]
    public V1ClusterIssuerSpecVenafiTpp? Tpp { get; set; }

    /// <summary>Zone is the Venafi Policy Zone to use for this issuer. All requests made to the Venafi platform will be restricted by the named zone policy. This field is required.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary>Desired state of the ClusterIssuer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerSpec
{
    /// <summary>ACME configures this issuer to communicate with a RFC8555 (ACME) server to obtain signed x509 certificates.</summary>
    [JsonPropertyName("acme")]
    public V1ClusterIssuerSpecAcme? Acme { get; set; }

    /// <summary>CA configures this issuer to sign certificates using a signing CA keypair stored in a Secret resource. This is used to build internal PKIs that are managed by cert-manager.</summary>
    [JsonPropertyName("ca")]
    public V1ClusterIssuerSpecCa? Ca { get; set; }

    /// <summary>SelfSigned configures this issuer to 'self sign' certificates using the private key used to create the CertificateRequest object.</summary>
    [JsonPropertyName("selfSigned")]
    public V1ClusterIssuerSpecSelfSigned? SelfSigned { get; set; }

    /// <summary>Vault configures this issuer to sign certificates using a HashiCorp Vault PKI backend.</summary>
    [JsonPropertyName("vault")]
    public V1ClusterIssuerSpecVault? Vault { get; set; }

    /// <summary>Venafi configures this issuer to sign certificates using a Venafi TPP or Venafi Cloud policy zone.</summary>
    [JsonPropertyName("venafi")]
    public V1ClusterIssuerSpecVenafi? Venafi { get; set; }
}

/// <summary>ACME specific status options. This field should only be set if the Issuer is configured to use an ACME server to issue certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerStatusAcme
{
    /// <summary>LastPrivateKeyHash is a hash of the private key associated with the latest registered ACME account, in order to track changes made to registered account associated with the Issuer</summary>
    [JsonPropertyName("lastPrivateKeyHash")]
    public string? LastPrivateKeyHash { get; set; }

    /// <summary>LastRegisteredEmail is the email associated with the latest registered ACME account, in order to track changes made to registered account associated with the  Issuer</summary>
    [JsonPropertyName("lastRegisteredEmail")]
    public string? LastRegisteredEmail { get; set; }

    /// <summary>URI is the unique account identifier, which can also be used to retrieve account details from the CA</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1ClusterIssuerStatusConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

/// <summary>IssuerCondition contains condition information for an Issuer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerStatusConditions
{
    /// <summary>LastTransitionTime is the timestamp corresponding to the last status change of this condition.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message is a human readable description of the details of the last transition, complementing reason.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>If set, this represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the Issuer.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason is a brief machine readable explanation for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ClusterIssuerStatusConditionsStatusEnum>))]
    public V1ClusterIssuerStatusConditionsStatusEnum Status { get; set; }

    /// <summary>Type of the condition, known values are (`Ready`).</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status of the ClusterIssuer. This is set and managed automatically.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterIssuerStatus
{
    /// <summary>ACME specific status options. This field should only be set if the Issuer is configured to use an ACME server to issue certificates.</summary>
    [JsonPropertyName("acme")]
    public V1ClusterIssuerStatusAcme? Acme { get; set; }

    /// <summary>List of status conditions to indicate the status of a CertificateRequest. Known condition types are `Ready`.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ClusterIssuerStatusConditions>? Conditions { get; set; }
}

/// <summary>A ClusterIssuer represents a certificate issuing authority which can be referenced as part of `issuerRef` fields. It is similar to an Issuer, however it is cluster-scoped and therefore can be referenced by resources that exist in *any* namespace, not just the same namespace as the referent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterIssuer : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterIssuerSpec>, IStatus<V1ClusterIssuerStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterIssuer";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "clusterissuers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Desired state of the ClusterIssuer resource.</summary>
    [JsonPropertyName("spec")]
    public V1ClusterIssuerSpec Spec { get; set; }

    /// <summary>Status of the ClusterIssuer. This is set and managed automatically.</summary>
    [JsonPropertyName("status")]
    public V1ClusterIssuerStatus? Status { get; set; }
}