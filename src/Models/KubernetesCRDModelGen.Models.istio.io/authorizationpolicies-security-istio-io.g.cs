using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.istio.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AuthorizationPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AuthorizationPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AuthorizationPolicyList";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "authorizationpolicies";
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
    public IList<V1beta1AuthorizationPolicy> Items { get; set; }
}

/// <summary>Specifies detailed configuration of the CUSTOM action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecProvider
{
    /// <summary>Specifies the name of the extension provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Source specifies the source of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRulesFromSource
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<string>? IpBlocks { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notIpBlocks")]
    public IList<string>? NotIpBlocks { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notNamespaces")]
    public IList<string>? NotNamespaces { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notPrincipals")]
    public IList<string>? NotPrincipals { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notRemoteIpBlocks")]
    public IList<string>? NotRemoteIpBlocks { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notRequestPrincipals")]
    public IList<string>? NotRequestPrincipals { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notServiceAccounts")]
    public IList<string>? NotServiceAccounts { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("principals")]
    public IList<string>? Principals { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("remoteIpBlocks")]
    public IList<string>? RemoteIpBlocks { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("requestPrincipals")]
    public IList<string>? RequestPrincipals { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("serviceAccounts")]
    public IList<string>? ServiceAccounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRulesFrom
{
    /// <summary>Source specifies the source of a request.</summary>
    [JsonPropertyName("source")]
    public V1beta1AuthorizationPolicySpecRulesFromSource? Source { get; set; }
}

/// <summary>Operation specifies the operation of a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRulesToOperation
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notHosts")]
    public IList<string>? NotHosts { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notMethods")]
    public IList<string>? NotMethods { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notPaths")]
    public IList<string>? NotPaths { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notPorts")]
    public IList<string>? NotPorts { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRulesTo
{
    /// <summary>Operation specifies the operation of a request.</summary>
    [JsonPropertyName("operation")]
    public V1beta1AuthorizationPolicySpecRulesToOperation? Operation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRulesWhen
{
    /// <summary>The name of an Istio attribute.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("notValues")]
    public IList<string>? NotValues { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecRules
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("from")]
    public IList<V1beta1AuthorizationPolicySpecRulesFrom>? From { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("to")]
    public IList<V1beta1AuthorizationPolicySpecRulesTo>? To { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("when")]
    public IList<V1beta1AuthorizationPolicySpecRulesWhen>? When { get; set; }
}

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecTargetRef
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpecTargetRefs
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for access control on workloads. See more details at: https://istio.io/docs/reference/config/security/authorization-policy.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizationPolicySpec
{
    /// <summary>Optional.  Valid Options: ALLOW, DENY, AUDIT, CUSTOM</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Specifies detailed configuration of the CUSTOM action.</summary>
    [JsonPropertyName("provider")]
    public V1beta1AuthorizationPolicySpecProvider? Provider { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1AuthorizationPolicySpecRules>? Rules { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1beta1AuthorizationPolicySpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRef")]
    public V1beta1AuthorizationPolicySpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1beta1AuthorizationPolicySpecTargetRefs>? TargetRefs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AuthorizationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AuthorizationPolicySpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AuthorizationPolicy";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "authorizationpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration for access control on workloads. See more details at: https://istio.io/docs/reference/config/security/authorization-policy.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1AuthorizationPolicySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}