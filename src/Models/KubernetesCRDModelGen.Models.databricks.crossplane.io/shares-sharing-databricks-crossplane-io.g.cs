using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sharing.databricks.crossplane.io;
/// <summary>Share is the Schema for the Shares API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ShareList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Share>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ShareList";
    public const string KubeGroup = "sharing.databricks.crossplane.io";
    public const string KubePluralName = "shares";
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
    public IList<V1alpha1Share> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecForProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient's property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecForProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareSpecForProviderObjectPartitionValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecForProviderObject
{
    /// <summary></summary>
    [JsonPropertyName("addedAt")]
    public double? AddedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addedBy")]
    public string? AddedBy { get; set; }

    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object, currently TABLE, VIEW, SCHEMA, VOLUME, and MODEL are supported.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareSpecForProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>Status of the object, one of: ACTIVE, PERMISSION_DENIED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecForProvider
{
    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time when the share was created.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>The principal that created the share.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("object")]
    public IList<V1alpha1ShareSpecForProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecInitProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient's property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecInitProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareSpecInitProviderObjectPartitionValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecInitProviderObject
{
    /// <summary></summary>
    [JsonPropertyName("addedAt")]
    public double? AddedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addedBy")]
    public string? AddedBy { get; set; }

    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object, currently TABLE, VIEW, SCHEMA, VOLUME, and MODEL are supported.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareSpecInitProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>Status of the object, one of: ACTIVE, PERMISSION_DENIED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecInitProvider
{
    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time when the share was created.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>The principal that created the share.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("object")]
    public IList<V1alpha1ShareSpecInitProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecProviderConfigRefPolicy
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
public partial class V1alpha1ShareSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ShareSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ShareSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1ShareSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ShareSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ShareSpec defines the desired state of Share</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1ShareSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1ShareSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ShareSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1ShareSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ShareSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatusAtProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient's property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatusAtProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareStatusAtProviderObjectPartitionValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatusAtProviderObject
{
    /// <summary></summary>
    [JsonPropertyName("addedAt")]
    public double? AddedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addedBy")]
    public string? AddedBy { get; set; }

    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object, currently TABLE, VIEW, SCHEMA, VOLUME, and MODEL are supported.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareStatusAtProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>Status of the object, one of: ACTIVE, PERMISSION_DENIED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A user-provided new name for the data object within the share. If this new name is not provided, the object's original name will be used as the shared_as name. The shared_as name must be unique within a Share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatusAtProvider
{
    /// <summary>Description about the object.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time when the share was created.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>The principal that created the share.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>the ID of the share, the same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("object")]
    public IList<V1alpha1ShareStatusAtProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatusConditions
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

/// <summary>ShareStatus defines the observed state of Share.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ShareStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ShareStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ShareStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Share is the Schema for the Shares API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Share : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ShareSpec>, IStatus<V1alpha1ShareStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Share";
    public const string KubeGroup = "sharing.databricks.crossplane.io";
    public const string KubePluralName = "shares";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ShareSpec defines the desired state of Share</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ShareSpec Spec { get; set; }

    /// <summary>ShareStatus defines the observed state of Share.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ShareStatus? Status { get; set; }
}