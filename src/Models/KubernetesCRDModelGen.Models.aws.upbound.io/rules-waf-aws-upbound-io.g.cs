using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.waf.aws.upbound.io;
public enum V1beta1RuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecForProviderPredicatesDataIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolutionEnum>))]
    public V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolveEnum>))]
    public V1beta1RuleSpecForProviderPredicatesDataIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecForProviderPredicatesDataIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecForProviderPredicatesDataIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolutionEnum>))]
    public V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolveEnum>))]
    public V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecForProviderPredicatesDataIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecForProviderPredicatesDataIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RuleSpecForProviderPredicates
{
    /// <summary>A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.</summary>
    [JsonPropertyName("dataId")]
    public string? DataId { get; set; }

    /// <summary>Reference to a IPSet in waf to populate dataId.</summary>
    [JsonPropertyName("dataIdRef")]
    public V1beta1RuleSpecForProviderPredicatesDataIdRef? DataIdRef { get; set; }

    /// <summary>Selector for a IPSet in waf to populate dataId.</summary>
    [JsonPropertyName("dataIdSelector")]
    public V1beta1RuleSpecForProviderPredicatesDataIdSelector? DataIdSelector { get; set; }

    /// <summary>Set this to false if you want to allow, block, or count requests based on the settings in the specified waf_byte_match_set, waf_ipset, aws_waf_size_constraint_set, aws_waf_sql_injection_match_set or aws_waf_xss_match_set. For example, if an IPSet includes the IP address 192.0.2.44, AWS WAF will allow or block requests based on that IP address. If set to true, AWS WAF will allow, block, or count requests based on all IP addresses except 192.0.2.44.</summary>
    [JsonPropertyName("negated")]
    public bool? Negated { get; set; }

    /// <summary>The type of predicate in a rule. Valid values: ByteMatch, GeoMatch, IPMatch, RegexMatch, SizeConstraint, SqlInjectionMatch, or XssMatch.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RuleSpecForProvider
{
    /// <summary>The name or description for the Amazon CloudWatch metric of this rule. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The objects to include in a rule (documented below).</summary>
    [JsonPropertyName("predicates")]
    public IList<V1beta1RuleSpecForProviderPredicates>? Predicates { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolutionEnum>))]
    public V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolveEnum>))]
    public V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecInitProviderPredicatesDataIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecInitProviderPredicatesDataIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolutionEnum>))]
    public V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolveEnum>))]
    public V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecInitProviderPredicatesDataIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecInitProviderPredicatesDataIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RuleSpecInitProviderPredicates
{
    /// <summary>A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.</summary>
    [JsonPropertyName("dataId")]
    public string? DataId { get; set; }

    /// <summary>Reference to a IPSet in waf to populate dataId.</summary>
    [JsonPropertyName("dataIdRef")]
    public V1beta1RuleSpecInitProviderPredicatesDataIdRef? DataIdRef { get; set; }

    /// <summary>Selector for a IPSet in waf to populate dataId.</summary>
    [JsonPropertyName("dataIdSelector")]
    public V1beta1RuleSpecInitProviderPredicatesDataIdSelector? DataIdSelector { get; set; }

    /// <summary>Set this to false if you want to allow, block, or count requests based on the settings in the specified waf_byte_match_set, waf_ipset, aws_waf_size_constraint_set, aws_waf_sql_injection_match_set or aws_waf_xss_match_set. For example, if an IPSet includes the IP address 192.0.2.44, AWS WAF will allow or block requests based on that IP address. If set to true, AWS WAF will allow, block, or count requests based on all IP addresses except 192.0.2.44.</summary>
    [JsonPropertyName("negated")]
    public bool? Negated { get; set; }

    /// <summary>The type of predicate in a rule. Valid values: ByteMatch, GeoMatch, IPMatch, RegexMatch, SizeConstraint, SqlInjectionMatch, or XssMatch.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RuleSpecInitProvider
{
    /// <summary>The name or description for the Amazon CloudWatch metric of this rule. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The objects to include in a rule (documented below).</summary>
    [JsonPropertyName("predicates")]
    public IList<V1beta1RuleSpecInitProviderPredicates>? Predicates { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1RuleSpecManagementPoliciesEnum
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

public enum V1beta1RuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1RuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1RuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1RuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1RuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleSpecDeletionPolicyEnum>))]
    public V1beta1RuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1RuleStatusAtProviderPredicates
{
    /// <summary>A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.</summary>
    [JsonPropertyName("dataId")]
    public string? DataId { get; set; }

    /// <summary>Set this to false if you want to allow, block, or count requests based on the settings in the specified waf_byte_match_set, waf_ipset, aws_waf_size_constraint_set, aws_waf_sql_injection_match_set or aws_waf_xss_match_set. For example, if an IPSet includes the IP address 192.0.2.44, AWS WAF will allow or block requests based on that IP address. If set to true, AWS WAF will allow, block, or count requests based on all IP addresses except 192.0.2.44.</summary>
    [JsonPropertyName("negated")]
    public bool? Negated { get; set; }

    /// <summary>The type of predicate in a rule. Valid values: ByteMatch, GeoMatch, IPMatch, RegexMatch, SizeConstraint, SqlInjectionMatch, or XssMatch.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RuleStatusAtProvider
{
    /// <summary>The ARN of the WAF rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the WAF rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this rule. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The objects to include in a rule (documented below).</summary>
    [JsonPropertyName("predicates")]
    public IList<V1beta1RuleStatusAtProviderPredicates>? Predicates { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

public partial class V1beta1RuleStatusConditions
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

public partial class V1beta1RuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RuleSpec>, IStatus<V1beta1RuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "waf.aws.upbound.io";
    public const string KubePluralName = "rules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleSpec defines the desired state of Rule</summary>
    [JsonPropertyName("spec")]
    public V1beta1RuleSpec Spec { get; set; }

    /// <summary>RuleStatus defines the observed state of Rule.</summary>
    [JsonPropertyName("status")]
    public V1beta1RuleStatus? Status { get; set; }
}