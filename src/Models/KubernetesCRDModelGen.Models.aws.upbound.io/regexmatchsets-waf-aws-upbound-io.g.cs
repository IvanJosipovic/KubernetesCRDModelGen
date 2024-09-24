using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.waf.aws.upbound.io;
public enum V1beta1RegexMatchSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTupleFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RegexMatchSetSpecForProviderRegexMatchTuple
{
    /// <summary>The part of a web request that you want to search, such as a specified header or a query string.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1RegexMatchSetSpecForProviderRegexMatchTupleFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The ID of a Regex Pattern Set.</summary>
    [JsonPropertyName("regexPatternSetId")]
    public string? RegexPatternSetId { get; set; }

    /// <summary>Reference to a RegexPatternSet in waf to populate regexPatternSetId.</summary>
    [JsonPropertyName("regexPatternSetIdRef")]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdRef? RegexPatternSetIdRef { get; set; }

    /// <summary>Selector for a RegexPatternSet in waf to populate regexPatternSetId.</summary>
    [JsonPropertyName("regexPatternSetIdSelector")]
    public V1beta1RegexMatchSetSpecForProviderRegexMatchTupleRegexPatternSetIdSelector? RegexPatternSetIdSelector { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

public partial class V1beta1RegexMatchSetSpecForProvider
{
    /// <summary>The name or description of the Regex Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The regular expression pattern that you want AWS WAF to search for in web requests, the location in requests that you want AWS WAF to search, and other settings. See below.</summary>
    [JsonPropertyName("regexMatchTuple")]
    public IList<V1beta1RegexMatchSetSpecForProviderRegexMatchTuple>? RegexMatchTuple { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RegexMatchSetSpecInitProviderRegexMatchTuple
{
    /// <summary>The part of a web request that you want to search, such as a specified header or a query string.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The ID of a Regex Pattern Set.</summary>
    [JsonPropertyName("regexPatternSetId")]
    public string? RegexPatternSetId { get; set; }

    /// <summary>Reference to a RegexPatternSet in waf to populate regexPatternSetId.</summary>
    [JsonPropertyName("regexPatternSetIdRef")]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdRef? RegexPatternSetIdRef { get; set; }

    /// <summary>Selector for a RegexPatternSet in waf to populate regexPatternSetId.</summary>
    [JsonPropertyName("regexPatternSetIdSelector")]
    public V1beta1RegexMatchSetSpecInitProviderRegexMatchTupleRegexPatternSetIdSelector? RegexPatternSetIdSelector { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

public partial class V1beta1RegexMatchSetSpecInitProvider
{
    /// <summary>The name or description of the Regex Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The regular expression pattern that you want AWS WAF to search for in web requests, the location in requests that you want AWS WAF to search, and other settings. See below.</summary>
    [JsonPropertyName("regexMatchTuple")]
    public IList<V1beta1RegexMatchSetSpecInitProviderRegexMatchTuple>? RegexMatchTuple { get; set; }
}

public enum V1beta1RegexMatchSetSpecManagementPoliciesEnum
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

public enum V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1RegexMatchSetSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1RegexMatchSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1RegexMatchSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1RegexMatchSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegexMatchSetSpecDeletionPolicyEnum>))]
    public V1beta1RegexMatchSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegexMatchSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegexMatchSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegexMatchSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegexMatchSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegexMatchSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegexMatchSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1RegexMatchSetStatusAtProviderRegexMatchTupleFieldToMatch
{
    /// <summary>When type is HEADER, enter the name of the header that you want to search, e.g., User-Agent or Referer. If type is any other value, omit this field.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The part of the web request that you want AWS WAF to search for a specified string. e.g., HEADER, METHOD or BODY. See docs for all supported values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RegexMatchSetStatusAtProviderRegexMatchTuple
{
    /// <summary>The part of a web request that you want to search, such as a specified header or a query string.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1RegexMatchSetStatusAtProviderRegexMatchTupleFieldToMatch>? FieldToMatch { get; set; }

    /// <summary>The ID of a Regex Pattern Set.</summary>
    [JsonPropertyName("regexPatternSetId")]
    public string? RegexPatternSetId { get; set; }

    /// <summary>Text transformations used to eliminate unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. e.g., CMD_LINE, HTML_ENTITY_DECODE or NONE. See docs for all supported values.</summary>
    [JsonPropertyName("textTransformation")]
    public string? TextTransformation { get; set; }
}

public partial class V1beta1RegexMatchSetStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN)</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the WAF Regex Match Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name or description of the Regex Match Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The regular expression pattern that you want AWS WAF to search for in web requests, the location in requests that you want AWS WAF to search, and other settings. See below.</summary>
    [JsonPropertyName("regexMatchTuple")]
    public IList<V1beta1RegexMatchSetStatusAtProviderRegexMatchTuple>? RegexMatchTuple { get; set; }
}

public partial class V1beta1RegexMatchSetStatusConditions
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

public partial class V1beta1RegexMatchSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegexMatchSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegexMatchSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegexMatchSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegexMatchSetSpec>, IStatus<V1beta1RegexMatchSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegexMatchSet";
    public const string KubeGroup = "waf.aws.upbound.io";
    public const string KubePluralName = "regexmatchsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegexMatchSetSpec defines the desired state of RegexMatchSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegexMatchSetSpec Spec { get; set; }

    /// <summary>RegexMatchSetStatus defines the observed state of RegexMatchSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegexMatchSetStatus? Status { get; set; }
}