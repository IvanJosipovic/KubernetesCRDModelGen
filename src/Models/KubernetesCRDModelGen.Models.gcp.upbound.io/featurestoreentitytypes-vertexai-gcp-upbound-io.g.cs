using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.gcp.upbound.io;
/// <summary>FeaturestoreEntitytype is the Schema for the FeaturestoreEntitytypes API. An entity type is a type of object in a system that needs to be modeled and have stored information about.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FeaturestoreEntitytypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FeaturestoreEntitytype>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FeaturestoreEntitytypeList";
    public const string KubeGroup = "vertexai.gcp.upbound.io";
    public const string KubePluralName = "featurestoreentitytypes";
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
    public IList<V1beta1FeaturestoreEntitytype> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Featurestore in vertexai to populate featurestore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Featurestore in vertexai to populate featurestore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigCategoricalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigImportFeaturesAnalysis
{
    /// <summary>Defines the baseline to do anomaly detection for feature values imported by each [entityTypes.importFeatureValues][] operation. The value must be one of the values below:</summary>
    [JsonPropertyName("anomalyDetectionBaseline")]
    public string? AnomalyDetectionBaseline { get; set; }

    /// <summary>Whether to enable / disable / inherite default hebavior for import features analysis. The value must be one of the values below:</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigNumericalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigSnapshotAnalysis
{
    /// <summary>The monitoring schedule for snapshot analysis. For EntityType-level config: unset / disabled = true indicates disabled by default for Features under it; otherwise by default enable snapshot analysis monitoring with monitoringInterval for Features under it.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Configuration of the snapshot analysis based monitoring pipeline running interval. The value indicates number of days. The default value is 1. If both FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days and [FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval][] are set when creating/updating EntityTypes/Features, FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days will be used.</summary>
    [JsonPropertyName("monitoringIntervalDays")]
    public double? MonitoringIntervalDays { get; set; }

    /// <summary>Customized export features time window for snapshot analysis. Unit is one day. The default value is 21 days. Minimum value is 1 day. Maximum value is 4000 days.</summary>
    [JsonPropertyName("stalenessDays")]
    public double? StalenessDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfig
{
    /// <summary>Threshold for categorical features of anomaly detection. This is shared by all types of Featurestore Monitoring for categorical features (i.e. Features with type (Feature.ValueType) BOOL or STRING). Structure is documented below.</summary>
    [JsonPropertyName("categoricalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigCategoricalThresholdConfig>? CategoricalThresholdConfig { get; set; }

    /// <summary>The config for ImportFeatures Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("importFeaturesAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigImportFeaturesAnalysis>? ImportFeaturesAnalysis { get; set; }

    /// <summary>Threshold for numerical features of anomaly detection. This is shared by all objectives of Featurestore Monitoring for numerical features (i.e. Features with type (Feature.ValueType) DOUBLE or INT64). Structure is documented below.</summary>
    [JsonPropertyName("numericalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigNumericalThresholdConfig>? NumericalThresholdConfig { get; set; }

    /// <summary>The config for Snapshot Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("snapshotAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfigSnapshotAnalysis>? SnapshotAnalysis { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecForProvider
{
    /// <summary>Optional. Description of the EntityType.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.</summary>
    [JsonPropertyName("featurestore")]
    public string? Featurestore { get; set; }

    /// <summary>Reference to a Featurestore in vertexai to populate featurestore.</summary>
    [JsonPropertyName("featurestoreRef")]
    public V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreRef? FeaturestoreRef { get; set; }

    /// <summary>Selector for a Featurestore in vertexai to populate featurestore.</summary>
    [JsonPropertyName("featurestoreSelector")]
    public V1beta1FeaturestoreEntitytypeSpecForProviderFeaturestoreSelector? FeaturestoreSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this EntityType.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The default monitoring configuration for all Features under this EntityType. If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecForProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Featurestore in vertexai to populate featurestore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Featurestore in vertexai to populate featurestore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigCategoricalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigImportFeaturesAnalysis
{
    /// <summary>Defines the baseline to do anomaly detection for feature values imported by each [entityTypes.importFeatureValues][] operation. The value must be one of the values below:</summary>
    [JsonPropertyName("anomalyDetectionBaseline")]
    public string? AnomalyDetectionBaseline { get; set; }

    /// <summary>Whether to enable / disable / inherite default hebavior for import features analysis. The value must be one of the values below:</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigNumericalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigSnapshotAnalysis
{
    /// <summary>The monitoring schedule for snapshot analysis. For EntityType-level config: unset / disabled = true indicates disabled by default for Features under it; otherwise by default enable snapshot analysis monitoring with monitoringInterval for Features under it.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Configuration of the snapshot analysis based monitoring pipeline running interval. The value indicates number of days. The default value is 1. If both FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days and [FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval][] are set when creating/updating EntityTypes/Features, FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days will be used.</summary>
    [JsonPropertyName("monitoringIntervalDays")]
    public double? MonitoringIntervalDays { get; set; }

    /// <summary>Customized export features time window for snapshot analysis. Unit is one day. The default value is 21 days. Minimum value is 1 day. Maximum value is 4000 days.</summary>
    [JsonPropertyName("stalenessDays")]
    public double? StalenessDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfig
{
    /// <summary>Threshold for categorical features of anomaly detection. This is shared by all types of Featurestore Monitoring for categorical features (i.e. Features with type (Feature.ValueType) BOOL or STRING). Structure is documented below.</summary>
    [JsonPropertyName("categoricalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigCategoricalThresholdConfig>? CategoricalThresholdConfig { get; set; }

    /// <summary>The config for ImportFeatures Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("importFeaturesAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigImportFeaturesAnalysis>? ImportFeaturesAnalysis { get; set; }

    /// <summary>Threshold for numerical features of anomaly detection. This is shared by all objectives of Featurestore Monitoring for numerical features (i.e. Features with type (Feature.ValueType) DOUBLE or INT64). Structure is documented below.</summary>
    [JsonPropertyName("numericalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigNumericalThresholdConfig>? NumericalThresholdConfig { get; set; }

    /// <summary>The config for Snapshot Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("snapshotAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfigSnapshotAnalysis>? SnapshotAnalysis { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecInitProvider
{
    /// <summary>Optional. Description of the EntityType.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.</summary>
    [JsonPropertyName("featurestore")]
    public string? Featurestore { get; set; }

    /// <summary>Reference to a Featurestore in vertexai to populate featurestore.</summary>
    [JsonPropertyName("featurestoreRef")]
    public V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreRef? FeaturestoreRef { get; set; }

    /// <summary>Selector for a Featurestore in vertexai to populate featurestore.</summary>
    [JsonPropertyName("featurestoreSelector")]
    public V1beta1FeaturestoreEntitytypeSpecInitProviderFeaturestoreSelector? FeaturestoreSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this EntityType.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The default monitoring configuration for all Features under this EntityType. If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1FeaturestoreEntitytypeSpecInitProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecProviderConfigRefPolicy
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
public partial class V1beta1FeaturestoreEntitytypeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FeaturestoreEntitytypeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FeaturestoreEntitytypeSpec defines the desired state of FeaturestoreEntitytype</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FeaturestoreEntitytypeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FeaturestoreEntitytypeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FeaturestoreEntitytypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FeaturestoreEntitytypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigCategoricalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigImportFeaturesAnalysis
{
    /// <summary>Defines the baseline to do anomaly detection for feature values imported by each [entityTypes.importFeatureValues][] operation. The value must be one of the values below:</summary>
    [JsonPropertyName("anomalyDetectionBaseline")]
    public string? AnomalyDetectionBaseline { get; set; }

    /// <summary>Whether to enable / disable / inherite default hebavior for import features analysis. The value must be one of the values below:</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigNumericalThresholdConfig
{
    /// <summary>Specify a threshold value that can trigger the alert. For numerical feature, the distribution distance is calculated by Jensen–Shannon divergence. Each feature must have a non-zero threshold if they need to be monitored. Otherwise no alert will be triggered for that feature. The default value is 0.3.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigSnapshotAnalysis
{
    /// <summary>The monitoring schedule for snapshot analysis. For EntityType-level config: unset / disabled = true indicates disabled by default for Features under it; otherwise by default enable snapshot analysis monitoring with monitoringInterval for Features under it.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Configuration of the snapshot analysis based monitoring pipeline running interval. The value indicates number of days. The default value is 1. If both FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days and [FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval][] are set when creating/updating EntityTypes/Features, FeaturestoreMonitoringConfig.SnapshotAnalysis.monitoring_interval_days will be used.</summary>
    [JsonPropertyName("monitoringIntervalDays")]
    public double? MonitoringIntervalDays { get; set; }

    /// <summary>Customized export features time window for snapshot analysis. Unit is one day. The default value is 21 days. Minimum value is 1 day. Maximum value is 4000 days.</summary>
    [JsonPropertyName("stalenessDays")]
    public double? StalenessDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfig
{
    /// <summary>Threshold for categorical features of anomaly detection. This is shared by all types of Featurestore Monitoring for categorical features (i.e. Features with type (Feature.ValueType) BOOL or STRING). Structure is documented below.</summary>
    [JsonPropertyName("categoricalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigCategoricalThresholdConfig>? CategoricalThresholdConfig { get; set; }

    /// <summary>The config for ImportFeatures Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("importFeaturesAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigImportFeaturesAnalysis>? ImportFeaturesAnalysis { get; set; }

    /// <summary>Threshold for numerical features of anomaly detection. This is shared by all objectives of Featurestore Monitoring for numerical features (i.e. Features with type (Feature.ValueType) DOUBLE or INT64). Structure is documented below.</summary>
    [JsonPropertyName("numericalThresholdConfig")]
    public IList<V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigNumericalThresholdConfig>? NumericalThresholdConfig { get; set; }

    /// <summary>The config for Snapshot Analysis Based Feature Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("snapshotAnalysis")]
    public IList<V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfigSnapshotAnalysis>? SnapshotAnalysis { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusAtProvider
{
    /// <summary>The timestamp of when the featurestore was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Description of the EntityType.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.</summary>
    [JsonPropertyName("featurestore")]
    public string? Featurestore { get; set; }

    /// <summary>an identifier for the resource with format {{featurestore}}/entityTypes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this EntityType.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The default monitoring configuration for all Features under this EntityType. If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1FeaturestoreEntitytypeStatusAtProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The timestamp of when the featurestore was last updated in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatusConditions
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

/// <summary>FeaturestoreEntitytypeStatus defines the observed state of FeaturestoreEntitytype.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreEntitytypeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FeaturestoreEntitytypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FeaturestoreEntitytypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FeaturestoreEntitytype is the Schema for the FeaturestoreEntitytypes API. An entity type is a type of object in a system that needs to be modeled and have stored information about.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FeaturestoreEntitytype : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FeaturestoreEntitytypeSpec>, IStatus<V1beta1FeaturestoreEntitytypeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FeaturestoreEntitytype";
    public const string KubeGroup = "vertexai.gcp.upbound.io";
    public const string KubePluralName = "featurestoreentitytypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FeaturestoreEntitytypeSpec defines the desired state of FeaturestoreEntitytype</summary>
    [JsonPropertyName("spec")]
    public V1beta1FeaturestoreEntitytypeSpec Spec { get; set; }

    /// <summary>FeaturestoreEntitytypeStatus defines the observed state of FeaturestoreEntitytype.</summary>
    [JsonPropertyName("status")]
    public V1beta1FeaturestoreEntitytypeStatus? Status { get; set; }
}