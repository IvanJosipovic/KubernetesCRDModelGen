using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfigApiSecurityConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfigConnectorsPlatformConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfigIntegrationConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Addon configurations of the Apigee organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpecAddonsConfig
{
    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("apiSecurityConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfigApiSecurityConfig? ApiSecurityConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("connectorsPlatformConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfigConnectorsPlatformConfig? ConnectorsPlatformConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("integrationConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfigIntegrationConfig? IntegrationConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigSpec
{
    /// <summary>Addon configurations of the Apigee organization.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1alpha1ApigeeAddonsConfigSpecAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Immutable. Name of the Apigee organization.</summary>
    [JsonPropertyName("org")]
    public string Org { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAddonsConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApigeeAddonsConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeAddonsConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApigeeAddonsConfigSpec>, IStatus<V1alpha1ApigeeAddonsConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeAddonsConfig";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeaddonsconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApigeeAddonsConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ApigeeAddonsConfigStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeAddonsConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ApigeeAddonsConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeAddonsConfigList";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeaddonsconfigs";
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
    public IList<V1alpha1ApigeeAddonsConfig> Items { get; set; }
}