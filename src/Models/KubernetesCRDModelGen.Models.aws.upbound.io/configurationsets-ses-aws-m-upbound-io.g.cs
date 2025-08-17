using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ses.aws.m.upbound.io;
#nullable enable
/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API. Provides an SES configuration set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConfigurationSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSetList";
    public const string KubeGroup = "ses.aws.m.upbound.io";
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
/// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderDeliveryOptions
{
    /// <summary>Whether messages that use the configuration set are required to use Transport Layer Security (TLS). If the value is Require, messages are only delivered if a TLS connection can be established. If the value is Optional, messages can be delivered in plain text if a TLS connection can't be established. Valid values: Require or Optional. Defaults to Optional.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProviderTrackingOptions
{
    /// <summary>Custom subdomain that is used to redirect email recipients to the Amazon SES event tracking domain.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecForProvider
{
    /// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetSpecForProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether or not Amazon SES publishes reputation metrics for the configuration set, such as bounce and complaint rates, to Amazon CloudWatch. The default value is false.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }

    /// <summary>Whether email sending is enabled or disabled for the configuration set. The default value is true.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }

    /// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetSpecForProviderTrackingOptions? TrackingOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderDeliveryOptions
{
    /// <summary>Whether messages that use the configuration set are required to use Transport Layer Security (TLS). If the value is Require, messages are only delivered if a TLS connection can be established. If the value is Optional, messages can be delivered in plain text if a TLS connection can't be established. Valid values: Require or Optional. Defaults to Optional.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProviderTrackingOptions
{
    /// <summary>Custom subdomain that is used to redirect email recipients to the Amazon SES event tracking domain.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetSpecInitProvider
{
    /// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetSpecInitProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>Whether or not Amazon SES publishes reputation metrics for the configuration set, such as bounce and complaint rates, to Amazon CloudWatch. The default value is false.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }

    /// <summary>Whether email sending is enabled or disabled for the configuration set. The default value is true.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }

    /// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetSpecInitProviderTrackingOptions? TrackingOptions { get; set; }
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
/// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderDeliveryOptions
{
    /// <summary>Whether messages that use the configuration set are required to use Transport Layer Security (TLS). If the value is Require, messages are only delivered if a TLS connection can be established. If the value is Optional, messages can be delivered in plain text if a TLS connection can't be established. Valid values: Require or Optional. Defaults to Optional.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProviderTrackingOptions
{
    /// <summary>Custom subdomain that is used to redirect email recipients to the Amazon SES event tracking domain.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetStatusAtProvider
{
    /// <summary>SES configuration set ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether messages that use the configuration set are required to use TLS. See below.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta1ConfigurationSetStatusAtProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>SES configuration set name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Date and time at which the reputation metrics for the configuration set were last reset. Resetting these metrics is known as a fresh start.</summary>
    [JsonPropertyName("lastFreshStart")]
    public string? LastFreshStart { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether or not Amazon SES publishes reputation metrics for the configuration set, such as bounce and complaint rates, to Amazon CloudWatch. The default value is false.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }

    /// <summary>Whether email sending is enabled or disabled for the configuration set. The default value is true.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }

    /// <summary>Domain that is used to redirect email recipients to an Amazon SES-operated domain. See below. NOTE: This functionality is best effort.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta1ConfigurationSetStatusAtProviderTrackingOptions? TrackingOptions { get; set; }
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
/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API. Provides an SES configuration set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigurationSetSpec>, IStatus<V1beta1ConfigurationSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSet";
    public const string KubeGroup = "ses.aws.m.upbound.io";
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
