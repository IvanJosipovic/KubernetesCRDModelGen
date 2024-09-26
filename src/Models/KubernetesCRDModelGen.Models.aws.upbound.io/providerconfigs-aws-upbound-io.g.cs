using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aws.upbound.io;
/// <summary>Tag is session tag that can be used to assume an IAM Role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecAssumeRoleChainTags
{
    /// <summary>Name of the tag. Key is a required field</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Value of the tag. Value is a required field</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>AssumeRoleOptions define the options for assuming an IAM Role Fields are similar to the STS AssumeRoleOptions in the AWS SDK</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecAssumeRoleChain
{
    /// <summary>ExternalID is the external ID used when assuming role.</summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Tags is list of session tags that you want to pass. Each session tag consists of a key name and an associated value. For more information about session tags, see Tagging STS Sessions (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html).</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1ProviderConfigSpecAssumeRoleChainTags>? Tags { get; set; }

    /// <summary>TransitiveTagKeys is a list of keys for session tags that you want to set as transitive. If you set a tag key as transitive, the corresponding key and value passes to subsequent sessions in a role chain. For more information, see Chaining Roles with Session Tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining).</summary>
    [JsonPropertyName("transitiveTagKeys")]
    public IList<string>? TransitiveTagKeys { get; set; }
}

/// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsSecretRef
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

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to obtain the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to obtain the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSecretRef
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

/// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfig
{
    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to obtain the web identity token.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to obtain the web identity token.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfigSecretRef? SecretRef { get; set; }

    /// <summary>Source is the source of the web identity token.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsUpboundWebIdentity
{
    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>RoleSessionName is the session name, if you wish to uniquely identify this session.</summary>
    [JsonPropertyName("roleSessionName")]
    public string? RoleSessionName { get; set; }

    /// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
    [JsonPropertyName("tokenConfig")]
    public V1beta1ProviderConfigSpecCredentialsUpboundWebIdentityTokenConfig? TokenConfig { get; set; }
}

/// <summary>Upbound defines the options for authenticating using Upbound as an identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsUpbound
{
    /// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
    [JsonPropertyName("webIdentity")]
    public V1beta1ProviderConfigSpecCredentialsUpboundWebIdentity? WebIdentity { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to obtain the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfigFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to obtain the web identity token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfigSecretRef
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

/// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfig
{
    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to obtain the web identity token.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfigFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to obtain the web identity token.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfigSecretRef? SecretRef { get; set; }

    /// <summary>Source is the source of the web identity token.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsWebIdentity
{
    /// <summary>AssumeRoleARN to assume with provider credentials</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>RoleSessionName is the session name, if you wish to uniquely identify this session.</summary>
    [JsonPropertyName("roleSessionName")]
    public string? RoleSessionName { get; set; }

    /// <summary>TokenConfig is the Web Identity Token config to assume the role.</summary>
    [JsonPropertyName("tokenConfig")]
    public V1beta1ProviderConfigSpecCredentialsWebIdentityTokenConfig? TokenConfig { get; set; }
}

/// <summary>Credentials required to authenticate to this provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentials
{
    /// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("env")]
    public V1beta1ProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }

    /// <summary>Upbound defines the options for authenticating using Upbound as an identity provider.</summary>
    [JsonPropertyName("upbound")]
    public V1beta1ProviderConfigSpecCredentialsUpbound? Upbound { get; set; }

    /// <summary>WebIdentity defines the options for assuming an IAM role with a Web Identity.</summary>
    [JsonPropertyName("webIdentity")]
    public V1beta1ProviderConfigSpecCredentialsWebIdentity? WebIdentity { get; set; }
}

/// <summary>Dynamic lets you configure the behavior of endpoint URL resolver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecEndpointUrlDynamic
{
    /// <summary>Host is the address of the main host that the resolver will use to prepend protocol, service and region configurations. For example, the final URL for EC2 in us-east-1 looks like https://ec2.us-east-1.amazonaws.com You would need to use "amazonaws.com" as Host and "https" as protocol to have the resolver construct it.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Protocol is the HTTP protocol that will be used in the URL. Currently, only http and https are supported.</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary>URL lets you configure the endpoint URL to be used in SDK calls.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecEndpointUrl
{
    /// <summary>Dynamic lets you configure the behavior of endpoint URL resolver.</summary>
    [JsonPropertyName("dynamic")]
    public V1beta1ProviderConfigSpecEndpointUrlDynamic? Dynamic { get; set; }

    /// <summary>Static is the full URL you'd like the AWS SDK to use. Recommended for using tools like localstack where a single host is exposed for all services and regions.</summary>
    [JsonPropertyName("static")]
    public string? Static { get; set; }

    /// <summary>You can provide a static URL that will be used regardless of the service and region by choosing Static type. Alternatively, you can provide configuration for dynamically resolving the URL with the config you provide once you set the type as Dynamic.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Endpoint is where you can override the default endpoint configuration of AWS calls made by the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecEndpoint
{
    /// <summary>Specifies if the endpoint's hostname can be modified by the SDK's API client.   If the hostname is mutable the SDK API clients may modify any part of the hostname based on the requirements of the API, (e.g. adding, or removing content in the hostname). Such as, Amazon S3 API client prefixing "bucketname" to the hostname, or changing the hostname service name component from "s3." to "s3-accesspoint.dualstack." for the dualstack endpoint of an S3 Accesspoint resource.   Care should be taken when providing a custom endpoint for an API. If the endpoint hostname is mutable, and the client cannot modify the endpoint correctly, the operation call will most likely fail, or have undefined behavior.   If hostname is immutable, the SDK API clients will not modify the hostname of the URL. This may cause the API client not to function correctly if the API requires the operation specific hostname values to be used by the client.   This flag does not modify the API client's behavior if this endpoint will be used instead of Endpoint Discovery, or if the endpoint will be used to perform Endpoint Discovery. That behavior is configured via the API Client's Options. Note that this is effective only for resources that use AWS SDK v2.</summary>
    [JsonPropertyName("hostnameImmutable")]
    public bool? HostnameImmutable { get; set; }

    /// <summary>The AWS partition the endpoint belongs to.</summary>
    [JsonPropertyName("partitionId")]
    public string? PartitionId { get; set; }

    /// <summary>Specifies the list of services you want endpoint to be used for</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>The signing method that should be used for signing the requests to the endpoint.</summary>
    [JsonPropertyName("signingMethod")]
    public string? SigningMethod { get; set; }

    /// <summary>The service name that should be used for signing the requests to the endpoint.</summary>
    [JsonPropertyName("signingName")]
    public string? SigningName { get; set; }

    /// <summary>The region that should be used for signing the request to the endpoint. For IAM, which doesn't have any region, us-east-1 is used to sign the requests, which is the only signing region of IAM.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>The source of the Endpoint. By default, this will be ServiceMetadata. When providing a custom endpoint, you should set the source as Custom. If source is not provided when providing a custom endpoint, the SDK may not perform required host mutations correctly. Source should be used along with HostnameImmutable property as per the usage requirement. Note that this is effective only for resources that use AWS SDK v2.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>URL lets you configure the endpoint URL to be used in SDK calls.</summary>
    [JsonPropertyName("url")]
    public V1beta1ProviderConfigSpecEndpointUrl Url { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpec
{
    /// <summary>AssumeRoleChain defines the options for assuming an IAM role</summary>
    [JsonPropertyName("assumeRoleChain")]
    public IList<V1beta1ProviderConfigSpecAssumeRoleChain>? AssumeRoleChain { get; set; }

    /// <summary>Credentials required to authenticate to this provider.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1ProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>Endpoint is where you can override the default endpoint configuration of AWS calls made by the provider.</summary>
    [JsonPropertyName("endpoint")]
    public V1beta1ProviderConfigSpecEndpoint? Endpoint { get; set; }

    /// <summary>Whether to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY.</summary>
    [JsonPropertyName("s3_use_path_style")]
    public bool? S3UsePathStyle { get; set; }

    /// <summary>Whether to skip credentials validation via the STS API. This can be useful for testing and for AWS API implementations that do not have STS available.</summary>
    [JsonPropertyName("skip_credentials_validation")]
    public bool? SkipCredentialsValidation { get; set; }

    /// <summary>Whether to skip the AWS Metadata API check Useful for AWS API implementations that do not have a metadata API endpoint.</summary>
    [JsonPropertyName("skip_metadata_api_check")]
    public bool? SkipMetadataApiCheck { get; set; }

    /// <summary>Whether to skip validation of provided region name. Useful for AWS-like implementations that use their own region names or to bypass the validation for regions that aren't publicly available yet.</summary>
    [JsonPropertyName("skip_region_validation")]
    public bool? SkipRegionValidation { get; set; }

    /// <summary>Whether to skip requesting the account ID. Useful for AWS API implementations that do not have the IAM, STS API, or metadata API</summary>
    [JsonPropertyName("skip_requesting_account_id")]
    public bool? SkipRequestingAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ProviderConfig configures the AWS provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProviderConfigSpec>, IStatus<V1beta1ProviderConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProviderConfig";
    public const string KubeGroup = "aws.upbound.io";
    public const string KubePluralName = "providerconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProviderConfigStatus? Status { get; set; }
}