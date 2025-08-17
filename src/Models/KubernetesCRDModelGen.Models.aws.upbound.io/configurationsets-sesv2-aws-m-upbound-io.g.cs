using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sesv2.aws.m.upbound.io;
#nullable enable
/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConfigurationSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSetList";
    public const string KubeGroup = "sesv2.aws.m.upbound.io";
    public const string KubePluralName = "configurationsets";
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
    public IList<V1beta1ConfigurationSet> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta1ConfigurationSetSpecForProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta1ConfigurationSetSpecForProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetSpecForProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta1ConfigurationSetSpecForProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta1ConfigurationSetSpecForProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta1ConfigurationSetSpecForProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetSpecForProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta1ConfigurationSetSpecForProviderVdmOptions? VdmOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta1ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta1ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetSpecInitProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta1ConfigurationSetSpecInitProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta1ConfigurationSetSpecInitProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta1ConfigurationSetSpecInitProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetSpecInitProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta1ConfigurationSetSpecInitProviderVdmOptions? VdmOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecProviderConfigRef
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
public partial class V1beta1ConfigurationSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigurationSetSpec defines the desired state of ConfigurationSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigurationSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigurationSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigurationSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigurationSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderReputationOptions
{
    /// <summary>The date and time (in Unix time) when the reputation metrics were last given a fresh start. When your account is given a fresh start, your reputation metrics are calculated starting from the date of the fresh start.</summary>
    [JsonPropertyName("lastFreshStart")]
    public string? LastFreshStart { get; set; }

    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta1ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta1ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProvider
{
    /// <summary>ARN of the Configuration Set.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetStatusAtProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta1ConfigurationSetStatusAtProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta1ConfigurationSetStatusAtProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta1ConfigurationSetStatusAtProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetStatusAtProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta1ConfigurationSetStatusAtProviderVdmOptions? VdmOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusConditions
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
/// <summary>ConfigurationSetStatus defines the observed state of ConfigurationSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigurationSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigurationSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigurationSetSpec>, IStatus<V1beta1ConfigurationSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSet";
    public const string KubeGroup = "sesv2.aws.m.upbound.io";
    public const string KubePluralName = "configurationsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSetSpec defines the desired state of ConfigurationSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigurationSetSpec Spec { get; set; }

    /// <summary>ConfigurationSetStatus defines the observed state of ConfigurationSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigurationSetStatus? Status { get; set; }
}
#nullable disable
