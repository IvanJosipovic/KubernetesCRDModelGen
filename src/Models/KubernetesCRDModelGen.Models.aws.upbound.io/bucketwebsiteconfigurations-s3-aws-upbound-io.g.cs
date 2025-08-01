using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderIndexDocument
{
    /// <summary>Suffix that is appended to a request that is for a directory on the website endpoint. For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html. The suffix must not be empty and must not include a slash character.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRuleCondition>? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRuleRedirect>? Redirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecForProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketWebsiteConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketWebsiteConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderErrorDocument>? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderIndexDocument>? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket's website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderRedirectAllRequestsTo>? RedirectAllRequestsTo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1BucketWebsiteConfigurationSpecForProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>JSON array containing routing rules describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values ("") as seen in the example above.</summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderIndexDocument
{
    /// <summary>Suffix that is appended to a request that is for a directory on the website endpoint. For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html. The suffix must not be empty and must not include a slash character.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRuleCondition>? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRuleRedirect>? Redirect { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecInitProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketWebsiteConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketWebsiteConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderErrorDocument>? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderIndexDocument>? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket's website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderRedirectAllRequestsTo>? RedirectAllRequestsTo { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1BucketWebsiteConfigurationSpecInitProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>JSON array containing routing rules describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values ("") as seen in the example above.</summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1BucketWebsiteConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketWebsiteConfigurationSpec defines the desired state of BucketWebsiteConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketWebsiteConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketWebsiteConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketWebsiteConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketWebsiteConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketWebsiteConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderIndexDocument
{
    /// <summary>Suffix that is appended to a request that is for a directory on the website endpoint. For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html. The suffix must not be empty and must not include a slash character.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRuleCondition>? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRuleRedirect>? Redirect { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusAtProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderErrorDocument>? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>The bucket or bucket and expected_bucket_owner separated by a comma (,) if the latter is provided.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderIndexDocument>? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket's website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderRedirectAllRequestsTo>? RedirectAllRequestsTo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1BucketWebsiteConfigurationStatusAtProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>JSON array containing routing rules describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values ("") as seen in the example above.</summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }

    /// <summary>Domain of the website endpoint. This is used to create Route 53 alias records.</summary>
    [JsonPropertyName("websiteDomain")]
    public string? WebsiteDomain { get; set; }

    /// <summary>Website endpoint.</summary>
    [JsonPropertyName("websiteEndpoint")]
    public string? WebsiteEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatusConditions
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

/// <summary>BucketWebsiteConfigurationStatus defines the observed state of BucketWebsiteConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketWebsiteConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketWebsiteConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketWebsiteConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketWebsiteConfiguration is the Schema for the BucketWebsiteConfigurations API. Provides an S3 bucket website configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketWebsiteConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketWebsiteConfigurationSpec>, IStatus<V1beta1BucketWebsiteConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketWebsiteConfiguration";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketwebsiteconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketWebsiteConfigurationSpec defines the desired state of BucketWebsiteConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketWebsiteConfigurationSpec Spec { get; set; }

    /// <summary>BucketWebsiteConfigurationStatus defines the observed state of BucketWebsiteConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketWebsiteConfigurationStatus? Status { get; set; }
}

/// <summary>BucketWebsiteConfiguration is the Schema for the BucketWebsiteConfigurations API. Provides an S3 bucket website configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketWebsiteConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BucketWebsiteConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketWebsiteConfigurationList";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketwebsiteconfigurations";
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
    public IList<V1beta1BucketWebsiteConfiguration> Items { get; set; }
}