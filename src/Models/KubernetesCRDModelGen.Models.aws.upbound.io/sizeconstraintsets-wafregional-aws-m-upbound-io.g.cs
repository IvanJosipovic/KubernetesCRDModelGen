using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafregional.aws.m.upbound.io;
/// <summary>SizeConstraintSet is the Schema for the SizeConstraintSets API. Provides an AWS WAF Regional Size Constraint Set resource for use with ALB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SizeConstraintSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SizeConstraintSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SizeConstraintSetList";
    public const string KubeGroup = "wafregional.aws.m.upbound.io";
    public const string KubePluralName = "sizeconstraintsets";
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
    public IList<V1beta1SizeConstraintSet> Items { get; set; }
}

/// <summary>Specifies where in a web request to look for the size constraint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecForProviderSizeConstraintsFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecForProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SizeConstraintSetSpecForProviderSizeConstraintsFieldToMatch? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecForProvider
{
    /// <summary>The name or description of the Size Constraint Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetSpecForProviderSizeConstraints>? SizeConstraints { get; set; }
}

/// <summary>Specifies where in a web request to look for the size constraint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecInitProviderSizeConstraintsFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecInitProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SizeConstraintSetSpecInitProviderSizeConstraintsFieldToMatch? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecInitProvider
{
    /// <summary>The name or description of the Size Constraint Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetSpecInitProviderSizeConstraints>? SizeConstraints { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpecProviderConfigRef
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
public partial class V1beta1SizeConstraintSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SizeConstraintSetSpec defines the desired state of SizeConstraintSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SizeConstraintSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SizeConstraintSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SizeConstraintSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SizeConstraintSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies where in a web request to look for the size constraint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetStatusAtProviderSizeConstraintsFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetStatusAtProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public V1beta1SizeConstraintSetStatusAtProviderSizeConstraintsFieldToMatch? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the WAF Size Constraint Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name or description of the Size Constraint Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetStatusAtProviderSizeConstraints>? SizeConstraints { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetStatusConditions
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

/// <summary>SizeConstraintSetStatus defines the observed state of SizeConstraintSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SizeConstraintSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SizeConstraintSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SizeConstraintSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SizeConstraintSet is the Schema for the SizeConstraintSets API. Provides an AWS WAF Regional Size Constraint Set resource for use with ALB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SizeConstraintSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SizeConstraintSetSpec>, IStatus<V1beta1SizeConstraintSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SizeConstraintSet";
    public const string KubeGroup = "wafregional.aws.m.upbound.io";
    public const string KubePluralName = "sizeconstraintsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SizeConstraintSetSpec defines the desired state of SizeConstraintSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1SizeConstraintSetSpec Spec { get; set; }

    /// <summary>SizeConstraintSetStatus defines the observed state of SizeConstraintSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1SizeConstraintSetStatus? Status { get; set; }
}