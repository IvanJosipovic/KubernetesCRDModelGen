using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backup.aws.upbound.io;
#nullable enable
/// <summary>ReportPlan is the Schema for the ReportPlans API. Provides an AWS Backup Report Plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReportPlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReportPlan>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReportPlanList";
    public const string KubeGroup = "backup.aws.upbound.io";
    public const string KubePluralName = "reportplans";
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
    public IList<V1beta1ReportPlan> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecForProviderReportDeliveryChannel
{
    /// <summary>A list of the format of your reports: CSV, JSON, or both. If not specified, the default format is CSV.</summary>
    [JsonPropertyName("formats")]
    public IList<string>? Formats { get; set; }

    /// <summary>The unique name of the S3 bucket that receives your reports.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The prefix is this part of the following path: s3://your-bucket-name/prefix/Backup/us-west-2/year/month/day/report-name. If not specified, there is no prefix.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecForProviderReportSetting
{
    /// <summary>Specifies the list of accounts a report covers.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>Specifies the Amazon Resource Names (ARNs) of the frameworks a report covers.</summary>
    [JsonPropertyName("frameworkArns")]
    public IList<string>? FrameworkArns { get; set; }

    /// <summary>Specifies the number of frameworks a report covers.</summary>
    [JsonPropertyName("numberOfFrameworks")]
    public double? NumberOfFrameworks { get; set; }

    /// <summary>Specifies the list of Organizational Units a report covers.</summary>
    [JsonPropertyName("organizationUnits")]
    public IList<string>? OrganizationUnits { get; set; }

    /// <summary>Specifies the list of regions a report covers.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Identifies the report template for the report. Reports are built using a report template. The report templates are: RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT | RESTORE_JOB_REPORT.</summary>
    [JsonPropertyName("reportTemplate")]
    public string? ReportTemplate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecForProvider
{
    /// <summary>The description of the report plan with a maximum of 1,024 characters</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique name of the report plan. The name must be between 1 and 256 characters, starting with a letter, and consisting of letters, numbers, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>An object that contains information about where and how to deliver your reports, specifically your Amazon S3 bucket name, S3 key prefix, and the formats of your reports. Detailed below.</summary>
    [JsonPropertyName("reportDeliveryChannel")]
    public IList<V1beta1ReportPlanSpecForProviderReportDeliveryChannel>? ReportDeliveryChannel { get; set; }

    /// <summary>An object that identifies the report template for the report. Reports are built using a report template. Detailed below.</summary>
    [JsonPropertyName("reportSetting")]
    public IList<V1beta1ReportPlanSpecForProviderReportSetting>? ReportSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecInitProviderReportDeliveryChannel
{
    /// <summary>A list of the format of your reports: CSV, JSON, or both. If not specified, the default format is CSV.</summary>
    [JsonPropertyName("formats")]
    public IList<string>? Formats { get; set; }

    /// <summary>The unique name of the S3 bucket that receives your reports.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The prefix is this part of the following path: s3://your-bucket-name/prefix/Backup/us-west-2/year/month/day/report-name. If not specified, there is no prefix.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecInitProviderReportSetting
{
    /// <summary>Specifies the list of accounts a report covers.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>Specifies the Amazon Resource Names (ARNs) of the frameworks a report covers.</summary>
    [JsonPropertyName("frameworkArns")]
    public IList<string>? FrameworkArns { get; set; }

    /// <summary>Specifies the number of frameworks a report covers.</summary>
    [JsonPropertyName("numberOfFrameworks")]
    public double? NumberOfFrameworks { get; set; }

    /// <summary>Specifies the list of Organizational Units a report covers.</summary>
    [JsonPropertyName("organizationUnits")]
    public IList<string>? OrganizationUnits { get; set; }

    /// <summary>Specifies the list of regions a report covers.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Identifies the report template for the report. Reports are built using a report template. The report templates are: RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT | RESTORE_JOB_REPORT.</summary>
    [JsonPropertyName("reportTemplate")]
    public string? ReportTemplate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecInitProvider
{
    /// <summary>The description of the report plan with a maximum of 1,024 characters</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique name of the report plan. The name must be between 1 and 256 characters, starting with a letter, and consisting of letters, numbers, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An object that contains information about where and how to deliver your reports, specifically your Amazon S3 bucket name, S3 key prefix, and the formats of your reports. Detailed below.</summary>
    [JsonPropertyName("reportDeliveryChannel")]
    public IList<V1beta1ReportPlanSpecInitProviderReportDeliveryChannel>? ReportDeliveryChannel { get; set; }

    /// <summary>An object that identifies the report template for the report. Reports are built using a report template. Detailed below.</summary>
    [JsonPropertyName("reportSetting")]
    public IList<V1beta1ReportPlanSpecInitProviderReportSetting>? ReportSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReportPlanSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ReportPlanSpec defines the desired state of ReportPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReportPlanSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReportPlanSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReportPlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReportPlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanStatusAtProviderReportDeliveryChannel
{
    /// <summary>A list of the format of your reports: CSV, JSON, or both. If not specified, the default format is CSV.</summary>
    [JsonPropertyName("formats")]
    public IList<string>? Formats { get; set; }

    /// <summary>The unique name of the S3 bucket that receives your reports.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The prefix is this part of the following path: s3://your-bucket-name/prefix/Backup/us-west-2/year/month/day/report-name. If not specified, there is no prefix.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanStatusAtProviderReportSetting
{
    /// <summary>Specifies the list of accounts a report covers.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>Specifies the Amazon Resource Names (ARNs) of the frameworks a report covers.</summary>
    [JsonPropertyName("frameworkArns")]
    public IList<string>? FrameworkArns { get; set; }

    /// <summary>Specifies the number of frameworks a report covers.</summary>
    [JsonPropertyName("numberOfFrameworks")]
    public double? NumberOfFrameworks { get; set; }

    /// <summary>Specifies the list of Organizational Units a report covers.</summary>
    [JsonPropertyName("organizationUnits")]
    public IList<string>? OrganizationUnits { get; set; }

    /// <summary>Specifies the list of regions a report covers.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Identifies the report template for the report. Reports are built using a report template. The report templates are: RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT | RESTORE_JOB_REPORT.</summary>
    [JsonPropertyName("reportTemplate")]
    public string? ReportTemplate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanStatusAtProvider
{
    /// <summary>The ARN of the backup report plan.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The date and time that a report plan is created, in Unix format and Coordinated Universal Time (UTC).</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>The deployment status of a report plan. The statuses are: CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED.</summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>The description of the report plan with a maximum of 1,024 characters</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the backup report plan.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique name of the report plan. The name must be between 1 and 256 characters, starting with a letter, and consisting of letters, numbers, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>An object that contains information about where and how to deliver your reports, specifically your Amazon S3 bucket name, S3 key prefix, and the formats of your reports. Detailed below.</summary>
    [JsonPropertyName("reportDeliveryChannel")]
    public IList<V1beta1ReportPlanStatusAtProviderReportDeliveryChannel>? ReportDeliveryChannel { get; set; }

    /// <summary>An object that identifies the report template for the report. Reports are built using a report template. Detailed below.</summary>
    [JsonPropertyName("reportSetting")]
    public IList<V1beta1ReportPlanStatusAtProviderReportSetting>? ReportSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanStatusConditions
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
/// <summary>ReportPlanStatus defines the observed state of ReportPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReportPlanStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReportPlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReportPlanStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ReportPlan is the Schema for the ReportPlans API. Provides an AWS Backup Report Plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReportPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReportPlanSpec>, IStatus<V1beta1ReportPlanStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReportPlan";
    public const string KubeGroup = "backup.aws.upbound.io";
    public const string KubePluralName = "reportplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReportPlanSpec defines the desired state of ReportPlan</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReportPlanSpec Spec { get; set; }

    /// <summary>ReportPlanStatus defines the observed state of ReportPlan.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReportPlanStatus? Status { get; set; }
}
#nullable disable
