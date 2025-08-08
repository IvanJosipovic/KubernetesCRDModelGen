using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rum.aws.m.upbound.io;
/// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecForProviderAppMonitorConfiguration
{
    /// <summary>If you set this to true, RUM web client sets two cookies, a session cookie and a user cookie. The cookies allow the RUM web client to collect data relating to the number of users an application has and the behavior of the application across a sequence of events. Cookies are stored in the top-level domain of the current page.</summary>
    [JsonPropertyName("allowCookies")]
    public bool? AllowCookies { get; set; }

    /// <summary>If you set this to true, RUM enables X-Ray tracing for the user sessions that RUM samples. RUM adds an X-Ray trace header to allowed HTTP requests. It also records an X-Ray segment for allowed HTTP requests.</summary>
    [JsonPropertyName("enableXray")]
    public bool? EnableXray { get; set; }

    /// <summary>A list of URLs in your website or application to exclude from RUM data collection.</summary>
    [JsonPropertyName("excludedPages")]
    public IList<string>? ExcludedPages { get; set; }

    /// <summary>A list of pages in the CloudWatch RUM console that are to be displayed with a "favorite" icon.</summary>
    [JsonPropertyName("favoritePages")]
    public IList<string>? FavoritePages { get; set; }

    /// <summary>The ARN of the guest IAM role that is attached to the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("guestRoleArn")]
    public string? GuestRoleArn { get; set; }

    /// <summary>The ID of the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>If this app monitor is to collect data from only certain pages in your application, this structure lists those pages.</summary>
    [JsonPropertyName("includedPages")]
    public IList<string>? IncludedPages { get; set; }

    /// <summary>Specifies the percentage of user sessions to use for RUM data collection. Choosing a higher percentage gives you more data but also incurs more costs. The number you specify is the percentage of user sessions that will be used. Default value is 0.1.</summary>
    [JsonPropertyName("sessionSampleRate")]
    public double? SessionSampleRate { get; set; }

    /// <summary>An array that lists the types of telemetry data that this app monitor is to collect. Valid values are errors, performance, and http.</summary>
    [JsonPropertyName("telemetries")]
    public IList<string>? Telemetries { get; set; }
}

/// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecForProviderCustomEvents
{
    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. The default is for custom events to be DISABLED. Valid values are DISABLED and ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecForProvider
{
    /// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
    [JsonPropertyName("appMonitorConfiguration")]
    public V1beta1AppMonitorSpecForProviderAppMonitorConfiguration? AppMonitorConfiguration { get; set; }

    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
    [JsonPropertyName("customEvents")]
    public V1beta1AppMonitorSpecForProviderCustomEvents? CustomEvents { get; set; }

    /// <summary>Data collected by RUM is kept by RUM for 30 days and then deleted. This parameter specifies whether RUM sends a copy of this telemetry data to Amazon CloudWatch Logs in your account. This enables you to keep the telemetry data for more than 30 days, but it does incur Amazon CloudWatch Logs charges. Default value is false.</summary>
    [JsonPropertyName("cwLogEnabled")]
    public bool? CwLogEnabled { get; set; }

    /// <summary>The top-level internet domain name for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>A list of internet domain names for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domainList")]
    public IList<string>? DomainList { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecInitProviderAppMonitorConfiguration
{
    /// <summary>If you set this to true, RUM web client sets two cookies, a session cookie and a user cookie. The cookies allow the RUM web client to collect data relating to the number of users an application has and the behavior of the application across a sequence of events. Cookies are stored in the top-level domain of the current page.</summary>
    [JsonPropertyName("allowCookies")]
    public bool? AllowCookies { get; set; }

    /// <summary>If you set this to true, RUM enables X-Ray tracing for the user sessions that RUM samples. RUM adds an X-Ray trace header to allowed HTTP requests. It also records an X-Ray segment for allowed HTTP requests.</summary>
    [JsonPropertyName("enableXray")]
    public bool? EnableXray { get; set; }

    /// <summary>A list of URLs in your website or application to exclude from RUM data collection.</summary>
    [JsonPropertyName("excludedPages")]
    public IList<string>? ExcludedPages { get; set; }

    /// <summary>A list of pages in the CloudWatch RUM console that are to be displayed with a "favorite" icon.</summary>
    [JsonPropertyName("favoritePages")]
    public IList<string>? FavoritePages { get; set; }

    /// <summary>The ARN of the guest IAM role that is attached to the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("guestRoleArn")]
    public string? GuestRoleArn { get; set; }

    /// <summary>The ID of the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>If this app monitor is to collect data from only certain pages in your application, this structure lists those pages.</summary>
    [JsonPropertyName("includedPages")]
    public IList<string>? IncludedPages { get; set; }

    /// <summary>Specifies the percentage of user sessions to use for RUM data collection. Choosing a higher percentage gives you more data but also incurs more costs. The number you specify is the percentage of user sessions that will be used. Default value is 0.1.</summary>
    [JsonPropertyName("sessionSampleRate")]
    public double? SessionSampleRate { get; set; }

    /// <summary>An array that lists the types of telemetry data that this app monitor is to collect. Valid values are errors, performance, and http.</summary>
    [JsonPropertyName("telemetries")]
    public IList<string>? Telemetries { get; set; }
}

/// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecInitProviderCustomEvents
{
    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. The default is for custom events to be DISABLED. Valid values are DISABLED and ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecInitProvider
{
    /// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
    [JsonPropertyName("appMonitorConfiguration")]
    public V1beta1AppMonitorSpecInitProviderAppMonitorConfiguration? AppMonitorConfiguration { get; set; }

    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
    [JsonPropertyName("customEvents")]
    public V1beta1AppMonitorSpecInitProviderCustomEvents? CustomEvents { get; set; }

    /// <summary>Data collected by RUM is kept by RUM for 30 days and then deleted. This parameter specifies whether RUM sends a copy of this telemetry data to Amazon CloudWatch Logs in your account. This enables you to keep the telemetry data for more than 30 days, but it does incur Amazon CloudWatch Logs charges. Default value is false.</summary>
    [JsonPropertyName("cwLogEnabled")]
    public bool? CwLogEnabled { get; set; }

    /// <summary>The top-level internet domain name for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>A list of internet domain names for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domainList")]
    public IList<string>? DomainList { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpecProviderConfigRef
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
public partial class V1beta1AppMonitorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AppMonitorSpec defines the desired state of AppMonitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppMonitorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppMonitorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppMonitorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppMonitorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorStatusAtProviderAppMonitorConfiguration
{
    /// <summary>If you set this to true, RUM web client sets two cookies, a session cookie and a user cookie. The cookies allow the RUM web client to collect data relating to the number of users an application has and the behavior of the application across a sequence of events. Cookies are stored in the top-level domain of the current page.</summary>
    [JsonPropertyName("allowCookies")]
    public bool? AllowCookies { get; set; }

    /// <summary>If you set this to true, RUM enables X-Ray tracing for the user sessions that RUM samples. RUM adds an X-Ray trace header to allowed HTTP requests. It also records an X-Ray segment for allowed HTTP requests.</summary>
    [JsonPropertyName("enableXray")]
    public bool? EnableXray { get; set; }

    /// <summary>A list of URLs in your website or application to exclude from RUM data collection.</summary>
    [JsonPropertyName("excludedPages")]
    public IList<string>? ExcludedPages { get; set; }

    /// <summary>A list of pages in the CloudWatch RUM console that are to be displayed with a "favorite" icon.</summary>
    [JsonPropertyName("favoritePages")]
    public IList<string>? FavoritePages { get; set; }

    /// <summary>The ARN of the guest IAM role that is attached to the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("guestRoleArn")]
    public string? GuestRoleArn { get; set; }

    /// <summary>The ID of the Amazon Cognito identity pool that is used to authorize the sending of data to RUM.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>If this app monitor is to collect data from only certain pages in your application, this structure lists those pages.</summary>
    [JsonPropertyName("includedPages")]
    public IList<string>? IncludedPages { get; set; }

    /// <summary>Specifies the percentage of user sessions to use for RUM data collection. Choosing a higher percentage gives you more data but also incurs more costs. The number you specify is the percentage of user sessions that will be used. Default value is 0.1.</summary>
    [JsonPropertyName("sessionSampleRate")]
    public double? SessionSampleRate { get; set; }

    /// <summary>An array that lists the types of telemetry data that this app monitor is to collect. Valid values are errors, performance, and http.</summary>
    [JsonPropertyName("telemetries")]
    public IList<string>? Telemetries { get; set; }
}

/// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorStatusAtProviderCustomEvents
{
    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. The default is for custom events to be DISABLED. Valid values are DISABLED and ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorStatusAtProvider
{
    /// <summary>configuration data for the app monitor. See app_monitor_configuration below.</summary>
    [JsonPropertyName("appMonitorConfiguration")]
    public V1beta1AppMonitorStatusAtProviderAppMonitorConfiguration? AppMonitorConfiguration { get; set; }

    /// <summary>The unique ID of the app monitor. Useful for JS templates.</summary>
    [JsonPropertyName("appMonitorId")]
    public string? AppMonitorId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) specifying the app monitor.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies whether this app monitor allows the web client to define and send custom events. If you omit this parameter, custom events are DISABLED. See custom_events below.</summary>
    [JsonPropertyName("customEvents")]
    public V1beta1AppMonitorStatusAtProviderCustomEvents? CustomEvents { get; set; }

    /// <summary>Data collected by RUM is kept by RUM for 30 days and then deleted. This parameter specifies whether RUM sends a copy of this telemetry data to Amazon CloudWatch Logs in your account. This enables you to keep the telemetry data for more than 30 days, but it does incur Amazon CloudWatch Logs charges. Default value is false.</summary>
    [JsonPropertyName("cwLogEnabled")]
    public bool? CwLogEnabled { get; set; }

    /// <summary>The name of the log group where the copies are stored.</summary>
    [JsonPropertyName("cwLogGroup")]
    public string? CwLogGroup { get; set; }

    /// <summary>The top-level internet domain name for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>A list of internet domain names for which your application has administrative authority. Exactly one of domain or domain_list must be specified.</summary>
    [JsonPropertyName("domainList")]
    public IList<string>? DomainList { get; set; }

    /// <summary>The CloudWatch RUM name as it is the identifier of a RUM.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorStatusConditions
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

/// <summary>AppMonitorStatus defines the observed state of AppMonitor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppMonitorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppMonitorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppMonitorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AppMonitor is the Schema for the AppMonitors API. Provides a CloudWatch RUM App Monitor resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppMonitor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppMonitorSpec>, IStatus<V1beta1AppMonitorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppMonitor";
    public const string KubeGroup = "rum.aws.m.upbound.io";
    public const string KubePluralName = "appmonitors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppMonitorSpec defines the desired state of AppMonitor</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppMonitorSpec Spec { get; set; }

    /// <summary>AppMonitorStatus defines the observed state of AppMonitor.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppMonitorStatus? Status { get; set; }
}

/// <summary>AppMonitor is the Schema for the AppMonitors API. Provides a CloudWatch RUM App Monitor resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppMonitorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AppMonitor>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppMonitorList";
    public const string KubeGroup = "rum.aws.m.upbound.io";
    public const string KubePluralName = "appmonitors";
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
    public IList<V1beta1AppMonitor> Items { get; set; }
}