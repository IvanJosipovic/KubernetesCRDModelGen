using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DNSResponsePolicyRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DNSResponsePolicyRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DNSResponsePolicyRuleList";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnsresponsepolicyrules";
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
    public IList<V1alpha1DNSResponsePolicyRule> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleSpecLocalDataLocalDatas
{
    /// <summary>For example, www.example.com.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>As defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1).</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>Number of seconds that this ResourceRecordSet can be cached by resolvers.</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>One of valid DNS resource types. Possible values: ["A", "AAAA", "CAA", "CNAME", "DNSKEY", "DS", "HTTPS", "IPSECVPNKEY", "MX", "NAPTR", "NS", "PTR", "SOA", "SPF", "SRV", "SSHFP", "SVCB", "TLSA", "TXT"].</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Answer this query directly with DNS data. These ResourceRecordSets override any other DNS behavior for the matched name; in particular they override private zones, the public internet, and GCP internal DNS. No SOA nor NS types are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleSpecLocalData
{
    /// <summary>All resource record sets for this selector, one per resource record type. The name must match the dns_name.</summary>
    [JsonPropertyName("localDatas")]
    public IList<V1alpha1DNSResponsePolicyRuleSpecLocalDataLocalDatas> LocalDatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleSpec
{
    /// <summary>Answer this query with a behavior rather than DNS data. Acceptable values are 'behaviorUnspecified', and 'bypassResponsePolicy'.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.</summary>
    [JsonPropertyName("dnsName")]
    public string DnsName { get; set; }

    /// <summary>Answer this query directly with DNS data. These ResourceRecordSets override any other DNS behavior for the matched name; in particular they override private zones, the public internet, and GCP internal DNS. No SOA nor NS types are allowed.</summary>
    [JsonPropertyName("localData")]
    public V1alpha1DNSResponsePolicyRuleSpecLocalData? LocalData { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DNSResponsePolicyRuleSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The ruleName of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Identifies the response policy addressed by this request.</summary>
    [JsonPropertyName("responsePolicy")]
    public string ResponsePolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DNSResponsePolicyRuleStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DNSResponsePolicyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DNSResponsePolicyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DNSResponsePolicyRuleSpec>, IStatus<V1alpha1DNSResponsePolicyRuleStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DNSResponsePolicyRule";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnsresponsepolicyrules";
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
    public V1alpha1DNSResponsePolicyRuleSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DNSResponsePolicyRuleStatus? Status { get; set; }
}
#nullable disable
