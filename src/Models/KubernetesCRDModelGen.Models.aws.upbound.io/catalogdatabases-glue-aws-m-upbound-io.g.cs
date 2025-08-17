using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.m.upbound.io;
#nullable enable
/// <summary>CatalogDatabase is the Schema for the CatalogDatabases API. Provides a Glue Catalog Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CatalogDatabase>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogDatabaseList";
    public const string KubeGroup = "glue.aws.m.upbound.io";
    public const string KubePluralName = "catalogdatabases";
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
    public IList<V1beta1CatalogDatabase> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The principal who is granted permissions.. See principal below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecForProviderCreateTableDefaultPermissionPrincipal
{
    /// <summary>An identifier for the Lake Formation principal.</summary>
    [JsonPropertyName("dataLakePrincipalIdentifier")]
    public string? DataLakePrincipalIdentifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecForProviderCreateTableDefaultPermission
{
    /// <summary>The permissions that are granted to the principal.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The principal who is granted permissions.. See principal below.</summary>
    [JsonPropertyName("principal")]
    public V1beta1CatalogDatabaseSpecForProviderCreateTableDefaultPermissionPrincipal? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecForProviderFederatedDatabase
{
    /// <summary>Name of the connection to the external metastore.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Unique identifier for the federated database.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecForProviderTargetDatabase
{
    /// <summary>ID of the Data Catalog in which the database resides.</summary>
    [JsonPropertyName("catalogId")]
    public string CatalogId { get; set; }

    /// <summary>Name of the catalog database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Region of the target database.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecForProvider
{
    /// <summary>ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.</summary>
    [JsonPropertyName("catalogId")]
    public string CatalogId { get; set; }

    /// <summary>Creates a set of default permissions on the table for principals. See create_table_default_permission below.</summary>
    [JsonPropertyName("createTableDefaultPermission")]
    public IList<V1beta1CatalogDatabaseSpecForProviderCreateTableDefaultPermission>? CreateTableDefaultPermission { get; set; }

    /// <summary>Description of the database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
    [JsonPropertyName("federatedDatabase")]
    public V1beta1CatalogDatabaseSpecForProviderFederatedDatabase? FederatedDatabase { get; set; }

    /// <summary>Location of the database (for example, an HDFS path).</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>List of key-value pairs that define parameters and properties of the database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
    [JsonPropertyName("targetDatabase")]
    public V1beta1CatalogDatabaseSpecForProviderTargetDatabase? TargetDatabase { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The principal who is granted permissions.. See principal below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecInitProviderCreateTableDefaultPermissionPrincipal
{
    /// <summary>An identifier for the Lake Formation principal.</summary>
    [JsonPropertyName("dataLakePrincipalIdentifier")]
    public string? DataLakePrincipalIdentifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecInitProviderCreateTableDefaultPermission
{
    /// <summary>The permissions that are granted to the principal.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The principal who is granted permissions.. See principal below.</summary>
    [JsonPropertyName("principal")]
    public V1beta1CatalogDatabaseSpecInitProviderCreateTableDefaultPermissionPrincipal? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecInitProviderFederatedDatabase
{
    /// <summary>Name of the connection to the external metastore.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Unique identifier for the federated database.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecInitProviderTargetDatabase
{
    /// <summary>Name of the catalog database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecInitProvider
{
    /// <summary>Creates a set of default permissions on the table for principals. See create_table_default_permission below.</summary>
    [JsonPropertyName("createTableDefaultPermission")]
    public IList<V1beta1CatalogDatabaseSpecInitProviderCreateTableDefaultPermission>? CreateTableDefaultPermission { get; set; }

    /// <summary>Description of the database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
    [JsonPropertyName("federatedDatabase")]
    public V1beta1CatalogDatabaseSpecInitProviderFederatedDatabase? FederatedDatabase { get; set; }

    /// <summary>Location of the database (for example, an HDFS path).</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>List of key-value pairs that define parameters and properties of the database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
    [JsonPropertyName("targetDatabase")]
    public V1beta1CatalogDatabaseSpecInitProviderTargetDatabase? TargetDatabase { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CatalogDatabaseSpec defines the desired state of CatalogDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CatalogDatabaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CatalogDatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CatalogDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CatalogDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The principal who is granted permissions.. See principal below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusAtProviderCreateTableDefaultPermissionPrincipal
{
    /// <summary>An identifier for the Lake Formation principal.</summary>
    [JsonPropertyName("dataLakePrincipalIdentifier")]
    public string? DataLakePrincipalIdentifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusAtProviderCreateTableDefaultPermission
{
    /// <summary>The permissions that are granted to the principal.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The principal who is granted permissions.. See principal below.</summary>
    [JsonPropertyName("principal")]
    public V1beta1CatalogDatabaseStatusAtProviderCreateTableDefaultPermissionPrincipal? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusAtProviderFederatedDatabase
{
    /// <summary>Name of the connection to the external metastore.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Unique identifier for the federated database.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusAtProviderTargetDatabase
{
    /// <summary>ID of the Data Catalog in which the database resides.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the catalog database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Region of the target database.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusAtProvider
{
    /// <summary>ARN of the Glue Catalog Database.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Creates a set of default permissions on the table for principals. See create_table_default_permission below.</summary>
    [JsonPropertyName("createTableDefaultPermission")]
    public IList<V1beta1CatalogDatabaseStatusAtProviderCreateTableDefaultPermission>? CreateTableDefaultPermission { get; set; }

    /// <summary>Description of the database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block that references an entity outside the AWS Glue Data Catalog. See federated_database below.</summary>
    [JsonPropertyName("federatedDatabase")]
    public V1beta1CatalogDatabaseStatusAtProviderFederatedDatabase? FederatedDatabase { get; set; }

    /// <summary>Catalog ID and name of the database.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location of the database (for example, an HDFS path).</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>List of key-value pairs that define parameters and properties of the database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for a target database for resource linking. See target_database below.</summary>
    [JsonPropertyName("targetDatabase")]
    public V1beta1CatalogDatabaseStatusAtProviderTargetDatabase? TargetDatabase { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatusConditions
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
/// <summary>CatalogDatabaseStatus defines the observed state of CatalogDatabase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogDatabaseStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CatalogDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CatalogDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CatalogDatabase is the Schema for the CatalogDatabases API. Provides a Glue Catalog Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CatalogDatabaseSpec>, IStatus<V1beta1CatalogDatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogDatabase";
    public const string KubeGroup = "glue.aws.m.upbound.io";
    public const string KubePluralName = "catalogdatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CatalogDatabaseSpec defines the desired state of CatalogDatabase</summary>
    [JsonPropertyName("spec")]
    public V1beta1CatalogDatabaseSpec Spec { get; set; }

    /// <summary>CatalogDatabaseStatus defines the observed state of CatalogDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta1CatalogDatabaseStatus? Status { get; set; }
}
#nullable disable
