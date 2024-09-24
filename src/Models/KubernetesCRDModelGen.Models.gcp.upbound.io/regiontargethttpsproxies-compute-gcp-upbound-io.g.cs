using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1RegionTargetHTTPSProxySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionTargetHTTPSProxySpecForProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created target https proxy should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>References to RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesRefs")]
    public IList<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefs>? SslCertificatesRefs { get; set; }

    /// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesSelector")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelector? SslCertificatesSelector { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }

    /// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRef? UrlMapRef { get; set; }

    /// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapSelector")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelector? UrlMapSelector { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecInitProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>References to RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesRefs")]
    public IList<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefs>? SslCertificatesRefs { get; set; }

    /// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesSelector")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelector? SslCertificatesSelector { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }

    /// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRef? UrlMapRef { get; set; }

    /// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapSelector")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelector? UrlMapSelector { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecManagementPoliciesEnum
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

public enum V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RegionTargetHTTPSProxySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegionTargetHTTPSProxySpec defines the desired state of RegionTargetHTTPSProxy</summary>
public partial class V1beta1RegionTargetHTTPSProxySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionTargetHTTPSProxySpecDeletionPolicyEnum>))]
    public V1beta1RegionTargetHTTPSProxySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionTargetHTTPSProxySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionTargetHTTPSProxySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegionTargetHTTPSProxySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegionTargetHTTPSProxySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionTargetHTTPSProxySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionTargetHTTPSProxyStatusAtProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/targetHttpsProxies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("proxyId")]
    public double? ProxyId { get; set; }

    /// <summary>The Region in which the created target https proxy should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RegionTargetHTTPSProxyStatusConditions
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

/// <summary>RegionTargetHTTPSProxyStatus defines the observed state of RegionTargetHTTPSProxy.</summary>
public partial class V1beta1RegionTargetHTTPSProxyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionTargetHTTPSProxyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionTargetHTTPSProxyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RegionTargetHTTPSProxy is the Schema for the RegionTargetHTTPSProxys API. Represents a RegionTargetHttpsProxy resource, which is used by one or more forwarding rules to route incoming HTTPS requests to a URL map.</summary>
public partial class V1beta1RegionTargetHTTPSProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionTargetHTTPSProxySpec>, IStatus<V1beta1RegionTargetHTTPSProxyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionTargetHTTPSProxy";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiontargethttpsproxies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionTargetHTTPSProxySpec defines the desired state of RegionTargetHTTPSProxy</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionTargetHTTPSProxySpec Spec { get; set; }

    /// <summary>RegionTargetHTTPSProxyStatus defines the observed state of RegionTargetHTTPSProxy.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionTargetHTTPSProxyStatus? Status { get; set; }
}