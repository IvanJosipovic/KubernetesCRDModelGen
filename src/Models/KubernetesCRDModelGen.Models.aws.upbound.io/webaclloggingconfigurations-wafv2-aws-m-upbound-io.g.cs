using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.aws.m.upbound.io;
#nullable enable
/// <summary>WebACLLoggingConfiguration is the Schema for the WebACLLoggingConfigurations API. Create a resource for WAFv2 Web ACL Logging Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLLoggingConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebACLLoggingConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLLoggingConfigurationList";
    public const string KubeGroup = "wafv2.aws.m.upbound.io";
    public const string KubePluralName = "webaclloggingconfigurations";
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
    public IList<V1beta1WebACLLoggingConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of DeliveryStream in firehose to populate logDestinationConfigs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterConditionActionCondition
{
    /// <summary>Action setting that a log record must contain in order to meet the condition. Valid values for action are ALLOW, BLOCK, COUNT, CAPTCHA, CHALLENGE and EXCLUDED_AS_COUNT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterConditionLabelNameCondition
{
    /// <summary>Name of the label that a log record must contain in order to meet the condition. It must be a fully qualified label name, which includes a prefix, optional namespaces, and the label name itself. The prefix identifies the rule group or web ACL context of the rule that added the label.</summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterCondition
{
    /// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
    [JsonPropertyName("actionCondition")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterConditionActionCondition? ActionCondition { get; set; }

    /// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
    [JsonPropertyName("labelNameCondition")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilter
{
    /// <summary>Parameter that determines how to handle logs that meet the conditions and requirements of the filter. The valid values for behavior are KEEP or DROP.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Match condition(s) for the filter. See Condition below for more details.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilterCondition>? Condition { get; set; }

    /// <summary>Logic to apply to the filtering conditions. You can specify that a log must match all conditions or at least one condition in order to satisfy the filter. Valid values for requirement are MEETS_ALL or MEETS_ANY.</summary>
    [JsonPropertyName("requirement")]
    public string? Requirement { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilter
{
    /// <summary>Default handling for logs that don't match any of the specified filtering conditions. Valid values for default_behavior are KEEP or DROP.</summary>
    [JsonPropertyName("defaultBehavior")]
    public string? DefaultBehavior { get; set; }

    /// <summary>Filter(s) that you want to apply to the logs. See Filter below for more details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilterFilter>? Filter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsMethod
{
}
#nullable disable

#nullable enable
/// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsQueryString
{
}
#nullable disable

#nullable enable
/// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsSingleHeader
{
    /// <summary>Name of the query header to redact. This setting must be provided in lowercase characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsUriPath
{
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFields
{
    /// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
    [JsonPropertyName("method")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsMethod? Method { get; set; }

    /// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
    [JsonPropertyName("queryString")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsQueryString? QueryString { get; set; }

    /// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
    [JsonPropertyName("singleHeader")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsSingleHeader? SingleHeader { get; set; }

    /// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
    [JsonPropertyName("uriPath")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFieldsUriPath? UriPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a WebACL in wafv2 to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a WebACL in wafv2 to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecForProvider
{
    /// <summary>Configuration block that allows you to associate Amazon Kinesis Data Firehose, Cloudwatch Log log group, or S3 bucket Amazon Resource Names (ARNs) with the web ACL. Note: data firehose, log group, or bucket name must be prefixed with aws-waf-logs-, e.g. aws-waf-logs-example-firehose, aws-waf-logs-example-log-group, or aws-waf-logs-example-bucket. AWS Kinesis Firehose Delivery Stream ARNs</summary>
    [JsonPropertyName("logDestinationConfigs")]
    public IList<string>? LogDestinationConfigs { get; set; }

    /// <summary>References to DeliveryStream in firehose to populate logDestinationConfigs.</summary>
    [JsonPropertyName("logDestinationConfigsRefs")]
    public IList<V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsRefs>? LogDestinationConfigsRefs { get; set; }

    /// <summary>Selector for a list of DeliveryStream in firehose to populate logDestinationConfigs.</summary>
    [JsonPropertyName("logDestinationConfigsSelector")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLogDestinationConfigsSelector? LogDestinationConfigsSelector { get; set; }

    /// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
    [JsonPropertyName("loggingFilter")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderLoggingFilter? LoggingFilter { get; set; }

    /// <summary>Configuration for parts of the request that you want to keep out of the logs. Up to 100 redacted_fields blocks are supported. See Redacted Fields below for more details. Parts of the request to exclude from logs</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLLoggingConfigurationSpecForProviderRedactedFields>? RedactedFields { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the web ACL that you want to associate with log_destination_configs. AWS WebACL ARN</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a WebACL in wafv2 to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a WebACL in wafv2 to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1WebACLLoggingConfigurationSpecForProviderResourceArnSelector? ResourceArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of DeliveryStream in firehose to populate logDestinationConfigs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterConditionActionCondition
{
    /// <summary>Action setting that a log record must contain in order to meet the condition. Valid values for action are ALLOW, BLOCK, COUNT, CAPTCHA, CHALLENGE and EXCLUDED_AS_COUNT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterConditionLabelNameCondition
{
    /// <summary>Name of the label that a log record must contain in order to meet the condition. It must be a fully qualified label name, which includes a prefix, optional namespaces, and the label name itself. The prefix identifies the rule group or web ACL context of the rule that added the label.</summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterCondition
{
    /// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
    [JsonPropertyName("actionCondition")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterConditionActionCondition? ActionCondition { get; set; }

    /// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
    [JsonPropertyName("labelNameCondition")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilter
{
    /// <summary>Parameter that determines how to handle logs that meet the conditions and requirements of the filter. The valid values for behavior are KEEP or DROP.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Match condition(s) for the filter. See Condition below for more details.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilterCondition>? Condition { get; set; }

    /// <summary>Logic to apply to the filtering conditions. You can specify that a log must match all conditions or at least one condition in order to satisfy the filter. Valid values for requirement are MEETS_ALL or MEETS_ANY.</summary>
    [JsonPropertyName("requirement")]
    public string? Requirement { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilter
{
    /// <summary>Default handling for logs that don't match any of the specified filtering conditions. Valid values for default_behavior are KEEP or DROP.</summary>
    [JsonPropertyName("defaultBehavior")]
    public string? DefaultBehavior { get; set; }

    /// <summary>Filter(s) that you want to apply to the logs. See Filter below for more details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilterFilter>? Filter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsMethod
{
}
#nullable disable

#nullable enable
/// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsQueryString
{
}
#nullable disable

#nullable enable
/// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsSingleHeader
{
    /// <summary>Name of the query header to redact. This setting must be provided in lowercase characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsUriPath
{
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFields
{
    /// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
    [JsonPropertyName("method")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsMethod? Method { get; set; }

    /// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
    [JsonPropertyName("queryString")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsQueryString? QueryString { get; set; }

    /// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
    [JsonPropertyName("singleHeader")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsSingleHeader? SingleHeader { get; set; }

    /// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
    [JsonPropertyName("uriPath")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFieldsUriPath? UriPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecInitProvider
{
    /// <summary>Configuration block that allows you to associate Amazon Kinesis Data Firehose, Cloudwatch Log log group, or S3 bucket Amazon Resource Names (ARNs) with the web ACL. Note: data firehose, log group, or bucket name must be prefixed with aws-waf-logs-, e.g. aws-waf-logs-example-firehose, aws-waf-logs-example-log-group, or aws-waf-logs-example-bucket. AWS Kinesis Firehose Delivery Stream ARNs</summary>
    [JsonPropertyName("logDestinationConfigs")]
    public IList<string>? LogDestinationConfigs { get; set; }

    /// <summary>References to DeliveryStream in firehose to populate logDestinationConfigs.</summary>
    [JsonPropertyName("logDestinationConfigsRefs")]
    public IList<V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsRefs>? LogDestinationConfigsRefs { get; set; }

    /// <summary>Selector for a list of DeliveryStream in firehose to populate logDestinationConfigs.</summary>
    [JsonPropertyName("logDestinationConfigsSelector")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLogDestinationConfigsSelector? LogDestinationConfigsSelector { get; set; }

    /// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
    [JsonPropertyName("loggingFilter")]
    public V1beta1WebACLLoggingConfigurationSpecInitProviderLoggingFilter? LoggingFilter { get; set; }

    /// <summary>Configuration for parts of the request that you want to keep out of the logs. Up to 100 redacted_fields blocks are supported. See Redacted Fields below for more details. Parts of the request to exclude from logs</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLLoggingConfigurationSpecInitProviderRedactedFields>? RedactedFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WebACLLoggingConfigurationSpec defines the desired state of WebACLLoggingConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebACLLoggingConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebACLLoggingConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLLoggingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLLoggingConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterConditionActionCondition
{
    /// <summary>Action setting that a log record must contain in order to meet the condition. Valid values for action are ALLOW, BLOCK, COUNT, CAPTCHA, CHALLENGE and EXCLUDED_AS_COUNT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterConditionLabelNameCondition
{
    /// <summary>Name of the label that a log record must contain in order to meet the condition. It must be a fully qualified label name, which includes a prefix, optional namespaces, and the label name itself. The prefix identifies the rule group or web ACL context of the rule that added the label.</summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterCondition
{
    /// <summary>Configuration for a single action condition. See Action Condition below for more details.</summary>
    [JsonPropertyName("actionCondition")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterConditionActionCondition? ActionCondition { get; set; }

    /// <summary>Condition for a single label name. See Label Name Condition below for more details.</summary>
    [JsonPropertyName("labelNameCondition")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilter
{
    /// <summary>Parameter that determines how to handle logs that meet the conditions and requirements of the filter. The valid values for behavior are KEEP or DROP.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Match condition(s) for the filter. See Condition below for more details.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilterCondition>? Condition { get; set; }

    /// <summary>Logic to apply to the filtering conditions. You can specify that a log must match all conditions or at least one condition in order to satisfy the filter. Valid values for requirement are MEETS_ALL or MEETS_ANY.</summary>
    [JsonPropertyName("requirement")]
    public string? Requirement { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilter
{
    /// <summary>Default handling for logs that don't match any of the specified filtering conditions. Valid values for default_behavior are KEEP or DROP.</summary>
    [JsonPropertyName("defaultBehavior")]
    public string? DefaultBehavior { get; set; }

    /// <summary>Filter(s) that you want to apply to the logs. See Filter below for more details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilterFilter>? Filter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsMethod
{
}
#nullable disable

#nullable enable
/// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsQueryString
{
}
#nullable disable

#nullable enable
/// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsSingleHeader
{
    /// <summary>Name of the query header to redact. This setting must be provided in lowercase characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsUriPath
{
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFields
{
    /// <summary>HTTP method to be redacted. It must be specified as an empty configuration block {}. The method indicates the type of operation that the request is asking the origin to perform.</summary>
    [JsonPropertyName("method")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsMethod? Method { get; set; }

    /// <summary>Whether to redact the query string. It must be specified as an empty configuration block {}. The query string is the part of a URL that appears after a ? character, if any.</summary>
    [JsonPropertyName("queryString")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsQueryString? QueryString { get; set; }

    /// <summary>"single_header" refers to the redaction of a single header. For more information, please see the details below under Single Header.</summary>
    [JsonPropertyName("singleHeader")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsSingleHeader? SingleHeader { get; set; }

    /// <summary>Configuration block that redacts the request URI path. It should be specified as an empty configuration block {}. The URI path is the part of a web request that identifies a resource, such as /images/daily-ad.jpg.</summary>
    [JsonPropertyName("uriPath")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFieldsUriPath? UriPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the WAFv2 Web ACL.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block that allows you to associate Amazon Kinesis Data Firehose, Cloudwatch Log log group, or S3 bucket Amazon Resource Names (ARNs) with the web ACL. Note: data firehose, log group, or bucket name must be prefixed with aws-waf-logs-, e.g. aws-waf-logs-example-firehose, aws-waf-logs-example-log-group, or aws-waf-logs-example-bucket. AWS Kinesis Firehose Delivery Stream ARNs</summary>
    [JsonPropertyName("logDestinationConfigs")]
    public IList<string>? LogDestinationConfigs { get; set; }

    /// <summary>Configuration block that specifies which web requests are kept in the logs and which are dropped. It allows filtering based on the rule action and the web request labels applied by matching rules during web ACL evaluation. For more details, refer to the Logging Filter section below.</summary>
    [JsonPropertyName("loggingFilter")]
    public V1beta1WebACLLoggingConfigurationStatusAtProviderLoggingFilter? LoggingFilter { get; set; }

    /// <summary>Configuration for parts of the request that you want to keep out of the logs. Up to 100 redacted_fields blocks are supported. See Redacted Fields below for more details. Parts of the request to exclude from logs</summary>
    [JsonPropertyName("redactedFields")]
    public IList<V1beta1WebACLLoggingConfigurationStatusAtProviderRedactedFields>? RedactedFields { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the web ACL that you want to associate with log_destination_configs. AWS WebACL ARN</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatusConditions
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
#nullable disable

#nullable enable
/// <summary>WebACLLoggingConfigurationStatus defines the observed state of WebACLLoggingConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLLoggingConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebACLLoggingConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebACLLoggingConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WebACLLoggingConfiguration is the Schema for the WebACLLoggingConfigurations API. Create a resource for WAFv2 Web ACL Logging Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLLoggingConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLLoggingConfigurationSpec>, IStatus<V1beta1WebACLLoggingConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLLoggingConfiguration";
    public const string KubeGroup = "wafv2.aws.m.upbound.io";
    public const string KubePluralName = "webaclloggingconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebACLLoggingConfigurationSpec defines the desired state of WebACLLoggingConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebACLLoggingConfigurationSpec Spec { get; set; }

    /// <summary>WebACLLoggingConfigurationStatus defines the observed state of WebACLLoggingConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebACLLoggingConfigurationStatus? Status { get; set; }
}
#nullable disable
