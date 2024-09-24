using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.gcp.upbound.io;
public enum V1beta1PolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1PolicySpecForProviderAdmissionWhitelistPatterns
{
    /// <summary>An image name pattern to whitelist, in the form registry/path/to/image. This supports a trailing * as a wildcard, but this is allowed only in text after the registry/ part.</summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

public partial class V1beta1PolicySpecForProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicySpecForProviderDefaultAdmissionRule
{
    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicySpecForProvider
{
    /// <summary>A whitelist of image patterns to exclude from admission rules. If an image's name matches a whitelist pattern, the image's admission requests will always be permitted regardless of your admission rules. Structure is documented below.</summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta1PolicySpecForProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>Per-cluster admission rules. An admission rule specifies either that all container images used in a pod creation request must be attested to by one or more attestors, that all pod creations will be allowed, or that all pod creations will be denied. There can be at most one admission rule per cluster spec.</summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta1PolicySpecForProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>Default admission rule for a cluster without a per-cluster admission rule. Structure is documented below.</summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public IList<V1beta1PolicySpecForProviderDefaultAdmissionRule>? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Controls the evaluation of a Google-maintained global admission policy for common system-level images. Images not covered by the global policy will be subject to the project admission policy. Possible values are: ENABLE, DISABLE.</summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public partial class V1beta1PolicySpecInitProviderAdmissionWhitelistPatterns
{
    /// <summary>An image name pattern to whitelist, in the form registry/path/to/image. This supports a trailing * as a wildcard, but this is allowed only in text after the registry/ part.</summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

public partial class V1beta1PolicySpecInitProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicySpecInitProviderDefaultAdmissionRule
{
    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicySpecInitProvider
{
    /// <summary>A whitelist of image patterns to exclude from admission rules. If an image's name matches a whitelist pattern, the image's admission requests will always be permitted regardless of your admission rules. Structure is documented below.</summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta1PolicySpecInitProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>Per-cluster admission rules. An admission rule specifies either that all container images used in a pod creation request must be attested to by one or more attestors, that all pod creations will be allowed, or that all pod creations will be denied. There can be at most one admission rule per cluster spec.</summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta1PolicySpecInitProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>Default admission rule for a cluster without a per-cluster admission rule. Structure is documented below.</summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public IList<V1beta1PolicySpecInitProviderDefaultAdmissionRule>? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Controls the evaluation of a Google-maintained global admission policy for common system-level images. Images not covered by the global policy will be subject to the project admission policy. Possible values are: ENABLE, DISABLE.</summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1PolicySpecManagementPoliciesEnum
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

public enum V1beta1PolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PolicySpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecDeletionPolicyEnum>))]
    public V1beta1PolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PolicyStatusAtProviderAdmissionWhitelistPatterns
{
    /// <summary>An image name pattern to whitelist, in the form registry/path/to/image. This supports a trailing * as a wildcard, but this is allowed only in text after the registry/ part.</summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

public partial class V1beta1PolicyStatusAtProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicyStatusAtProviderDefaultAdmissionRule
{
    /// <summary>The action when a pod creation is denied by the admission rule. Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.</summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>How this admission rule will be evaluated. Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>The resource names of the attestors that must attest to a container image. If the attestor is in a different project from the policy, it should be specified in the format projects/*/attestors/*. Each attestor must exist before a policy can reference it. To add an attestor to a policy the principal issuing the policy change request must be able to read the attestor resource. Note: this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must be empty.</summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

public partial class V1beta1PolicyStatusAtProvider
{
    /// <summary>A whitelist of image patterns to exclude from admission rules. If an image's name matches a whitelist pattern, the image's admission requests will always be permitted regardless of your admission rules. Structure is documented below.</summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta1PolicyStatusAtProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>Per-cluster admission rules. An admission rule specifies either that all container images used in a pod creation request must be attested to by one or more attestors, that all pod creations will be allowed, or that all pod creations will be denied. There can be at most one admission rule per cluster spec.</summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta1PolicyStatusAtProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>Default admission rule for a cluster without a per-cluster admission rule. Structure is documented below.</summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public IList<V1beta1PolicyStatusAtProviderDefaultAdmissionRule>? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Controls the evaluation of a Google-maintained global admission policy for common system-level images. Images not covered by the global policy will be subject to the project admission policy. Possible values are: ENABLE, DISABLE.</summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public partial class V1beta1PolicyStatusConditions
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

public partial class V1beta1PolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySpec>, IStatus<V1beta1PolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicyStatus? Status { get; set; }
}