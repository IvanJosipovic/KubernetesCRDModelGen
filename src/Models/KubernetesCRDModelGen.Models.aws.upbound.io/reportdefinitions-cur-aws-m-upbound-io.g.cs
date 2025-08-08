using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cur.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecForProviderS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecForProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReportDefinitionSpecForProviderS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecForProviderS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecForProviderS3BucketSelector
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
    public V1beta1ReportDefinitionSpecForProviderS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecForProvider
{
    /// <summary>A list of additional artifacts. Valid values are: REDSHIFT, QUICKSIGHT, ATHENA. When ATHENA exists within additional_artifacts, no other artifact type can be declared and report_versioning must be OVERWRITE_REPORT.</summary>
    [JsonPropertyName("additionalArtifacts")]
    public IList<string>? AdditionalArtifacts { get; set; }

    /// <summary>A list of schema elements. Valid values are: RESOURCES, SPLIT_COST_ALLOCATION_DATA, MANUAL_DISCOUNT_COMPATIBILITY.</summary>
    [JsonPropertyName("additionalSchemaElements")]
    public IList<string>? AdditionalSchemaElements { get; set; }

    /// <summary>Compression format for report. Valid values are: GZIP, ZIP, Parquet. If Parquet is used, then format must also be Parquet.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Format for report. Valid values are: textORcsv, Parquet. If Parquet is used, then Compression must also be Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Set to true to update your reports after they have been finalized if AWS detects charges related to previous months.</summary>
    [JsonPropertyName("refreshClosedReports")]
    public bool? RefreshClosedReports { get; set; }

    /// <summary>Overwrite the previous version of each report or to deliver the report in addition to the previous versions. Valid values are: CREATE_NEW_REPORT and OVERWRITE_REPORT.</summary>
    [JsonPropertyName("reportVersioning")]
    public string? ReportVersioning { get; set; }

    /// <summary>Name of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1ReportDefinitionSpecForProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1ReportDefinitionSpecForProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>Report path prefix. Limited to 256 characters. May be empty ("") but the resource can then not be modified via the AWS Console.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }

    /// <summary>Region of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The frequency on which report data are measured and displayed.  Valid values are: DAILY, HOURLY, MONTHLY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecInitProviderS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecInitProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReportDefinitionSpecInitProviderS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecInitProviderS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecInitProviderS3BucketSelector
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
    public V1beta1ReportDefinitionSpecInitProviderS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecInitProvider
{
    /// <summary>A list of additional artifacts. Valid values are: REDSHIFT, QUICKSIGHT, ATHENA. When ATHENA exists within additional_artifacts, no other artifact type can be declared and report_versioning must be OVERWRITE_REPORT.</summary>
    [JsonPropertyName("additionalArtifacts")]
    public IList<string>? AdditionalArtifacts { get; set; }

    /// <summary>A list of schema elements. Valid values are: RESOURCES, SPLIT_COST_ALLOCATION_DATA, MANUAL_DISCOUNT_COMPATIBILITY.</summary>
    [JsonPropertyName("additionalSchemaElements")]
    public IList<string>? AdditionalSchemaElements { get; set; }

    /// <summary>Compression format for report. Valid values are: GZIP, ZIP, Parquet. If Parquet is used, then format must also be Parquet.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Format for report. Valid values are: textORcsv, Parquet. If Parquet is used, then Compression must also be Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Set to true to update your reports after they have been finalized if AWS detects charges related to previous months.</summary>
    [JsonPropertyName("refreshClosedReports")]
    public bool? RefreshClosedReports { get; set; }

    /// <summary>Overwrite the previous version of each report or to deliver the report in addition to the previous versions. Valid values are: CREATE_NEW_REPORT and OVERWRITE_REPORT.</summary>
    [JsonPropertyName("reportVersioning")]
    public string? ReportVersioning { get; set; }

    /// <summary>Name of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1ReportDefinitionSpecInitProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1ReportDefinitionSpecInitProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>Report path prefix. Limited to 256 characters. May be empty ("") but the resource can then not be modified via the AWS Console.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }

    /// <summary>Region of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The frequency on which report data are measured and displayed.  Valid values are: DAILY, HOURLY, MONTHLY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpecProviderConfigRef
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
public partial class V1beta1ReportDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ReportDefinitionSpec defines the desired state of ReportDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReportDefinitionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReportDefinitionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReportDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReportDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionStatusAtProvider
{
    /// <summary>A list of additional artifacts. Valid values are: REDSHIFT, QUICKSIGHT, ATHENA. When ATHENA exists within additional_artifacts, no other artifact type can be declared and report_versioning must be OVERWRITE_REPORT.</summary>
    [JsonPropertyName("additionalArtifacts")]
    public IList<string>? AdditionalArtifacts { get; set; }

    /// <summary>A list of schema elements. Valid values are: RESOURCES, SPLIT_COST_ALLOCATION_DATA, MANUAL_DISCOUNT_COMPATIBILITY.</summary>
    [JsonPropertyName("additionalSchemaElements")]
    public IList<string>? AdditionalSchemaElements { get; set; }

    /// <summary>The Amazon Resource Name (ARN) specifying the cur report.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Compression format for report. Valid values are: GZIP, ZIP, Parquet. If Parquet is used, then format must also be Parquet.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Format for report. Valid values are: textORcsv, Parquet. If Parquet is used, then Compression must also be Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Set to true to update your reports after they have been finalized if AWS detects charges related to previous months.</summary>
    [JsonPropertyName("refreshClosedReports")]
    public bool? RefreshClosedReports { get; set; }

    /// <summary>Overwrite the previous version of each report or to deliver the report in addition to the previous versions. Valid values are: CREATE_NEW_REPORT and OVERWRITE_REPORT.</summary>
    [JsonPropertyName("reportVersioning")]
    public string? ReportVersioning { get; set; }

    /// <summary>Name of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Report path prefix. Limited to 256 characters. May be empty ("") but the resource can then not be modified via the AWS Console.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }

    /// <summary>Region of the existing S3 bucket to hold generated reports.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The frequency on which report data are measured and displayed.  Valid values are: DAILY, HOURLY, MONTHLY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionStatusConditions
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

/// <summary>ReportDefinitionStatus defines the observed state of ReportDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportDefinitionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReportDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReportDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ReportDefinition is the Schema for the ReportDefinitions API. Provides a Cost and Usage Report Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReportDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReportDefinitionSpec>, IStatus<V1beta1ReportDefinitionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReportDefinition";
    public const string KubeGroup = "cur.aws.m.upbound.io";
    public const string KubePluralName = "reportdefinitions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReportDefinitionSpec defines the desired state of ReportDefinition</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReportDefinitionSpec Spec { get; set; }

    /// <summary>ReportDefinitionStatus defines the observed state of ReportDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReportDefinitionStatus? Status { get; set; }
}

/// <summary>ReportDefinition is the Schema for the ReportDefinitions API. Provides a Cost and Usage Report Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReportDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReportDefinition>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReportDefinitionList";
    public const string KubeGroup = "cur.aws.m.upbound.io";
    public const string KubePluralName = "reportdefinitions";
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
    public IList<V1beta1ReportDefinition> Items { get; set; }
}