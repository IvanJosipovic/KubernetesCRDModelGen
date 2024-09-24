using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecAdmissionWhitelistPatterns
{
    /// <summary>An image name pattern to allowlist, in the form `registry/path/to/image`. This supports a trailing `*` as a wildcard, but this is allowed only in text after the `registry/` part.</summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public string EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRuleRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Default admission rule for a cluster without a per-cluster, per-kubernetes-service-account, or per-istio-service-identity admission rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRule
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public string EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRuleRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public string EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public string EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRulesRequireAttestationsBy
{
    /// <summary>Allowed value: The Google Cloud resource name of a `BinaryAuthorizationAttestor` resource (format: `projects/{{project}}/attestors/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRules
{
    /// <summary>Required. The action when a pod creation is denied by the admission rule. Possible values: ENFORCEMENT_MODE_UNSPECIFIED, ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY</summary>
    [JsonPropertyName("enforcementMode")]
    public string EnforcementMode { get; set; }

    /// <summary>Required. How this admission rule will be evaluated. Possible values: ALWAYS_ALLOW, ALWAYS_DENY, REQUIRE_ATTESTATION</summary>
    [JsonPropertyName("evaluationMode")]
    public string EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRulesRequireAttestationsBy>? RequireAttestationsBy { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpecProjectRef
{
    /// <summary>The project of the resource.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicySpec
{
    /// <summary>Optional. Admission policy allowlisting. A matching admission request will always be permitted. This feature is typically used to exclude Google or third-party infrastructure images from Binary Authorization policies.</summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta1BinaryAuthorizationPolicySpecAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>Optional. Per-cluster admission rules. Cluster spec format: location.clusterId. There can be at most one admission rule per cluster spec. A location is either a compute zone (e.g. us-central1-a) or a region (e.g. us-central1). For clusterId syntax restrictions see https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters.</summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>Required. Default admission rule for a cluster without a per-cluster, per-kubernetes-service-account, or per-istio-service-identity admission rule.</summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public V1beta1BinaryAuthorizationPolicySpecDefaultAdmissionRule DefaultAdmissionRule { get; set; }

    /// <summary>Optional. A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Controls the evaluation of a Google-maintained global admission policy for common system-level images. Images not covered by the global policy will be subject to the project admission policy. This setting has no effect when specified inside a global admission policy. Possible values: GLOBAL_POLICY_EVALUATION_MODE_UNSPECIFIED, ENABLE, DISABLE</summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>Optional. Per-istio-service-identity admission rules. Istio service identity spec format: spiffe:///ns//sa/ or /ns//sa/ e.g. spiffe://example.com/ns/test-ns/sa/default</summary>
    [JsonPropertyName("istioServiceIdentityAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecIstioServiceIdentityAdmissionRules>? IstioServiceIdentityAdmissionRules { get; set; }

    /// <summary>Optional. Per-kubernetes-namespace admission rules. K8s namespace spec format: [a-z.-]+, e.g. 'some-namespace'</summary>
    [JsonPropertyName("kubernetesNamespaceAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecKubernetesNamespaceAdmissionRules>? KubernetesNamespaceAdmissionRules { get; set; }

    /// <summary>Optional. Per-kubernetes-service-account admission rules. Service account spec format: namespace:serviceaccount. e.g. 'test-ns:default'</summary>
    [JsonPropertyName("kubernetesServiceAccountAdmissionRules")]
    public IDictionary<string, V1beta1BinaryAuthorizationPolicySpecKubernetesServiceAccountAdmissionRules>? KubernetesServiceAccountAdmissionRules { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1BinaryAuthorizationPolicySpecProjectRef ProjectRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicyStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BinaryAuthorizationPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BinaryAuthorizationPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. Time when the policy was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BinaryAuthorizationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BinaryAuthorizationPolicySpec>, IStatus<V1beta1BinaryAuthorizationPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BinaryAuthorizationPolicy";
    public const string KubeGroup = "binaryauthorization.cnrm.cloud.google.com";
    public const string KubePluralName = "binaryauthorizationpolicies";
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
    public V1beta1BinaryAuthorizationPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BinaryAuthorizationPolicyStatus? Status { get; set; }
}