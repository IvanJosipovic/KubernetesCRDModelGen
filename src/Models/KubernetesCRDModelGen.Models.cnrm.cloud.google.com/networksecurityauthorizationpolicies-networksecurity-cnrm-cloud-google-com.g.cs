using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>Immutable. The Project that this resource belongs to.</summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Match against key:value pair in http header. Provides a flexible match based on HTTP headers, for potentially advanced use cases.</summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinationsHttpHeaderMatch
{
    /// <summary>Required. The name of the HTTP header to match. For matching against the HTTP request's authority, use a headerMatch with the header name ":authority". For matching a request's method, use the headerName ":method".</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>Required. The value of the header must match the regular expression specified in regexMatch. For regular expression grammar, please see: en.cppreference.com/w/cpp/regex/ecmascript For matching against a port specified in the HTTP request, use a headerMatch with headerName set to Host and a regular expression that satisfies the RFC2616 Host header's port specifier.</summary>
    [JsonPropertyName("regexMatch")]
    public string RegexMatch { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinations
{
    /// <summary>Required. List of host names to match. Matched against HOST header in http requests. Each host can be an exact match, or a prefix match (example, “mydomain.*”) or a suffix match (example, *.myorg.com”) or a presence(any) match “*”.</summary>
    [JsonPropertyName("hosts")]
    public IList<string> Hosts { get; set; }

    /// <summary>Optional. Match against key:value pair in http header. Provides a flexible match based on HTTP headers, for potentially advanced use cases.</summary>
    [JsonPropertyName("httpHeaderMatch")]
    public V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinationsHttpHeaderMatch? HttpHeaderMatch { get; set; }

    /// <summary>Optional. A list of HTTP methods to match. Should not be set for gRPC services.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Required. List of destination ports to match.</summary>
    [JsonPropertyName("ports")]
    public IList<long> Ports { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesSources
{
    /// <summary>Optional. List of CIDR ranges to match based on source IP address. Single IP (e.g., "1.2.3.4") and CIDR (e.g., "1.2.3.0/24") are supported.</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<string>? IpBlocks { get; set; }

    /// <summary>Optional. List of peer identities to match for authorization. Each peer can be an exact match, or a prefix match (example, “namespace/*”) or a suffix match (example, */service-account”) or a presence match “*”.</summary>
    [JsonPropertyName("principals")]
    public IList<string>? Principals { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRules
{
    /// <summary>Optional. List of attributes for the traffic destination. If not set, the action specified in the ‘action’ field will be applied without any rule checks for the destination.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinations>? Destinations { get; set; }

    /// <summary>Optional. List of attributes for the traffic source. If not set, the action specified in the ‘action’ field will be applied without any rule checks for the source.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRulesSources>? Sources { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicySpec
{
    /// <summary>Required. The action to take when a rule match is found. Possible values are "ALLOW" or "DENY". Possible values: ACTION_UNSPECIFIED, ALLOW, DENY</summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1NetworkSecurityAuthorizationPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. List of rules to match. If not set, the action specified in the ‘action’ field will be applied without any additional rule checks.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRules>? Rules { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1NetworkSecurityAuthorizationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkSecurityAuthorizationPolicySpec>, IStatus<V1beta1NetworkSecurityAuthorizationPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkSecurityAuthorizationPolicy";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityauthorizationpolicies";
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
    public V1beta1NetworkSecurityAuthorizationPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkSecurityAuthorizationPolicyStatus? Status { get; set; }
}