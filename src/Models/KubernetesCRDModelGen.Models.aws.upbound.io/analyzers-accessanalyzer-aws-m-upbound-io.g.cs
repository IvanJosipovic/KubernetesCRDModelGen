using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accessanalyzer.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta1AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta1AnalyzerSpecForProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta1AnalyzerSpecForProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecForProvider
{
    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1AnalyzerSpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta1AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta1AnalyzerSpecInitProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta1AnalyzerSpecInitProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecInitProvider
{
    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1AnalyzerSpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpecProviderConfigRef
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
public partial class V1beta1AnalyzerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AnalyzerSpec defines the desired state of Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AnalyzerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AnalyzerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AnalyzerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AnalyzerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta1AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta1AnalyzerStatusAtProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta1AnalyzerStatusAtProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusAtProvider
{
    /// <summary>ARN of the Analyzer.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1AnalyzerStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary>Name of the analyzer.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatusConditions
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

/// <summary>AnalyzerStatus defines the observed state of Analyzer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyzerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AnalyzerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AnalyzerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Analyzer is the Schema for the Analyzers API. Manages an Access Analyzer Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Analyzer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AnalyzerSpec>, IStatus<V1beta1AnalyzerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Analyzer";
    public const string KubeGroup = "accessanalyzer.aws.m.upbound.io";
    public const string KubePluralName = "analyzers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AnalyzerSpec defines the desired state of Analyzer</summary>
    [JsonPropertyName("spec")]
    public V1beta1AnalyzerSpec Spec { get; set; }

    /// <summary>AnalyzerStatus defines the observed state of Analyzer.</summary>
    [JsonPropertyName("status")]
    public V1beta1AnalyzerStatus? Status { get; set; }
}

/// <summary>Analyzer is the Schema for the Analyzers API. Manages an Access Analyzer Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AnalyzerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Analyzer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AnalyzerList";
    public const string KubeGroup = "accessanalyzer.aws.m.upbound.io";
    public const string KubePluralName = "analyzers";
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
    public IList<V1beta1Analyzer> Items { get; set; }
}