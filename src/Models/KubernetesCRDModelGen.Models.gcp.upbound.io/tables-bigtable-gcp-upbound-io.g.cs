using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.gcp.upbound.io;
/// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderAutomatedBackupPolicy
{
    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPeriod")]
    public string? RetentionPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderColumnFamily
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>The type of the column family.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderInstanceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderInstanceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderInstanceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderInstanceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderInstanceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderInstanceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProvider
{
    /// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
    [JsonPropertyName("automatedBackupPolicy")]
    public V1beta1TableSpecForProviderAutomatedBackupPolicy? AutomatedBackupPolicy { get; set; }

    /// <summary>Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.</summary>
    [JsonPropertyName("changeStreamRetention")]
    public string? ChangeStreamRetention { get; set; }

    /// <summary>A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableSpecForProviderColumnFamily>? ColumnFamily { get; set; }

    /// <summary>A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, deletion protection will be set to UNPROTECTED.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>The name of the Bigtable instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameRef")]
    public V1beta1TableSpecForProviderInstanceNameRef? InstanceNameRef { get; set; }

    /// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameSelector")]
    public V1beta1TableSpecForProviderInstanceNameSelector? InstanceNameSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowKeySchema")]
    public string? RowKeySchema { get; set; }

    /// <summary>A list of predefined keys to split the table on.</summary>
    [JsonPropertyName("splitKeys")]
    public IList<string>? SplitKeys { get; set; }
}

/// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderAutomatedBackupPolicy
{
    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPeriod")]
    public string? RetentionPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderColumnFamily
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>The type of the column family.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProvider
{
    /// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
    [JsonPropertyName("automatedBackupPolicy")]
    public V1beta1TableSpecInitProviderAutomatedBackupPolicy? AutomatedBackupPolicy { get; set; }

    /// <summary>Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.</summary>
    [JsonPropertyName("changeStreamRetention")]
    public string? ChangeStreamRetention { get; set; }

    /// <summary>A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableSpecInitProviderColumnFamily>? ColumnFamily { get; set; }

    /// <summary>A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, deletion protection will be set to UNPROTECTED.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowKeySchema")]
    public string? RowKeySchema { get; set; }

    /// <summary>A list of predefined keys to split the table on.</summary>
    [JsonPropertyName("splitKeys")]
    public IList<string>? SplitKeys { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecProviderConfigRefPolicy
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
public partial class V1beta1TableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1TableSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TableSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TableSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TableSpec defines the desired state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TableSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderAutomatedBackupPolicy
{
    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPeriod")]
    public string? RetentionPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderColumnFamily
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>The type of the column family.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProvider
{
    /// <summary>Defines an automated backup policy for a table, specified by Retention Period and Frequency. To create a table with automated backup disabled, either omit the automated_backup_policy argument, or set both Retention Period and Frequency properties to "0". To disable automated backup on an existing table that has automated backup enabled, set both Retention Period and Frequency properties to "0". When updating an existing table, to modify the Retention Period or Frequency properties of the resource's automated backup policy, set the respective property to a non-zero value. If the automated_backup_policy argument is not provided in the configuration on update, the resource's automated backup policy will not be modified.</summary>
    [JsonPropertyName("automatedBackupPolicy")]
    public V1beta1TableStatusAtProviderAutomatedBackupPolicy? AutomatedBackupPolicy { get; set; }

    /// <summary>Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.</summary>
    [JsonPropertyName("changeStreamRetention")]
    public string? ChangeStreamRetention { get; set; }

    /// <summary>A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableStatusAtProviderColumnFamily>? ColumnFamily { get; set; }

    /// <summary>A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, deletion protection will be set to UNPROTECTED.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/instances/{{instance_name}}/tables/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Bigtable instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowKeySchema")]
    public string? RowKeySchema { get; set; }

    /// <summary>A list of predefined keys to split the table on.</summary>
    [JsonPropertyName("splitKeys")]
    public IList<string>? SplitKeys { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusConditions
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

/// <summary>TableStatus defines the observed state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Creates a Google Cloud Bigtable table inside an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TableSpec>, IStatus<V1beta1TableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "bigtable.gcp.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TableSpec defines the desired state of Table</summary>
    [JsonPropertyName("spec")]
    public V1beta1TableSpec Spec { get; set; }

    /// <summary>TableStatus defines the observed state of Table.</summary>
    [JsonPropertyName("status")]
    public V1beta1TableStatus? Status { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Creates a Google Cloud Bigtable table inside an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Table>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "bigtable.gcp.upbound.io";
    public const string KubePluralName = "tables";
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
    public IList<V1beta1Table> Items { get; set; }
}