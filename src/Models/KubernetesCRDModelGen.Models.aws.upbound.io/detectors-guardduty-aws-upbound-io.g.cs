using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.guardduty.aws.upbound.io;
public enum V1beta1DetectorSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesKubernetesAuditLogs
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesKubernetes
{
    /// <summary>Configures Kubernetes audit logs as a data source for Kubernetes protection. See Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("auditLogs")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesKubernetesAuditLogs>? AuditLogs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings
{
    /// <summary>Configure whether scanning EBS volumes is enabled as data source for the detector for instances with findings. See EBS volumes below for more details.</summary>
    [JsonPropertyName("ebsVolumes")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes>? EbsVolumes { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesMalwareProtection
{
    /// <summary>Configure whether Malware Protection is enabled as data source for EC2 instances with findings for the detector. See Scan EC2 instance with findings below for more details.</summary>
    [JsonPropertyName("scanEc2InstanceWithFindings")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings>? ScanEc2InstanceWithFindings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasourcesS3Logs
{
    /// <summary>If true, enables S3 protection. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProviderDatasources
{
    /// <summary>Configures Kubernetes protection. See Kubernetes and Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("kubernetes")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesKubernetes>? Kubernetes { get; set; }

    /// <summary>Configures Malware Protection. See Malware Protection, Scan EC2 instance with findings and EBS volumes below for more details.</summary>
    [JsonPropertyName("malwareProtection")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesMalwareProtection>? MalwareProtection { get; set; }

    /// <summary>Configures S3 protection. See S3 Logs below for more details.</summary>
    [JsonPropertyName("s3Logs")]
    public IList<V1beta1DetectorSpecForProviderDatasourcesS3Logs>? S3Logs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecForProvider
{
    /// <summary>Describes which data sources will be enabled for the detector. See Data Sources below for more details. Deprecated in favor of aws_guardduty_detector_feature resources.</summary>
    [JsonPropertyName("datasources")]
    public IList<V1beta1DetectorSpecForProviderDatasources>? Datasources { get; set; }

    /// <summary>Enable monitoring and feedback reporting. Setting to false is equivalent to "suspending" GuardDuty. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty primary account and cannot be modified, otherwise defaults to SIX_HOURS. Valid values for standalone and primary accounts: FIFTEEN_MINUTES, ONE_HOUR, SIX_HOURS. See AWS Documentation for more information.</summary>
    [JsonPropertyName("findingPublishingFrequency")]
    public string? FindingPublishingFrequency { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesKubernetesAuditLogs
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesKubernetes
{
    /// <summary>Configures Kubernetes audit logs as a data source for Kubernetes protection. See Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("auditLogs")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesKubernetesAuditLogs>? AuditLogs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings
{
    /// <summary>Configure whether scanning EBS volumes is enabled as data source for the detector for instances with findings. See EBS volumes below for more details.</summary>
    [JsonPropertyName("ebsVolumes")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes>? EbsVolumes { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesMalwareProtection
{
    /// <summary>Configure whether Malware Protection is enabled as data source for EC2 instances with findings for the detector. See Scan EC2 instance with findings below for more details.</summary>
    [JsonPropertyName("scanEc2InstanceWithFindings")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings>? ScanEc2InstanceWithFindings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasourcesS3Logs
{
    /// <summary>If true, enables S3 protection. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorSpecInitProviderDatasources
{
    /// <summary>Configures Kubernetes protection. See Kubernetes and Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("kubernetes")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesKubernetes>? Kubernetes { get; set; }

    /// <summary>Configures Malware Protection. See Malware Protection, Scan EC2 instance with findings and EBS volumes below for more details.</summary>
    [JsonPropertyName("malwareProtection")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesMalwareProtection>? MalwareProtection { get; set; }

    /// <summary>Configures S3 protection. See S3 Logs below for more details.</summary>
    [JsonPropertyName("s3Logs")]
    public IList<V1beta1DetectorSpecInitProviderDatasourcesS3Logs>? S3Logs { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DetectorSpecInitProvider
{
    /// <summary>Describes which data sources will be enabled for the detector. See Data Sources below for more details. Deprecated in favor of aws_guardduty_detector_feature resources.</summary>
    [JsonPropertyName("datasources")]
    public IList<V1beta1DetectorSpecInitProviderDatasources>? Datasources { get; set; }

    /// <summary>Enable monitoring and feedback reporting. Setting to false is equivalent to "suspending" GuardDuty. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty primary account and cannot be modified, otherwise defaults to SIX_HOURS. Valid values for standalone and primary accounts: FIFTEEN_MINUTES, ONE_HOUR, SIX_HOURS. See AWS Documentation for more information.</summary>
    [JsonPropertyName("findingPublishingFrequency")]
    public string? FindingPublishingFrequency { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1DetectorSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1DetectorSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DetectorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DetectorSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DetectorSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DetectorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DetectorSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DetectorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DetectorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DetectorSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DetectorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DetectorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DetectorSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1DetectorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DetectorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DetectorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DetectorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DetectorSpec defines the desired state of Detector</summary>
public partial class V1beta1DetectorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DetectorSpecDeletionPolicyEnum>))]
    public V1beta1DetectorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DetectorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DetectorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DetectorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DetectorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DetectorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DetectorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesKubernetesAuditLogs
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesKubernetes
{
    /// <summary>Configures Kubernetes audit logs as a data source for Kubernetes protection. See Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("auditLogs")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesKubernetesAuditLogs>? AuditLogs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes
{
    /// <summary>If true, enables Malware Protection as data source for the detector. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings
{
    /// <summary>Configure whether scanning EBS volumes is enabled as data source for the detector for instances with findings. See EBS volumes below for more details.</summary>
    [JsonPropertyName("ebsVolumes")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindingsEbsVolumes>? EbsVolumes { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesMalwareProtection
{
    /// <summary>Configure whether Malware Protection is enabled as data source for EC2 instances with findings for the detector. See Scan EC2 instance with findings below for more details.</summary>
    [JsonPropertyName("scanEc2InstanceWithFindings")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesMalwareProtectionScanEc2InstanceWithFindings>? ScanEc2InstanceWithFindings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasourcesS3Logs
{
    /// <summary>If true, enables S3 protection. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProviderDatasources
{
    /// <summary>Configures Kubernetes protection. See Kubernetes and Kubernetes Audit Logs below for more details.</summary>
    [JsonPropertyName("kubernetes")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesKubernetes>? Kubernetes { get; set; }

    /// <summary>Configures Malware Protection. See Malware Protection, Scan EC2 instance with findings and EBS volumes below for more details.</summary>
    [JsonPropertyName("malwareProtection")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesMalwareProtection>? MalwareProtection { get; set; }

    /// <summary>Configures S3 protection. See S3 Logs below for more details.</summary>
    [JsonPropertyName("s3Logs")]
    public IList<V1beta1DetectorStatusAtProviderDatasourcesS3Logs>? S3Logs { get; set; }
}

/// <summary></summary>
public partial class V1beta1DetectorStatusAtProvider
{
    /// <summary>The AWS account ID of the GuardDuty detector</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the GuardDuty detector</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Describes which data sources will be enabled for the detector. See Data Sources below for more details. Deprecated in favor of aws_guardduty_detector_feature resources.</summary>
    [JsonPropertyName("datasources")]
    public IList<V1beta1DetectorStatusAtProviderDatasources>? Datasources { get; set; }

    /// <summary>Enable monitoring and feedback reporting. Setting to false is equivalent to "suspending" GuardDuty. Defaults to true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty primary account and cannot be modified, otherwise defaults to SIX_HOURS. Valid values for standalone and primary accounts: FIFTEEN_MINUTES, ONE_HOUR, SIX_HOURS. See AWS Documentation for more information.</summary>
    [JsonPropertyName("findingPublishingFrequency")]
    public string? FindingPublishingFrequency { get; set; }

    /// <summary>The ID of the GuardDuty detector</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DetectorStatusConditions
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

/// <summary>DetectorStatus defines the observed state of Detector.</summary>
public partial class V1beta1DetectorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DetectorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DetectorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Detector is the Schema for the Detectors API. Provides a resource to manage an Amazon GuardDuty detector</summary>
public partial class V1beta1Detector : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DetectorSpec>, IStatus<V1beta1DetectorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Detector";
    public const string KubeGroup = "guardduty.aws.upbound.io";
    public const string KubePluralName = "detectors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DetectorSpec defines the desired state of Detector</summary>
    [JsonPropertyName("spec")]
    public V1beta1DetectorSpec Spec { get; set; }

    /// <summary>DetectorStatus defines the observed state of Detector.</summary>
    [JsonPropertyName("status")]
    public V1beta1DetectorStatus? Status { get; set; }
}