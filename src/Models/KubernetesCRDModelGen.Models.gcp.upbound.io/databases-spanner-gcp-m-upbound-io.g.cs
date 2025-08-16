using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.gcp.m.upbound.io;
/// <summary>Database is the Schema for the Databases API. A Cloud Spanner Database which is hosted on a Spanner instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Database>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatabaseList";
    public const string KubeGroup = "spanner.gcp.m.upbound.io";
    public const string KubePluralName = "databases";
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
    public IList<V1beta1Database> Items { get; set; }
}

/// <summary>Encryption configuration for the database Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderEncryptionConfig
{
    /// <summary>Fully qualified name of the KMS key to use to encrypt this database. This key must exist in the same location as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist in the same locations as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderInstanceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in spanner to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseSpecForProviderInstanceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderInstanceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in spanner to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderInstanceSelector
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
    public V1beta1DatabaseSpecForProviderInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProvider
{
    /// <summary>The dialect of the Cloud Spanner Database. If it is not provided, "GOOGLE_STANDARD_SQL" will be used. Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.</summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>An optional list of DDL statements to run inside the database. Statements can create tables, indexes, etc. During creation these statements execute atomically with the creation of the database and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and newly appended DDL statements can be executed in an update. However, modifications to prior statements will create a plan that marks the resource for recreation.</summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>The default time zone for the database. The default time zone must be a valid name from the tz database. Default value is "America/Los_angeles".</summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>Defaults to true. When the field is set to false, deleting the database is allowed.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Whether drop protection is enabled for this database. Defaults to false. whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces. (2) Setting "enableDropProtection" to true also prevents the deletion of the parent instance containing the database. "deletion_protection" attribute does not provide protection against the deletion of the parent instance.</summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>Encryption configuration for the database Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1DatabaseSpecForProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The instance to create the database on.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in spanner to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1DatabaseSpecForProviderInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in spanner to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1DatabaseSpecForProviderInstanceSelector? InstanceSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The retention period for the database. The retention period must be between 1 hour and 7 days, and can be specified in days, hours, minutes, or seconds. For example, the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h. If this property is used, you must avoid adding new DDL statements to ddl that update the database's version_retention_period.</summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>Encryption configuration for the database Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderEncryptionConfig
{
    /// <summary>Fully qualified name of the KMS key to use to encrypt this database. This key must exist in the same location as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist in the same locations as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProvider
{
    /// <summary>The dialect of the Cloud Spanner Database. If it is not provided, "GOOGLE_STANDARD_SQL" will be used. Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.</summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>An optional list of DDL statements to run inside the database. Statements can create tables, indexes, etc. During creation these statements execute atomically with the creation of the database and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and newly appended DDL statements can be executed in an update. However, modifications to prior statements will create a plan that marks the resource for recreation.</summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>The default time zone for the database. The default time zone must be a valid name from the tz database. Default value is "America/Los_angeles".</summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>Defaults to true. When the field is set to false, deleting the database is allowed.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Whether drop protection is enabled for this database. Defaults to false. whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces. (2) Setting "enableDropProtection" to true also prevents the deletion of the parent instance containing the database. "deletion_protection" attribute does not provide protection against the deletion of the parent instance.</summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>Encryption configuration for the database Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1DatabaseSpecInitProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The retention period for the database. The retention period must be between 1 hour and 7 days, and can be specified in days, hours, minutes, or seconds. For example, the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h. If this property is used, you must avoid adding new DDL statements to ddl that update the database's version_retention_period.</summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecProviderConfigRef
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
public partial class V1beta1DatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DatabaseSpec defines the desired state of Database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatabaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Encryption configuration for the database Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusAtProviderEncryptionConfig
{
    /// <summary>Fully qualified name of the KMS key to use to encrypt this database. This key must exist in the same location as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist in the same locations as the Spanner Database.</summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusAtProvider
{
    /// <summary>The dialect of the Cloud Spanner Database. If it is not provided, "GOOGLE_STANDARD_SQL" will be used. Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.</summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>An optional list of DDL statements to run inside the database. Statements can create tables, indexes, etc. During creation these statements execute atomically with the creation of the database and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and newly appended DDL statements can be executed in an update. However, modifications to prior statements will create a plan that marks the resource for recreation.</summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>The default time zone for the database. The default time zone must be a valid name from the tz database. Default value is "America/Los_angeles".</summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>Defaults to true. When the field is set to false, deleting the database is allowed.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Whether drop protection is enabled for this database. Defaults to false. whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces. (2) Setting "enableDropProtection" to true also prevents the deletion of the parent instance containing the database. "deletion_protection" attribute does not provide protection against the deletion of the parent instance.</summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>Encryption configuration for the database Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1DatabaseStatusAtProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>an identifier for the resource with format {{instance}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The instance to create the database on.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An explanation of the status of the database.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The retention period for the database. The retention period must be between 1 hour and 7 days, and can be specified in days, hours, minutes, or seconds. For example, the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h. If this property is used, you must avoid adding new DDL statements to ddl that update the database's version_retention_period.</summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusConditions
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

/// <summary>DatabaseStatus defines the observed state of Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Database is the Schema for the Databases API. A Cloud Spanner Database which is hosted on a Spanner instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Database : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatabaseSpec>, IStatus<V1beta1DatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Database";
    public const string KubeGroup = "spanner.gcp.m.upbound.io";
    public const string KubePluralName = "databases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseSpec defines the desired state of Database</summary>
    [JsonPropertyName("spec")]
    public V1beta1DatabaseSpec Spec { get; set; }

    /// <summary>DatabaseStatus defines the observed state of Database.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatabaseStatus? Status { get; set; }
}