using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lakeformation.aws.m.upbound.io;
#nullable enable
/// <summary>DataLakeSettings is the Schema for the DataLakeSettingss API. Manages data lake administrators and default database and table permissions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataLakeSettingsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataLakeSettings>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataLakeSettingsList";
    public const string KubeGroup = "lakeformation.aws.m.upbound.io";
    public const string KubePluralName = "datalakesettings";
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
    public IList<V1beta1DataLakeSettings> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderAdminsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderAdminsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeSettingsSpecForProviderAdminsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderAdminsSelectorPolicy
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
/// <summary>Selector for a list of User in iam to populate admins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderAdminsSelector
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
    public V1beta1DataLakeSettingsSpecForProviderAdminsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecForProvider
{
    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>References to User in iam to populate admins.</summary>
    [JsonPropertyName("adminsRefs")]
    public IList<V1beta1DataLakeSettingsSpecForProviderAdminsRefs>? AdminsRefs { get; set; }

    /// <summary>Selector for a list of User in iam to populate admins.</summary>
    [JsonPropertyName("adminsSelector")]
    public V1beta1DataLakeSettingsSpecForProviderAdminsSelector? AdminsSelector { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Whether to allow a third-party query engine to get data access credentials without session tags when a caller has full data access permissions.</summary>
    [JsonPropertyName("allowFullTableExternalDataAccess")]
    public bool? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>Identifier for the Data Catalog. By default, the account ID.</summary>
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

    /// <summary>Key-value map of additional configuration. Valid values for the CROSS_ACCOUNT_VERSION key are "1", "2", "3", or "4". SET_CONTEXT is also returned with a value of TRUE. In a fresh account, prior to configuring, CROSS_ACCOUNT_VERSION is "1". Destroying this resource sets the CROSS_ACCOUNT_VERSION to "1".</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of the resource-owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderAdminsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderAdminsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeSettingsSpecInitProviderAdminsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderAdminsSelectorPolicy
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
/// <summary>Selector for a list of User in iam to populate admins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderAdminsSelector
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
    public V1beta1DataLakeSettingsSpecInitProviderAdminsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecInitProvider
{
    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>References to User in iam to populate admins.</summary>
    [JsonPropertyName("adminsRefs")]
    public IList<V1beta1DataLakeSettingsSpecInitProviderAdminsRefs>? AdminsRefs { get; set; }

    /// <summary>Selector for a list of User in iam to populate admins.</summary>
    [JsonPropertyName("adminsSelector")]
    public V1beta1DataLakeSettingsSpecInitProviderAdminsSelector? AdminsSelector { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Whether to allow a third-party query engine to get data access credentials without session tags when a caller has full data access permissions.</summary>
    [JsonPropertyName("allowFullTableExternalDataAccess")]
    public bool? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>Identifier for the Data Catalog. By default, the account ID.</summary>
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

    /// <summary>Key-value map of additional configuration. Valid values for the CROSS_ACCOUNT_VERSION key are "1", "2", "3", or "4". SET_CONTEXT is also returned with a value of TRUE. In a fresh account, prior to configuring, CROSS_ACCOUNT_VERSION is "1". Destroying this resource sets the CROSS_ACCOUNT_VERSION to "1".</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>List of the resource-owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpecProviderConfigRef
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
public partial class V1beta1DataLakeSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataLakeSettingsSpec defines the desired state of DataLakeSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataLakeSettingsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataLakeSettingsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataLakeSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataLakeSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsStatusAtProviderCreateDatabaseDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, DESCRIBE, and CREATE_TABLE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsStatusAtProviderCreateTableDefaultPermissions
{
    /// <summary>List of permissions that are granted to the principal. Valid values may include ALL, SELECT, ALTER, DROP, DELETE, INSERT, and DESCRIBE. For more details, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Principal who is granted permissions. To enforce metadata and underlying data access control only by IAM on new databases and tables set principal to IAM_ALLOWED_PRINCIPALS and permissions to ["ALL"].</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataLakeSettingsStatusAtProvider
{
    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles).</summary>
    [JsonPropertyName("admins")]
    public IList<string>? Admins { get; set; }

    /// <summary>Whether to allow Amazon EMR clusters to access data managed by Lake Formation.</summary>
    [JsonPropertyName("allowExternalDataFiltering")]
    public bool? AllowExternalDataFiltering { get; set; }

    /// <summary>Whether to allow a third-party query engine to get data access credentials without session tags when a caller has full data access permissions.</summary>
    [JsonPropertyName("allowFullTableExternalDataAccess")]
    public bool? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>Lake Formation relies on a privileged process secured by Amazon EMR or the third party integrator to tag the user's role while assuming it.</summary>
    [JsonPropertyName("authorizedSessionTagValueList")]
    public IList<string>? AuthorizedSessionTagValueList { get; set; }

    /// <summary>Identifier for the Data Catalog. By default, the account ID.</summary>
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

    /// <summary>Key-value map of additional configuration. Valid values for the CROSS_ACCOUNT_VERSION key are "1", "2", "3", or "4". SET_CONTEXT is also returned with a value of TRUE. In a fresh account, prior to configuring, CROSS_ACCOUNT_VERSION is "1". Destroying this resource sets the CROSS_ACCOUNT_VERSION to "1".</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of AWS Lake Formation principals (IAM users or roles) with only view access to the resources.</summary>
    [JsonPropertyName("readOnlyAdmins")]
    public IList<string>? ReadOnlyAdmins { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>List of the resource-owning account IDs that the caller's account can use to share their user access details (user ARNs).</summary>
    [JsonPropertyName("trustedResourceOwners")]
    public IList<string>? TrustedResourceOwners { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>DataLakeSettingsStatus defines the observed state of DataLakeSettings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>DataLakeSettings is the Schema for the DataLakeSettingss API. Manages data lake administrators and default database and table permissions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataLakeSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataLakeSettingsSpec>, IStatus<V1beta1DataLakeSettingsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataLakeSettings";
    public const string KubeGroup = "lakeformation.aws.m.upbound.io";
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
#nullable disable
