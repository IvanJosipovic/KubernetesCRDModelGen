using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.azure.m.upbound.io;
/// <summary>SecurityCenterAssessmentPolicy is the Schema for the SecurityCenterAssessmentPolicys API. Manages the Security Center Assessment Metadata for Azure Security Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityCenterAssessmentPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SecurityCenterAssessmentPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityCenterAssessmentPolicyList";
    public const string KubeGroup = "security.azure.m.upbound.io";
    public const string KubePluralName = "securitycenterassessmentpolicies";
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
    public IList<V1beta1SecurityCenterAssessmentPolicy> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicySpecForProvider
{
    /// <summary>A list of the categories of resource that is at risk when the Security Center Assessment is unhealthy. Possible values are Unknown, Compute, Data, IdentityAndAccess, IoT and Networking.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Security Center Assessment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly display name of the Security Center Assessment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The implementation effort which is used to remediate the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("implementationEffort")]
    public string? ImplementationEffort { get; set; }

    /// <summary>The description which is used to mitigate the security issue.</summary>
    [JsonPropertyName("remediationDescription")]
    public string? RemediationDescription { get; set; }

    /// <summary>The severity level of the Security Center Assessment. Possible values are Low, Medium and High. Defaults to Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>A list of the threat impacts for the Security Center Assessment. Possible values are AccountBreach, DataExfiltration, DataSpillage, DenialOfService, ElevationOfPrivilege, MaliciousInsider, MissingCoverage and ThreatResistance.</summary>
    [JsonPropertyName("threats")]
    public IList<string>? Threats { get; set; }

    /// <summary>The user impact of the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("userImpact")]
    public string? UserImpact { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicySpecInitProvider
{
    /// <summary>A list of the categories of resource that is at risk when the Security Center Assessment is unhealthy. Possible values are Unknown, Compute, Data, IdentityAndAccess, IoT and Networking.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Security Center Assessment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly display name of the Security Center Assessment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The implementation effort which is used to remediate the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("implementationEffort")]
    public string? ImplementationEffort { get; set; }

    /// <summary>The description which is used to mitigate the security issue.</summary>
    [JsonPropertyName("remediationDescription")]
    public string? RemediationDescription { get; set; }

    /// <summary>The severity level of the Security Center Assessment. Possible values are Low, Medium and High. Defaults to Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>A list of the threat impacts for the Security Center Assessment. Possible values are AccountBreach, DataExfiltration, DataSpillage, DenialOfService, ElevationOfPrivilege, MaliciousInsider, MissingCoverage and ThreatResistance.</summary>
    [JsonPropertyName("threats")]
    public IList<string>? Threats { get; set; }

    /// <summary>The user impact of the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("userImpact")]
    public string? UserImpact { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecurityCenterAssessmentPolicySpec defines the desired state of SecurityCenterAssessmentPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecurityCenterAssessmentPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecurityCenterAssessmentPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityCenterAssessmentPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityCenterAssessmentPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicyStatusAtProvider
{
    /// <summary>A list of the categories of resource that is at risk when the Security Center Assessment is unhealthy. Possible values are Unknown, Compute, Data, IdentityAndAccess, IoT and Networking.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Security Center Assessment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly display name of the Security Center Assessment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Security Center Assessment Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The implementation effort which is used to remediate the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("implementationEffort")]
    public string? ImplementationEffort { get; set; }

    /// <summary>The GUID as the name of the Security Center Assessment Policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The description which is used to mitigate the security issue.</summary>
    [JsonPropertyName("remediationDescription")]
    public string? RemediationDescription { get; set; }

    /// <summary>The severity level of the Security Center Assessment. Possible values are Low, Medium and High. Defaults to Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>A list of the threat impacts for the Security Center Assessment. Possible values are AccountBreach, DataExfiltration, DataSpillage, DenialOfService, ElevationOfPrivilege, MaliciousInsider, MissingCoverage and ThreatResistance.</summary>
    [JsonPropertyName("threats")]
    public IList<string>? Threats { get; set; }

    /// <summary>The user impact of the Security Center Assessment. Possible values are Low, Moderate and High.</summary>
    [JsonPropertyName("userImpact")]
    public string? UserImpact { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicyStatusConditions
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

/// <summary>SecurityCenterAssessmentPolicyStatus defines the observed state of SecurityCenterAssessmentPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityCenterAssessmentPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SecurityCenterAssessmentPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecurityCenterAssessmentPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecurityCenterAssessmentPolicy is the Schema for the SecurityCenterAssessmentPolicys API. Manages the Security Center Assessment Metadata for Azure Security Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityCenterAssessmentPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityCenterAssessmentPolicySpec>, IStatus<V1beta1SecurityCenterAssessmentPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityCenterAssessmentPolicy";
    public const string KubeGroup = "security.azure.m.upbound.io";
    public const string KubePluralName = "securitycenterassessmentpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityCenterAssessmentPolicySpec defines the desired state of SecurityCenterAssessmentPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecurityCenterAssessmentPolicySpec Spec { get; set; }

    /// <summary>SecurityCenterAssessmentPolicyStatus defines the observed state of SecurityCenterAssessmentPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecurityCenterAssessmentPolicyStatus? Status { get; set; }
}