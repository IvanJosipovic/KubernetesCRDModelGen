using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apprunner.aws.m.upbound.io;
/// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpecForProviderTraceConfiguration
{
    /// <summary>Implementation provider chosen for tracing App Runner services. Valid values: AWSXRAY.</summary>
    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpecForProvider
{
    /// <summary>Name of the observability configuration.</summary>
    [JsonPropertyName("observabilityConfigurationName")]
    public string? ObservabilityConfigurationName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
    [JsonPropertyName("traceConfiguration")]
    public V1beta1ObservabilityConfigurationSpecForProviderTraceConfiguration? TraceConfiguration { get; set; }
}

/// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpecInitProviderTraceConfiguration
{
    /// <summary>Implementation provider chosen for tracing App Runner services. Valid values: AWSXRAY.</summary>
    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpecInitProvider
{
    /// <summary>Name of the observability configuration.</summary>
    [JsonPropertyName("observabilityConfigurationName")]
    public string? ObservabilityConfigurationName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
    [JsonPropertyName("traceConfiguration")]
    public V1beta1ObservabilityConfigurationSpecInitProviderTraceConfiguration? TraceConfiguration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpecProviderConfigRef
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
public partial class V1beta1ObservabilityConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ObservabilityConfigurationSpec defines the desired state of ObservabilityConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ObservabilityConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ObservabilityConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ObservabilityConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ObservabilityConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationStatusAtProviderTraceConfiguration
{
    /// <summary>Implementation provider chosen for tracing App Runner services. Valid values: AWSXRAY.</summary>
    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationStatusAtProvider
{
    /// <summary>ARN of this observability configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the observability configuration has the highest observability_configuration_revision among all configurations that share the same observability_configuration_name.</summary>
    [JsonPropertyName("latest")]
    public bool? Latest { get; set; }

    /// <summary>Name of the observability configuration.</summary>
    [JsonPropertyName("observabilityConfigurationName")]
    public string? ObservabilityConfigurationName { get; set; }

    /// <summary>The revision of this observability configuration.</summary>
    [JsonPropertyName("observabilityConfigurationRevision")]
    public double? ObservabilityConfigurationRevision { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Current state of the observability configuration. An INACTIVE configuration revision has been deleted and can't be used. It is permanently removed some time after deletion.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration of the tracing feature within this observability configuration. If you don't specify it, App Runner doesn't enable tracing. See Trace Configuration below for more details.</summary>
    [JsonPropertyName("traceConfiguration")]
    public V1beta1ObservabilityConfigurationStatusAtProviderTraceConfiguration? TraceConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationStatusConditions
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

/// <summary>ObservabilityConfigurationStatus defines the observed state of ObservabilityConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObservabilityConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ObservabilityConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ObservabilityConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ObservabilityConfiguration is the Schema for the ObservabilityConfigurations API. Manages an App Runner Observability Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ObservabilityConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ObservabilityConfigurationSpec>, IStatus<V1beta1ObservabilityConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ObservabilityConfiguration";
    public const string KubeGroup = "apprunner.aws.m.upbound.io";
    public const string KubePluralName = "observabilityconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ObservabilityConfigurationSpec defines the desired state of ObservabilityConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1ObservabilityConfigurationSpec Spec { get; set; }

    /// <summary>ObservabilityConfigurationStatus defines the observed state of ObservabilityConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1ObservabilityConfigurationStatus? Status { get; set; }
}

/// <summary>ObservabilityConfiguration is the Schema for the ObservabilityConfigurations API. Manages an App Runner Observability Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ObservabilityConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ObservabilityConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ObservabilityConfigurationList";
    public const string KubeGroup = "apprunner.aws.m.upbound.io";
    public const string KubePluralName = "observabilityconfigurations";
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
    public IList<V1beta1ObservabilityConfiguration> Items { get; set; }
}