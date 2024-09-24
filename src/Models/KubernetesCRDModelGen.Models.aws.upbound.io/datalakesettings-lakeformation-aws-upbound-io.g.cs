using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lakeformation.aws.upbound.io;
public enum V1beta1DataLakeSettingsSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsSpecForProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsSpecForProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsSpecForProvider
{
    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>–  Identifier for the Data Catalog. By default, the account ID.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create database permissions. Detailed below.</summary>
    [JsonPropertyName("createDatabaseDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsSpecForProviderCreateDatabaseDefaultPermissions>? CreateDatabaseDefaultPermissions { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create table permissions. Detailed below.</summary>
    [JsonPropertyName("createTableDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsSpecForProviderCreateTableDefaultPermissions>? CreateTableDefaultPermissions { get; set; }

    /// <summary>A list of the account IDs of Amazon Web Services accounts with Amazon EMR clusters that are to perform data filtering.</summary>
    [JsonPropertyName("externalDataFilteringAllowList")]
    public IList<string>? ExternalDataFilteringAllowList { get; set; }

    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsSpecInitProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsSpecInitProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DataLakeSettingsSpecInitProvider
{
    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>–  Identifier for the Data Catalog. By default, the account ID.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create database permissions. Detailed below.</summary>
    [JsonPropertyName("createDatabaseDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsSpecInitProviderCreateDatabaseDefaultPermissions>? CreateDatabaseDefaultPermissions { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create table permissions. Detailed below.</summary>
    [JsonPropertyName("createTableDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsSpecInitProviderCreateTableDefaultPermissions>? CreateTableDefaultPermissions { get; set; }

    /// <summary>A list of the account IDs of Amazon Web Services accounts with Amazon EMR clusters that are to perform data filtering.</summary>
    [JsonPropertyName("externalDataFilteringAllowList")]
    public IList<string>? ExternalDataFilteringAllowList { get; set; }

    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}

public enum V1beta1DataLakeSettingsSpecManagementPoliciesEnum
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

public enum V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeSettingsSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DataLakeSettingsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DataLakeSettingsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeSettingsSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DataLakeSettingsSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DataLakeSettingsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DataLakeSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataLakeSettingsSpec defines the desired state of DataLakeSettings</summary>
public partial class V1beta1DataLakeSettingsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeSettingsSpecDeletionPolicyEnum>))]
    public V1beta1DataLakeSettingsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataLakeSettingsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataLakeSettingsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DataLakeSettingsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataLakeSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DataLakeSettingsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataLakeSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsStatusAtProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsStatusAtProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeSettingsStatusAtProvider
{
    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>–  Identifier for the Data Catalog. By default, the account ID.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create database permissions. Detailed below.</summary>
    [JsonPropertyName("createDatabaseDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsStatusAtProviderCreateDatabaseDefaultPermissions>? CreateDatabaseDefaultPermissions { get; set; }

    /// <summary>Up to three configuration blocks of principal permissions for default create table permissions. Detailed below.</summary>
    [JsonPropertyName("createTableDefaultPermissions")]
    public IList<V1beta1DataLakeSettingsStatusAtProviderCreateTableDefaultPermissions>? CreateTableDefaultPermissions { get; set; }

    /// <summary>A list of the account IDs of Amazon Web Services accounts with Amazon EMR clusters that are to perform data filtering.</summary>
    [JsonPropertyName("externalDataFilteringAllowList")]
    public IList<string>? ExternalDataFilteringAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>–  Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DataLakeSettingsStatusConditions
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

/// <summary>DataLakeSettingsStatus defines the observed state of DataLakeSettings.</summary>
public partial class V1beta1DataLakeSettingsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataLakeSettingsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataLakeSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>DataLakeSettings is the Schema for the DataLakeSettingss API. Manages data lake administrators and default database and table permissions</summary>
public partial class V1beta1DataLakeSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataLakeSettingsSpec>, IStatus<V1beta1DataLakeSettingsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataLakeSettings";
    public const string KubeGroup = "lakeformation.aws.upbound.io";
    public const string KubePluralName = "datalakesettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLakeSettingsSpec defines the desired state of DataLakeSettings</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataLakeSettingsSpec Spec { get; set; }

    /// <summary>DataLakeSettingsStatus defines the observed state of DataLakeSettings.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataLakeSettingsStatus? Status { get; set; }
}