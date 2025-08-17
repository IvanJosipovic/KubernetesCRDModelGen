using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kendra.aws.upbound.io;
#nullable enable
/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataSource>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSourceList";
    public const string KubeGroup = "kendra.aws.upbound.io";
    public const string KubePluralName = "datasources";
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
    public IList<V1beta1DataSource> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicy
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
/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicy
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
/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationAccessControlListConfiguration>? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration>? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy
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
/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy
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
/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that's required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy
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
/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy
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
/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration>? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration>? SiteMapsConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don't match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don't match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrls>? Urls { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationS3Configuration>? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationTemplateConfiguration>? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderConfigurationWebCrawlerConfiguration>? WebCrawlerConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, 'Department' could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, 'Finance' could be the target value for the target attribute key 'Department'. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue>? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition>? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget>? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration>? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration>? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderIndexIdRefPolicy
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
/// <summary>Reference to a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderIndexIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderIndexIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderIndexIdSelectorPolicy
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
/// <summary>Selector for a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderIndexIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderIndexIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderRoleArnRefPolicy
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
/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderRoleArnSelectorPolicy
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
/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProvider
{
    /// <summary>A block with the configuration information to connect to your Data Source repository. You can't specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1DataSourceSpecForProviderConfiguration>? Configuration { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderCustomDocumentEnrichmentConfiguration>? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>Reference to a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdRef")]
    public V1beta1DataSourceSpecForProviderIndexIdRef? IndexIdRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdSelector")]
    public V1beta1DataSourceSpecForProviderIndexIdSelector? IndexIdSelector { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can't specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DataSourceSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DataSourceSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don't set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicy
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
/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicy
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
/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationAccessControlListConfiguration>? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration>? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy
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
/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy
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
/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that's required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy
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
/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy
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
/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration>? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration>? SiteMapsConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don't match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don't match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrls>? Urls { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationS3Configuration>? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationTemplateConfiguration>? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderConfigurationWebCrawlerConfiguration>? WebCrawlerConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, 'Department' could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, 'Finance' could be the target value for the target attribute key 'Department'. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue>? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition>? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget>? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration>? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration>? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderIndexIdRefPolicy
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
/// <summary>Reference to a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderIndexIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderIndexIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderIndexIdSelectorPolicy
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
/// <summary>Selector for a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderIndexIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderIndexIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderRoleArnRefPolicy
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
/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderRoleArnSelectorPolicy
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
/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProvider
{
    /// <summary>A block with the configuration information to connect to your Data Source repository. You can't specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1DataSourceSpecInitProviderConfiguration>? Configuration { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderCustomDocumentEnrichmentConfiguration>? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>Reference to a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdRef")]
    public V1beta1DataSourceSpecInitProviderIndexIdRef? IndexIdRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdSelector")]
    public V1beta1DataSourceSpecInitProviderIndexIdSelector? IndexIdSelector { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can't specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DataSourceSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DataSourceSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don't set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataSourceSpec defines the desired state of DataSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataSourceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataSourceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataSourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataSourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationS3ConfigurationAccessControlListConfiguration>? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration>? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that's required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is "a.example.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration>? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration>? SiteMapsConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don't match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don't match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn't included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrls>? Urls { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationS3Configuration>? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationTemplateConfiguration>? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderConfigurationWebCrawlerConfiguration>? WebCrawlerConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, 'Department' could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, 'Finance' could be the target value for the target attribute key 'Department'. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue>? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition>? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget>? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value 'financial' for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue>? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition>? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration>? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration>? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProvider
{
    /// <summary>ARN of the Data Source.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A block with the configuration information to connect to your Data Source repository. You can't specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1DataSourceStatusAtProviderConfiguration>? Configuration { get; set; }

    /// <summary>The Unix time stamp of when the Data Source was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderCustomDocumentEnrichmentConfiguration>? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>The unique identifiers of the Data Source.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>When the Status field value is FAILED, contains a description of the error that caused the Data Source to fail.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>The unique identifiers of the Data Source and index separated by a slash (/).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can't specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don't set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The current status of the Data Source. When the status is ACTIVE the Data Source is ready to use. When the status is FAILED, the error_message field contains the reason that the Data Source failed.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The Unix time stamp of when the Data Source was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusConditions
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
/// <summary>DataSourceStatus defines the observed state of DataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataSourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataSourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataSourceSpec>, IStatus<V1beta1DataSourceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSource";
    public const string KubeGroup = "kendra.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSourceSpec defines the desired state of DataSource</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataSourceSpec Spec { get; set; }

    /// <summary>DataSourceStatus defines the observed state of DataSource.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataSourceStatus? Status { get; set; }
}
#nullable disable
