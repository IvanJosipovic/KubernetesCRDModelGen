using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecForProviderApprovalRulePatchFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecForProviderApprovalRule
{
    /// <summary>Number of days after the release date of each patch matched by the rule the patch is marked as approved in the patch baseline. Valid Range: 0 to 100. Conflicts with approve_until_date.</summary>
    [JsonPropertyName("approveAfterDays")]
    public double? ApproveAfterDays { get; set; }

    /// <summary>Cutoff date for auto approval of released patches. Any patches released on or before this date are installed automatically. Date is formatted as YYYY-MM-DD. Conflicts with approve_after_days</summary>
    [JsonPropertyName("approveUntilDate")]
    public string? ApproveUntilDate { get; set; }

    /// <summary>Compliance level for patches approved by this rule. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, and UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("complianceLevel")]
    public string? ComplianceLevel { get; set; }

    /// <summary>Boolean enabling the application of non-security updates. The default value is false. Valid for Linux instances only.</summary>
    [JsonPropertyName("enableNonSecurity")]
    public bool? EnableNonSecurity { get; set; }

    /// <summary>Patch filter group that defines the criteria for the rule. Up to 5 patch filters can be specified per approval rule using Key/Value pairs. Valid combinations of these Keys and the operating_system value can be found in the SSM DescribePatchProperties API Reference. Valid Values are exact values for the patch property given as the key, or a wildcard *, which matches all values. PATCH_SET defaults to OS if unspecified</summary>
    [JsonPropertyName("patchFilter")]
    public IList<V1beta1PatchBaselineSpecForProviderApprovalRulePatchFilter>? PatchFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecForProviderGlobalFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecForProviderSource
{
    /// <summary>Value of the yum repo configuration. For information about other options available for your yum repository configuration, see the dnf.conf documentation</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Name specified to identify the patch source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specific operating system versions a patch repository applies to, such as "Ubuntu16.04", "AmazonLinux2016.09", "RedhatEnterpriseLinux7.2" or "Suse12.7". For lists of supported product values, see PatchFilter.</summary>
    [JsonPropertyName("products")]
    public IList<string>? Products { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecForProvider
{
    /// <summary>Set of rules used to include patches in the baseline. Up to 10 approval rules can be specified. See approval_rule below.</summary>
    [JsonPropertyName("approvalRule")]
    public IList<V1beta1PatchBaselineSpecForProviderApprovalRule>? ApprovalRule { get; set; }

    /// <summary>List of explicitly approved patches for the baseline. Cannot be specified with approval_rule.</summary>
    [JsonPropertyName("approvedPatches")]
    public IList<string>? ApprovedPatches { get; set; }

    /// <summary>Compliance level for approved patches. This means that if an approved patch is reported as missing, this is the severity of the compliance violation. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("approvedPatchesComplianceLevel")]
    public string? ApprovedPatchesComplianceLevel { get; set; }

    /// <summary>Whether the list of approved patches includes non-security updates that should be applied to the instances. Applies to Linux instances only.</summary>
    [JsonPropertyName("approvedPatchesEnableNonSecurity")]
    public bool? ApprovedPatchesEnableNonSecurity { get; set; }

    /// <summary>Description of the patch baseline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of global filters used to exclude patches from the baseline. Up to 4 global filters can be specified using Key/Value pairs. Valid Keys are PRODUCT, CLASSIFICATION, MSRC_SEVERITY, and PATCH_ID.</summary>
    [JsonPropertyName("globalFilter")]
    public IList<V1beta1PatchBaselineSpecForProviderGlobalFilter>? GlobalFilter { get; set; }

    /// <summary>Name of the patch baseline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operating system the patch baseline applies to. Valid values are ALMA_LINUX, AMAZON_LINUX, AMAZON_LINUX_2, AMAZON_LINUX_2022, AMAZON_LINUX_2023, CENTOS, DEBIAN, MACOS, ORACLE_LINUX, RASPBIAN, REDHAT_ENTERPRISE_LINUX, ROCKY_LINUX, SUSE, UBUNTU, and WINDOWS. The default value is WINDOWS.</summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of rejected patches.</summary>
    [JsonPropertyName("rejectedPatches")]
    public IList<string>? RejectedPatches { get; set; }

    /// <summary>Action for Patch Manager to take on patches included in the rejected_patches list. Valid values are ALLOW_AS_DEPENDENCY and BLOCK.</summary>
    [JsonPropertyName("rejectedPatchesAction")]
    public string? RejectedPatchesAction { get; set; }

    /// <summary>Configuration block with alternate sources for patches. Applies to Linux instances only. See source below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1PatchBaselineSpecForProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecInitProviderApprovalRulePatchFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecInitProviderApprovalRule
{
    /// <summary>Number of days after the release date of each patch matched by the rule the patch is marked as approved in the patch baseline. Valid Range: 0 to 100. Conflicts with approve_until_date.</summary>
    [JsonPropertyName("approveAfterDays")]
    public double? ApproveAfterDays { get; set; }

    /// <summary>Cutoff date for auto approval of released patches. Any patches released on or before this date are installed automatically. Date is formatted as YYYY-MM-DD. Conflicts with approve_after_days</summary>
    [JsonPropertyName("approveUntilDate")]
    public string? ApproveUntilDate { get; set; }

    /// <summary>Compliance level for patches approved by this rule. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, and UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("complianceLevel")]
    public string? ComplianceLevel { get; set; }

    /// <summary>Boolean enabling the application of non-security updates. The default value is false. Valid for Linux instances only.</summary>
    [JsonPropertyName("enableNonSecurity")]
    public bool? EnableNonSecurity { get; set; }

    /// <summary>Patch filter group that defines the criteria for the rule. Up to 5 patch filters can be specified per approval rule using Key/Value pairs. Valid combinations of these Keys and the operating_system value can be found in the SSM DescribePatchProperties API Reference. Valid Values are exact values for the patch property given as the key, or a wildcard *, which matches all values. PATCH_SET defaults to OS if unspecified</summary>
    [JsonPropertyName("patchFilter")]
    public IList<V1beta1PatchBaselineSpecInitProviderApprovalRulePatchFilter>? PatchFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecInitProviderGlobalFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecInitProviderSource
{
    /// <summary>Value of the yum repo configuration. For information about other options available for your yum repository configuration, see the dnf.conf documentation</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Name specified to identify the patch source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specific operating system versions a patch repository applies to, such as "Ubuntu16.04", "AmazonLinux2016.09", "RedhatEnterpriseLinux7.2" or "Suse12.7". For lists of supported product values, see PatchFilter.</summary>
    [JsonPropertyName("products")]
    public IList<string>? Products { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecInitProvider
{
    /// <summary>Set of rules used to include patches in the baseline. Up to 10 approval rules can be specified. See approval_rule below.</summary>
    [JsonPropertyName("approvalRule")]
    public IList<V1beta1PatchBaselineSpecInitProviderApprovalRule>? ApprovalRule { get; set; }

    /// <summary>List of explicitly approved patches for the baseline. Cannot be specified with approval_rule.</summary>
    [JsonPropertyName("approvedPatches")]
    public IList<string>? ApprovedPatches { get; set; }

    /// <summary>Compliance level for approved patches. This means that if an approved patch is reported as missing, this is the severity of the compliance violation. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("approvedPatchesComplianceLevel")]
    public string? ApprovedPatchesComplianceLevel { get; set; }

    /// <summary>Whether the list of approved patches includes non-security updates that should be applied to the instances. Applies to Linux instances only.</summary>
    [JsonPropertyName("approvedPatchesEnableNonSecurity")]
    public bool? ApprovedPatchesEnableNonSecurity { get; set; }

    /// <summary>Description of the patch baseline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of global filters used to exclude patches from the baseline. Up to 4 global filters can be specified using Key/Value pairs. Valid Keys are PRODUCT, CLASSIFICATION, MSRC_SEVERITY, and PATCH_ID.</summary>
    [JsonPropertyName("globalFilter")]
    public IList<V1beta1PatchBaselineSpecInitProviderGlobalFilter>? GlobalFilter { get; set; }

    /// <summary>Name of the patch baseline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operating system the patch baseline applies to. Valid values are ALMA_LINUX, AMAZON_LINUX, AMAZON_LINUX_2, AMAZON_LINUX_2022, AMAZON_LINUX_2023, CENTOS, DEBIAN, MACOS, ORACLE_LINUX, RASPBIAN, REDHAT_ENTERPRISE_LINUX, ROCKY_LINUX, SUSE, UBUNTU, and WINDOWS. The default value is WINDOWS.</summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>List of rejected patches.</summary>
    [JsonPropertyName("rejectedPatches")]
    public IList<string>? RejectedPatches { get; set; }

    /// <summary>Action for Patch Manager to take on patches included in the rejected_patches list. Valid values are ALLOW_AS_DEPENDENCY and BLOCK.</summary>
    [JsonPropertyName("rejectedPatchesAction")]
    public string? RejectedPatchesAction { get; set; }

    /// <summary>Configuration block with alternate sources for patches. Applies to Linux instances only. See source below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1PatchBaselineSpecInitProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PatchBaselineSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PatchBaselineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PatchBaselineSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PatchBaselineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchBaselineSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PatchBaselineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PatchBaselineSpec defines the desired state of PatchBaseline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PatchBaselineSpecDeletionPolicyEnum>))]
    public V1beta1PatchBaselineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PatchBaselineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PatchBaselineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PatchBaselineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PatchBaselineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PatchBaselineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PatchBaselineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusAtProviderApprovalRulePatchFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusAtProviderApprovalRule
{
    /// <summary>Number of days after the release date of each patch matched by the rule the patch is marked as approved in the patch baseline. Valid Range: 0 to 100. Conflicts with approve_until_date.</summary>
    [JsonPropertyName("approveAfterDays")]
    public double? ApproveAfterDays { get; set; }

    /// <summary>Cutoff date for auto approval of released patches. Any patches released on or before this date are installed automatically. Date is formatted as YYYY-MM-DD. Conflicts with approve_after_days</summary>
    [JsonPropertyName("approveUntilDate")]
    public string? ApproveUntilDate { get; set; }

    /// <summary>Compliance level for patches approved by this rule. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, and UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("complianceLevel")]
    public string? ComplianceLevel { get; set; }

    /// <summary>Boolean enabling the application of non-security updates. The default value is false. Valid for Linux instances only.</summary>
    [JsonPropertyName("enableNonSecurity")]
    public bool? EnableNonSecurity { get; set; }

    /// <summary>Patch filter group that defines the criteria for the rule. Up to 5 patch filters can be specified per approval rule using Key/Value pairs. Valid combinations of these Keys and the operating_system value can be found in the SSM DescribePatchProperties API Reference. Valid Values are exact values for the patch property given as the key, or a wildcard *, which matches all values. PATCH_SET defaults to OS if unspecified</summary>
    [JsonPropertyName("patchFilter")]
    public IList<V1beta1PatchBaselineStatusAtProviderApprovalRulePatchFilter>? PatchFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusAtProviderGlobalFilter
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusAtProviderSource
{
    /// <summary>Value of the yum repo configuration. For information about other options available for your yum repository configuration, see the dnf.conf documentation</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Name specified to identify the patch source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specific operating system versions a patch repository applies to, such as "Ubuntu16.04", "AmazonLinux2016.09", "RedhatEnterpriseLinux7.2" or "Suse12.7". For lists of supported product values, see PatchFilter.</summary>
    [JsonPropertyName("products")]
    public IList<string>? Products { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusAtProvider
{
    /// <summary>Set of rules used to include patches in the baseline. Up to 10 approval rules can be specified. See approval_rule below.</summary>
    [JsonPropertyName("approvalRule")]
    public IList<V1beta1PatchBaselineStatusAtProviderApprovalRule>? ApprovalRule { get; set; }

    /// <summary>List of explicitly approved patches for the baseline. Cannot be specified with approval_rule.</summary>
    [JsonPropertyName("approvedPatches")]
    public IList<string>? ApprovedPatches { get; set; }

    /// <summary>Compliance level for approved patches. This means that if an approved patch is reported as missing, this is the severity of the compliance violation. Valid values are CRITICAL, HIGH, MEDIUM, LOW, INFORMATIONAL, UNSPECIFIED. The default value is UNSPECIFIED.</summary>
    [JsonPropertyName("approvedPatchesComplianceLevel")]
    public string? ApprovedPatchesComplianceLevel { get; set; }

    /// <summary>Whether the list of approved patches includes non-security updates that should be applied to the instances. Applies to Linux instances only.</summary>
    [JsonPropertyName("approvedPatchesEnableNonSecurity")]
    public bool? ApprovedPatchesEnableNonSecurity { get; set; }

    /// <summary>ARN of the baseline.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the patch baseline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of global filters used to exclude patches from the baseline. Up to 4 global filters can be specified using Key/Value pairs. Valid Keys are PRODUCT, CLASSIFICATION, MSRC_SEVERITY, and PATCH_ID.</summary>
    [JsonPropertyName("globalFilter")]
    public IList<V1beta1PatchBaselineStatusAtProviderGlobalFilter>? GlobalFilter { get; set; }

    /// <summary>ID of the baseline.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>JSON definition of the baseline.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }

    /// <summary>Name of the patch baseline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operating system the patch baseline applies to. Valid values are ALMA_LINUX, AMAZON_LINUX, AMAZON_LINUX_2, AMAZON_LINUX_2022, AMAZON_LINUX_2023, CENTOS, DEBIAN, MACOS, ORACLE_LINUX, RASPBIAN, REDHAT_ENTERPRISE_LINUX, ROCKY_LINUX, SUSE, UBUNTU, and WINDOWS. The default value is WINDOWS.</summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>List of rejected patches.</summary>
    [JsonPropertyName("rejectedPatches")]
    public IList<string>? RejectedPatches { get; set; }

    /// <summary>Action for Patch Manager to take on patches included in the rejected_patches list. Valid values are ALLOW_AS_DEPENDENCY and BLOCK.</summary>
    [JsonPropertyName("rejectedPatchesAction")]
    public string? RejectedPatchesAction { get; set; }

    /// <summary>Configuration block with alternate sources for patches. Applies to Linux instances only. See source below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1PatchBaselineStatusAtProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatusConditions
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

/// <summary>PatchBaselineStatus defines the observed state of PatchBaseline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchBaselineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PatchBaselineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PatchBaselineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PatchBaseline is the Schema for the PatchBaselines API. Provides an SSM Patch Baseline resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PatchBaseline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PatchBaselineSpec>, IStatus<V1beta1PatchBaselineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PatchBaseline";
    public const string KubeGroup = "ssm.aws.upbound.io";
    public const string KubePluralName = "patchbaselines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PatchBaselineSpec defines the desired state of PatchBaseline</summary>
    [JsonPropertyName("spec")]
    public V1beta1PatchBaselineSpec Spec { get; set; }

    /// <summary>PatchBaselineStatus defines the observed state of PatchBaseline.</summary>
    [JsonPropertyName("status")]
    public V1beta1PatchBaselineStatus? Status { get; set; }
}