using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafregional.aws.upbound.io;
public enum V1beta1SizeConstraintSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
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
public partial class V1beta1SizeConstraintSetSpecForProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1SizeConstraintSetSpecForProviderSizeConstraintsFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary></summary>
public partial class V1beta1SizeConstraintSetSpecForProvider
{
    /// <summary>The name or description of the Size Constraint Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetSpecForProviderSizeConstraints>? SizeConstraints { get; set; }
}

/// <summary></summary>
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
public partial class V1beta1SizeConstraintSetSpecInitProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1SizeConstraintSetSpecInitProviderSizeConstraintsFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SizeConstraintSetSpecInitProvider
{
    /// <summary>The name or description of the Size Constraint Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetSpecInitProviderSizeConstraints>? SizeConstraints { get; set; }
}

public enum V1beta1SizeConstraintSetSpecManagementPoliciesEnum
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

public enum V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SizeConstraintSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SizeConstraintSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SizeConstraintSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SizeConstraintSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SizeConstraintSetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SizeConstraintSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SizeConstraintSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SizeConstraintSetSpec defines the desired state of SizeConstraintSet</summary>
public partial class V1beta1SizeConstraintSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SizeConstraintSetSpecDeletionPolicyEnum>))]
    public V1beta1SizeConstraintSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SizeConstraintSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SizeConstraintSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SizeConstraintSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SizeConstraintSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SizeConstraintSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SizeConstraintSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
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
public partial class V1beta1SizeConstraintSetStatusAtProviderSizeConstraints
{
    /// <summary>The type of comparison you want to perform. e.g., EQ, NE, LT, GT. See docs for all supported values.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Specifies where in a web request to look for the size constraint.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1SizeConstraintSetStatusAtProviderSizeConstraintsFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The size in bytes that you want to compare against the size of the specified field_to_match. Valid values are between 0 - 21474836480 bytes (0 - 20 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on field_to_match before inspecting a request for a match. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values. Note: if you choose BODY as type, you must choose NONE because CloudFront forwards only the first 8192 bytes for inspection.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

/// <summary></summary>
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

    /// <summary>Specifies the parts of web requests that you want to inspect the size of.</summary>
    [JsonPropertyName("sizeConstraints")]
    public IList<V1beta1SizeConstraintSetStatusAtProviderSizeConstraints>? SizeConstraints { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SizeConstraintSet is the Schema for the SizeConstraintSets API. Provides an AWS WAF Regional Size Constraint Set resource for use with ALB.</summary>
public partial class V1beta1SizeConstraintSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SizeConstraintSetSpec>, IStatus<V1beta1SizeConstraintSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SizeConstraintSet";
    public const string KubeGroup = "wafregional.aws.upbound.io";
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