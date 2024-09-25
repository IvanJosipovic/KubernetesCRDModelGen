using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecDeletionPolicyEnum
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
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn't NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>If the type is Static, then provide the value to use</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won't be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If the type is Static, then provide the value to use</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1EventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecForProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecForProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public IList<V1beta1EventSubscriptionSpecForProviderAdvancedFilter>? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public IList<V1beta1EventSubscriptionSpecForProviderAzureFunctionEndpoint>? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public IList<V1beta1EventSubscriptionSpecForProviderDeadLetterIdentity>? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public IList<V1beta1EventSubscriptionSpecForProviderDeliveryIdentity>? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1EventSubscriptionSpecForProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1EventSubscriptionSpecForProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1EventSubscriptionSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1EventSubscriptionSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public IList<V1beta1EventSubscriptionSpecForProviderStorageBlobDeadLetterDestination>? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public IList<V1beta1EventSubscriptionSpecForProviderStorageQueueEndpoint>? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public IList<V1beta1EventSubscriptionSpecForProviderSubjectFilter>? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public IList<V1beta1EventSubscriptionSpecForProviderWebhookEndpoint>? WebhookEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn't NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won't be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecInitProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecInitProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAdvancedFilter>? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public IList<V1beta1EventSubscriptionSpecInitProviderAzureFunctionEndpoint>? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public IList<V1beta1EventSubscriptionSpecInitProviderDeadLetterIdentity>? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public IList<V1beta1EventSubscriptionSpecInitProviderDeliveryIdentity>? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1EventSubscriptionSpecInitProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1EventSubscriptionSpecInitProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1EventSubscriptionSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1EventSubscriptionSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public IList<V1beta1EventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination>? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public IList<V1beta1EventSubscriptionSpecInitProviderStorageQueueEndpoint>? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public IList<V1beta1EventSubscriptionSpecInitProviderSubjectFilter>? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public IList<V1beta1EventSubscriptionSpecInitProviderWebhookEndpoint>? WebhookEndpoint { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EventSubscriptionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EventSubscriptionSpec defines the desired state of EventSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSubscriptionSpecDeletionPolicyEnum>))]
    public V1beta1EventSubscriptionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventSubscriptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventSubscriptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventSubscriptionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventSubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EventSubscriptionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventSubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn't NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won't be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>(Computed) The base url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusAtProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAdvancedFilter>? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public IList<V1beta1EventSubscriptionStatusAtProviderAzureFunctionEndpoint>? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public IList<V1beta1EventSubscriptionStatusAtProviderDeadLetterIdentity>? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public IList<V1beta1EventSubscriptionStatusAtProviderDeliveryIdentity>? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1EventSubscriptionStatusAtProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>The ID of the EventGrid Event Subscription.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1EventSubscriptionStatusAtProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public IList<V1beta1EventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination>? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public IList<V1beta1EventSubscriptionStatusAtProviderStorageQueueEndpoint>? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public IList<V1beta1EventSubscriptionStatusAtProviderSubjectFilter>? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public IList<V1beta1EventSubscriptionStatusAtProviderWebhookEndpoint>? WebhookEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatusConditions
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

/// <summary>EventSubscriptionStatus defines the observed state of EventSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSubscriptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventSubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EventSubscription is the Schema for the EventSubscriptions API. Manages an EventGrid Event Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventSubscriptionSpec>, IStatus<V1beta1EventSubscriptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSubscriptionSpec defines the desired state of EventSubscription</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventSubscriptionSpec Spec { get; set; }

    /// <summary>EventSubscriptionStatus defines the observed state of EventSubscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventSubscriptionStatus? Status { get; set; }
}