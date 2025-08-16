using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary>AnalyticsHubDataExchange is the Schema for the AnalyticsHubDataExchanges API. A Bigquery Analytics Hub data exchange</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AnalyticsHubDataExchangeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AnalyticsHubDataExchange>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AnalyticsHubDataExchangeList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "analyticshubdataexchanges";
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
    public IList<V1beta1AnalyticsHubDataExchange> Items { get; set; }
}

/// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfigDcrExchangeConfig
{
}

/// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfigDefaultExchangeConfig
{
}

/// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfig
{
    /// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
    [JsonPropertyName("dcrExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfigDcrExchangeConfig? DcrExchangeConfig { get; set; }

    /// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
    [JsonPropertyName("defaultExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfigDefaultExchangeConfig? DefaultExchangeConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecForProvider
{
    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Description of the data exchange.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the data exchange.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the data exchange.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>The name of the location this data exchange.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>Email or URL of the primary point of contact of the data exchange.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
    [JsonPropertyName("sharingEnvironmentConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecForProviderSharingEnvironmentConfig? SharingEnvironmentConfig { get; set; }
}

/// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfigDcrExchangeConfig
{
}

/// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfigDefaultExchangeConfig
{
}

/// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfig
{
    /// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
    [JsonPropertyName("dcrExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfigDcrExchangeConfig? DcrExchangeConfig { get; set; }

    /// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
    [JsonPropertyName("defaultExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfigDefaultExchangeConfig? DefaultExchangeConfig { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecInitProvider
{
    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Description of the data exchange.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the data exchange.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the data exchange.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>The name of the location this data exchange.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>Email or URL of the primary point of contact of the data exchange.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
    [JsonPropertyName("sharingEnvironmentConfig")]
    public V1beta1AnalyticsHubDataExchangeSpecInitProviderSharingEnvironmentConfig? SharingEnvironmentConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubDataExchangeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AnalyticsHubDataExchangeSpec defines the desired state of AnalyticsHubDataExchange</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AnalyticsHubDataExchangeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AnalyticsHubDataExchangeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AnalyticsHubDataExchangeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AnalyticsHubDataExchangeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfigDcrExchangeConfig
{
}

/// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfigDefaultExchangeConfig
{
}

/// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfig
{
    /// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
    [JsonPropertyName("dcrExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfigDcrExchangeConfig? DcrExchangeConfig { get; set; }

    /// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
    [JsonPropertyName("defaultExchangeConfig")]
    public V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfigDefaultExchangeConfig? DefaultExchangeConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatusAtProvider
{
    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Description of the data exchange.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the data exchange.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the data exchange.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/dataExchanges/{{data_exchange_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of listings contained in the data exchange.</summary>
    [JsonPropertyName("listingCount")]
    public double? ListingCount { get; set; }

    /// <summary>The name of the location this data exchange.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>The resource name of the data exchange, for example: "projects/myproject/locations/US/dataExchanges/123"</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the primary point of contact of the data exchange.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configurable data sharing environment option for a data exchange. This field is required for data clean room exchanges. Structure is documented below.</summary>
    [JsonPropertyName("sharingEnvironmentConfig")]
    public V1beta1AnalyticsHubDataExchangeStatusAtProviderSharingEnvironmentConfig? SharingEnvironmentConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatusConditions
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

/// <summary>AnalyticsHubDataExchangeStatus defines the observed state of AnalyticsHubDataExchange.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubDataExchangeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AnalyticsHubDataExchangeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AnalyticsHubDataExchangeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AnalyticsHubDataExchange is the Schema for the AnalyticsHubDataExchanges API. A Bigquery Analytics Hub data exchange</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AnalyticsHubDataExchange : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AnalyticsHubDataExchangeSpec>, IStatus<V1beta1AnalyticsHubDataExchangeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AnalyticsHubDataExchange";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "analyticshubdataexchanges";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AnalyticsHubDataExchangeSpec defines the desired state of AnalyticsHubDataExchange</summary>
    [JsonPropertyName("spec")]
    public V1beta1AnalyticsHubDataExchangeSpec Spec { get; set; }

    /// <summary>AnalyticsHubDataExchangeStatus defines the observed state of AnalyticsHubDataExchange.</summary>
    [JsonPropertyName("status")]
    public V1beta1AnalyticsHubDataExchangeStatus? Status { get; set; }
}