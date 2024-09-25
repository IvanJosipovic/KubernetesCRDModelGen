using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.istio.io;
/// <summary>Defines the mTLS mode used for peer authentication.  Valid Options: DISABLE, PERMISSIVE, STRICT</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PeerAuthenticationSpecMtlsModeEnum
{
    [EnumMember(Value = "UNSET"), JsonStringEnumMemberName("UNSET")]
    /// <summary>UNSET</summary>
    UNSET,
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "PERMISSIVE"), JsonStringEnumMemberName("PERMISSIVE")]
    /// <summary>PERMISSIVE</summary>
    PERMISSIVE,
    [EnumMember(Value = "STRICT"), JsonStringEnumMemberName("STRICT")]
    /// <summary>STRICT</summary>
    STRICT
}

/// <summary>Mutual TLS settings for workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PeerAuthenticationSpecMtls
{
    /// <summary>Defines the mTLS mode used for peer authentication.  Valid Options: DISABLE, PERMISSIVE, STRICT</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PeerAuthenticationSpecMtlsModeEnum>))]
    public V1beta1PeerAuthenticationSpecMtlsModeEnum? Mode { get; set; }
}

/// <summary>Defines the mTLS mode used for peer authentication.  Valid Options: DISABLE, PERMISSIVE, STRICT</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PeerAuthenticationSpecPortLevelMtlsModeEnum
{
    [EnumMember(Value = "UNSET"), JsonStringEnumMemberName("UNSET")]
    /// <summary>UNSET</summary>
    UNSET,
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    /// <summary>DISABLE</summary>
    DISABLE,
    [EnumMember(Value = "PERMISSIVE"), JsonStringEnumMemberName("PERMISSIVE")]
    /// <summary>PERMISSIVE</summary>
    PERMISSIVE,
    [EnumMember(Value = "STRICT"), JsonStringEnumMemberName("STRICT")]
    /// <summary>STRICT</summary>
    STRICT
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PeerAuthenticationSpecPortLevelMtls
{
    /// <summary>Defines the mTLS mode used for peer authentication.  Valid Options: DISABLE, PERMISSIVE, STRICT</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PeerAuthenticationSpecPortLevelMtlsModeEnum>))]
    public V1beta1PeerAuthenticationSpecPortLevelMtlsModeEnum? Mode { get; set; }
}

/// <summary>The selector determines the workloads to apply the PeerAuthentication on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PeerAuthenticationSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Peer authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/peer_authentication.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PeerAuthenticationSpec
{
    /// <summary>Mutual TLS settings for workload.</summary>
    [JsonPropertyName("mtls")]
    public V1beta1PeerAuthenticationSpecMtls? Mtls { get; set; }

    /// <summary>Port specific mutual TLS settings.</summary>
    [JsonPropertyName("portLevelMtls")]
    public IDictionary<string, V1beta1PeerAuthenticationSpecPortLevelMtls>? PortLevelMtls { get; set; }

    /// <summary>The selector determines the workloads to apply the PeerAuthentication on.</summary>
    [JsonPropertyName("selector")]
    public V1beta1PeerAuthenticationSpecSelector? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PeerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PeerAuthenticationSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PeerAuthentication";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "peerauthentications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Peer authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/peer_authentication.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1PeerAuthenticationSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}