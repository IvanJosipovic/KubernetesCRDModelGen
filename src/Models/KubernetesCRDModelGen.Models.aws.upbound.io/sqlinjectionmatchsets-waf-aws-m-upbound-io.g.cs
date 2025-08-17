using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.waf.aws.m.upbound.io;
#nullable enable
/// <summary>SQLInjectionMatchSet is the Schema for the SQLInjectionMatchSets API. Provides a AWS WAF SQL Injection Match Set resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLInjectionMatchSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLInjectionMatchSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLInjectionMatchSetList";
    public const string KubeGroup = "waf.aws.m.upbound.io";
    public const string KubePluralName = "sqlinjectionmatchsets";
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
    public IList<V1beta1SQLInjectionMatchSet> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecForProviderSqlInjectionMatchTuplesFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecForProviderSqlInjectionMatchTuples
{
    /// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SQLInjectionMatchSetSpecForProviderSqlInjectionMatchTuplesFieldToMatch? FieldToMatch { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecForProvider
{
    /// <summary>The name or description of the SQL Injection Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parts of web requests that you want AWS WAF to inspect for malicious SQL code and, if you want AWS WAF to inspect a header, the name of the header.</summary>
    [JsonPropertyName("sqlInjectionMatchTuples")]
    public IList<V1beta1SQLInjectionMatchSetSpecForProviderSqlInjectionMatchTuples>? SqlInjectionMatchTuples { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecInitProviderSqlInjectionMatchTuplesFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecInitProviderSqlInjectionMatchTuples
{
    /// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SQLInjectionMatchSetSpecInitProviderSqlInjectionMatchTuplesFieldToMatch? FieldToMatch { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecInitProvider
{
    /// <summary>The name or description of the SQL Injection Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parts of web requests that you want AWS WAF to inspect for malicious SQL code and, if you want AWS WAF to inspect a header, the name of the header.</summary>
    [JsonPropertyName("sqlInjectionMatchTuples")]
    public IList<V1beta1SQLInjectionMatchSetSpecInitProviderSqlInjectionMatchTuples>? SqlInjectionMatchTuples { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SQLInjectionMatchSetSpec defines the desired state of SQLInjectionMatchSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SQLInjectionMatchSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SQLInjectionMatchSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLInjectionMatchSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLInjectionMatchSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetStatusAtProviderSqlInjectionMatchTuplesFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetStatusAtProviderSqlInjectionMatchTuples
{
    /// <summary>Specifies where in a web request to look for snippets of malicious SQL code.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SQLInjectionMatchSetStatusAtProviderSqlInjectionMatchTuplesFieldToMatch? FieldToMatch { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the SQL injection match set.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the WAF SQL Injection Match Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name or description of the SQL Injection Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parts of web requests that you want AWS WAF to inspect for malicious SQL code and, if you want AWS WAF to inspect a header, the name of the header.</summary>
    [JsonPropertyName("sqlInjectionMatchTuples")]
    public IList<V1beta1SQLInjectionMatchSetStatusAtProviderSqlInjectionMatchTuples>? SqlInjectionMatchTuples { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetStatusConditions
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
/// <summary>SQLInjectionMatchSetStatus defines the observed state of SQLInjectionMatchSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInjectionMatchSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SQLInjectionMatchSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLInjectionMatchSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SQLInjectionMatchSet is the Schema for the SQLInjectionMatchSets API. Provides a AWS WAF SQL Injection Match Set resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLInjectionMatchSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLInjectionMatchSetSpec>, IStatus<V1beta1SQLInjectionMatchSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLInjectionMatchSet";
    public const string KubeGroup = "waf.aws.m.upbound.io";
    public const string KubePluralName = "sqlinjectionmatchsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLInjectionMatchSetSpec defines the desired state of SQLInjectionMatchSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLInjectionMatchSetSpec Spec { get; set; }

    /// <summary>SQLInjectionMatchSetStatus defines the observed state of SQLInjectionMatchSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLInjectionMatchSetStatus? Status { get; set; }
}
#nullable disable
