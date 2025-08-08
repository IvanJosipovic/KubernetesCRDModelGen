using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderChildHealthchecksRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderChildHealthchecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthCheckSpecForProviderChildHealthchecksRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderChildHealthchecksSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in route53 to populate childHealthchecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderChildHealthchecksSelector
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
    public V1beta1HealthCheckSpecForProviderChildHealthchecksSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameSelector
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
    public V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecForProvider
{
    /// <summary>The minimum number of child health checks that must be healthy for Route 53 to consider the parent health check to be healthy. Valid values are integers between 0 and 256, inclusive</summary>
    [JsonPropertyName("childHealthThreshold")]
    public double? ChildHealthThreshold { get; set; }

    /// <summary>For a specified parent health check, a list of HealthCheckId values for the associated child health checks.</summary>
    [JsonPropertyName("childHealthchecks")]
    public IList<string>? ChildHealthchecks { get; set; }

    /// <summary>References to HealthCheck in route53 to populate childHealthchecks.</summary>
    [JsonPropertyName("childHealthchecksRefs")]
    public IList<V1beta1HealthCheckSpecForProviderChildHealthchecksRefs>? ChildHealthchecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in route53 to populate childHealthchecks.</summary>
    [JsonPropertyName("childHealthchecksSelector")]
    public V1beta1HealthCheckSpecForProviderChildHealthchecksSelector? ChildHealthchecksSelector { get; set; }

    /// <summary>The name of the CloudWatch alarm.</summary>
    [JsonPropertyName("cloudwatchAlarmName")]
    public string? CloudwatchAlarmName { get; set; }

    /// <summary>Reference to a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
    [JsonPropertyName("cloudwatchAlarmNameRef")]
    public V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameRef? CloudwatchAlarmNameRef { get; set; }

    /// <summary>Selector for a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
    [JsonPropertyName("cloudwatchAlarmNameSelector")]
    public V1beta1HealthCheckSpecForProviderCloudwatchAlarmNameSelector? CloudwatchAlarmNameSelector { get; set; }

    /// <summary>The region that the CloudWatch alarm was created in.</summary>
    [JsonPropertyName("cloudwatchAlarmRegion")]
    public string? CloudwatchAlarmRegion { get; set; }

    /// <summary>A boolean value that stops Route 53 from performing health checks. When set to true, Route 53 will do the following depending on the type of health check:</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A boolean value that indicates whether Route53 should send the fqdn to the endpoint when performing the health check. This defaults to AWS' defaults: when the type is "HTTPS" enable_sni defaults to true, when type is anything else enable_sni defaults to false.</summary>
    [JsonPropertyName("enableSni")]
    public bool? EnableSni { get; set; }

    /// <summary>The number of consecutive health checks that an endpoint must pass or fail.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The fully qualified domain name of the endpoint to be checked. If a value is set for ip_address, the value set for fqdn will be passed in the Host header.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The status of the health check when CloudWatch has insufficient data about the state of associated alarm. Valid values are Healthy , Unhealthy and LastKnownStatus.</summary>
    [JsonPropertyName("insufficientDataHealthStatus")]
    public string? InsufficientDataHealthStatus { get; set; }

    /// <summary>A boolean value that indicates whether the status of health check should be inverted. For example, if a health check is healthy but Inverted is True , then Route 53 considers the health check to be unhealthy.</summary>
    [JsonPropertyName("invertHealthcheck")]
    public bool? InvertHealthcheck { get; set; }

    /// <summary>The IP address of the endpoint to be checked.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A Boolean value that indicates whether you want Route 53 to measure the latency between health checkers in multiple AWS regions and your endpoint and to display CloudWatch latency graphs in the Route 53 console.</summary>
    [JsonPropertyName("measureLatency")]
    public bool? MeasureLatency { get; set; }

    /// <summary>The port of the endpoint to be checked.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>This is a reference name used in Caller Reference (helpful for identifying single health_check set amongst others)</summary>
    [JsonPropertyName("referenceName")]
    public string? ReferenceName { get; set; }

    /// <summary>A list of AWS regions that you want Amazon Route 53 health checkers to check the specified endpoint from.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>The number of seconds between the time that Amazon Route 53 gets a response from your endpoint and the time that it sends the next health-check request.</summary>
    [JsonPropertyName("requestInterval")]
    public double? RequestInterval { get; set; }

    /// <summary>The path that you want Amazon Route 53 to request when performing health checks.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the Route 53 Application Recovery Controller routing control. This is used when health check type is RECOVERY_CONTROL</summary>
    [JsonPropertyName("routingControlArn")]
    public string? RoutingControlArn { get; set; }

    /// <summary>String searched in the first 5120 bytes of the response body for check to be considered healthy. Only valid with HTTP_STR_MATCH and HTTPS_STR_MATCH.</summary>
    [JsonPropertyName("searchString")]
    public string? SearchString { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update of the CloudWatch alarm arguments. Use this argument to synchronize the health check when an alarm is changed. See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>The protocol to use when performing health checks. Valid values are HTTP, HTTPS, HTTP_STR_MATCH, HTTPS_STR_MATCH, TCP, CALCULATED, CLOUDWATCH_METRIC and RECOVERY_CONTROL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderChildHealthchecksRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderChildHealthchecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthCheckSpecInitProviderChildHealthchecksRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderChildHealthchecksSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in route53 to populate childHealthchecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderChildHealthchecksSelector
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
    public V1beta1HealthCheckSpecInitProviderChildHealthchecksSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameSelector
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
    public V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecInitProvider
{
    /// <summary>The minimum number of child health checks that must be healthy for Route 53 to consider the parent health check to be healthy. Valid values are integers between 0 and 256, inclusive</summary>
    [JsonPropertyName("childHealthThreshold")]
    public double? ChildHealthThreshold { get; set; }

    /// <summary>For a specified parent health check, a list of HealthCheckId values for the associated child health checks.</summary>
    [JsonPropertyName("childHealthchecks")]
    public IList<string>? ChildHealthchecks { get; set; }

    /// <summary>References to HealthCheck in route53 to populate childHealthchecks.</summary>
    [JsonPropertyName("childHealthchecksRefs")]
    public IList<V1beta1HealthCheckSpecInitProviderChildHealthchecksRefs>? ChildHealthchecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in route53 to populate childHealthchecks.</summary>
    [JsonPropertyName("childHealthchecksSelector")]
    public V1beta1HealthCheckSpecInitProviderChildHealthchecksSelector? ChildHealthchecksSelector { get; set; }

    /// <summary>The name of the CloudWatch alarm.</summary>
    [JsonPropertyName("cloudwatchAlarmName")]
    public string? CloudwatchAlarmName { get; set; }

    /// <summary>Reference to a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
    [JsonPropertyName("cloudwatchAlarmNameRef")]
    public V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameRef? CloudwatchAlarmNameRef { get; set; }

    /// <summary>Selector for a MetricAlarm in cloudwatch to populate cloudwatchAlarmName.</summary>
    [JsonPropertyName("cloudwatchAlarmNameSelector")]
    public V1beta1HealthCheckSpecInitProviderCloudwatchAlarmNameSelector? CloudwatchAlarmNameSelector { get; set; }

    /// <summary>The region that the CloudWatch alarm was created in.</summary>
    [JsonPropertyName("cloudwatchAlarmRegion")]
    public string? CloudwatchAlarmRegion { get; set; }

    /// <summary>A boolean value that stops Route 53 from performing health checks. When set to true, Route 53 will do the following depending on the type of health check:</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A boolean value that indicates whether Route53 should send the fqdn to the endpoint when performing the health check. This defaults to AWS' defaults: when the type is "HTTPS" enable_sni defaults to true, when type is anything else enable_sni defaults to false.</summary>
    [JsonPropertyName("enableSni")]
    public bool? EnableSni { get; set; }

    /// <summary>The number of consecutive health checks that an endpoint must pass or fail.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The fully qualified domain name of the endpoint to be checked. If a value is set for ip_address, the value set for fqdn will be passed in the Host header.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The status of the health check when CloudWatch has insufficient data about the state of associated alarm. Valid values are Healthy , Unhealthy and LastKnownStatus.</summary>
    [JsonPropertyName("insufficientDataHealthStatus")]
    public string? InsufficientDataHealthStatus { get; set; }

    /// <summary>A boolean value that indicates whether the status of health check should be inverted. For example, if a health check is healthy but Inverted is True , then Route 53 considers the health check to be unhealthy.</summary>
    [JsonPropertyName("invertHealthcheck")]
    public bool? InvertHealthcheck { get; set; }

    /// <summary>The IP address of the endpoint to be checked.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A Boolean value that indicates whether you want Route 53 to measure the latency between health checkers in multiple AWS regions and your endpoint and to display CloudWatch latency graphs in the Route 53 console.</summary>
    [JsonPropertyName("measureLatency")]
    public bool? MeasureLatency { get; set; }

    /// <summary>The port of the endpoint to be checked.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>This is a reference name used in Caller Reference (helpful for identifying single health_check set amongst others)</summary>
    [JsonPropertyName("referenceName")]
    public string? ReferenceName { get; set; }

    /// <summary>A list of AWS regions that you want Amazon Route 53 health checkers to check the specified endpoint from.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>The number of seconds between the time that Amazon Route 53 gets a response from your endpoint and the time that it sends the next health-check request.</summary>
    [JsonPropertyName("requestInterval")]
    public double? RequestInterval { get; set; }

    /// <summary>The path that you want Amazon Route 53 to request when performing health checks.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the Route 53 Application Recovery Controller routing control. This is used when health check type is RECOVERY_CONTROL</summary>
    [JsonPropertyName("routingControlArn")]
    public string? RoutingControlArn { get; set; }

    /// <summary>String searched in the first 5120 bytes of the response body for check to be considered healthy. Only valid with HTTP_STR_MATCH and HTTPS_STR_MATCH.</summary>
    [JsonPropertyName("searchString")]
    public string? SearchString { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update of the CloudWatch alarm arguments. Use this argument to synchronize the health check when an alarm is changed. See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>The protocol to use when performing health checks. Valid values are HTTP, HTTPS, HTTP_STR_MATCH, HTTPS_STR_MATCH, TCP, CALCULATED, CLOUDWATCH_METRIC and RECOVERY_CONTROL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpecProviderConfigRef
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
public partial class V1beta1HealthCheckSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>HealthCheckSpec defines the desired state of HealthCheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HealthCheckSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HealthCheckSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HealthCheckSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HealthCheckSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Health Check.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The minimum number of child health checks that must be healthy for Route 53 to consider the parent health check to be healthy. Valid values are integers between 0 and 256, inclusive</summary>
    [JsonPropertyName("childHealthThreshold")]
    public double? ChildHealthThreshold { get; set; }

    /// <summary>For a specified parent health check, a list of HealthCheckId values for the associated child health checks.</summary>
    [JsonPropertyName("childHealthchecks")]
    public IList<string>? ChildHealthchecks { get; set; }

    /// <summary>The name of the CloudWatch alarm.</summary>
    [JsonPropertyName("cloudwatchAlarmName")]
    public string? CloudwatchAlarmName { get; set; }

    /// <summary>The region that the CloudWatch alarm was created in.</summary>
    [JsonPropertyName("cloudwatchAlarmRegion")]
    public string? CloudwatchAlarmRegion { get; set; }

    /// <summary>A boolean value that stops Route 53 from performing health checks. When set to true, Route 53 will do the following depending on the type of health check:</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A boolean value that indicates whether Route53 should send the fqdn to the endpoint when performing the health check. This defaults to AWS' defaults: when the type is "HTTPS" enable_sni defaults to true, when type is anything else enable_sni defaults to false.</summary>
    [JsonPropertyName("enableSni")]
    public bool? EnableSni { get; set; }

    /// <summary>The number of consecutive health checks that an endpoint must pass or fail.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The fully qualified domain name of the endpoint to be checked. If a value is set for ip_address, the value set for fqdn will be passed in the Host header.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The id of the health check</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The status of the health check when CloudWatch has insufficient data about the state of associated alarm. Valid values are Healthy , Unhealthy and LastKnownStatus.</summary>
    [JsonPropertyName("insufficientDataHealthStatus")]
    public string? InsufficientDataHealthStatus { get; set; }

    /// <summary>A boolean value that indicates whether the status of health check should be inverted. For example, if a health check is healthy but Inverted is True , then Route 53 considers the health check to be unhealthy.</summary>
    [JsonPropertyName("invertHealthcheck")]
    public bool? InvertHealthcheck { get; set; }

    /// <summary>The IP address of the endpoint to be checked.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A Boolean value that indicates whether you want Route 53 to measure the latency between health checkers in multiple AWS regions and your endpoint and to display CloudWatch latency graphs in the Route 53 console.</summary>
    [JsonPropertyName("measureLatency")]
    public bool? MeasureLatency { get; set; }

    /// <summary>The port of the endpoint to be checked.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>This is a reference name used in Caller Reference (helpful for identifying single health_check set amongst others)</summary>
    [JsonPropertyName("referenceName")]
    public string? ReferenceName { get; set; }

    /// <summary>A list of AWS regions that you want Amazon Route 53 health checkers to check the specified endpoint from.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>The number of seconds between the time that Amazon Route 53 gets a response from your endpoint and the time that it sends the next health-check request.</summary>
    [JsonPropertyName("requestInterval")]
    public double? RequestInterval { get; set; }

    /// <summary>The path that you want Amazon Route 53 to request when performing health checks.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the Route 53 Application Recovery Controller routing control. This is used when health check type is RECOVERY_CONTROL</summary>
    [JsonPropertyName("routingControlArn")]
    public string? RoutingControlArn { get; set; }

    /// <summary>String searched in the first 5120 bytes of the response body for check to be considered healthy. Only valid with HTTP_STR_MATCH and HTTPS_STR_MATCH.</summary>
    [JsonPropertyName("searchString")]
    public string? SearchString { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update of the CloudWatch alarm arguments. Use this argument to synchronize the health check when an alarm is changed. See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>The protocol to use when performing health checks. Valid values are HTTP, HTTPS, HTTP_STR_MATCH, HTTPS_STR_MATCH, TCP, CALCULATED, CLOUDWATCH_METRIC and RECOVERY_CONTROL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckStatusConditions
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

/// <summary>HealthCheckStatus defines the observed state of HealthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthCheckStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HealthCheckStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthCheck is the Schema for the HealthChecks API. Provides a Route53 health check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HealthCheckSpec>, IStatus<V1beta1HealthCheckStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthCheck";
    public const string KubeGroup = "route53.aws.m.upbound.io";
    public const string KubePluralName = "healthchecks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthCheckSpec defines the desired state of HealthCheck</summary>
    [JsonPropertyName("spec")]
    public V1beta1HealthCheckSpec Spec { get; set; }

    /// <summary>HealthCheckStatus defines the observed state of HealthCheck.</summary>
    [JsonPropertyName("status")]
    public V1beta1HealthCheckStatus? Status { get; set; }
}

/// <summary>HealthCheck is the Schema for the HealthChecks API. Provides a Route53 health check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthCheckList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HealthCheck>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthCheckList";
    public const string KubeGroup = "route53.aws.m.upbound.io";
    public const string KubePluralName = "healthchecks";
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
    public IList<V1beta1HealthCheck> Items { get; set; }
}