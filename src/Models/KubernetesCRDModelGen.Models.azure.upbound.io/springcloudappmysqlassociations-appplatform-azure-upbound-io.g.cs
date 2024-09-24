using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
public enum V1beta1SpringCloudAppMySQLAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in dbformysql to populate databaseName.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in dbformysql to populate databaseName.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Server in dbformysql to populate mysqlServerId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Server in dbformysql to populate mysqlServerId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the password which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Server in dbformysql to populate username.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Server in dbformysql to populate username.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecForProvider
{
    /// <summary>Specifies the name of the MySQL Database which the Spring Cloud App should be associated with.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a Database in dbformysql to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a Database in dbformysql to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>Specifies the ID of the MySQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mysqlServerId")]
    public string? MysqlServerId { get; set; }

    /// <summary>Reference to a Server in dbformysql to populate mysqlServerId.</summary>
    [JsonPropertyName("mysqlServerIdRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdRef? MysqlServerIdRef { get; set; }

    /// <summary>Selector for a Server in dbformysql to populate mysqlServerId.</summary>
    [JsonPropertyName("mysqlServerIdSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderMysqlServerIdSelector? MysqlServerIdSelector { get; set; }

    /// <summary>Specifies the password which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Specifies the ID of the Spring Cloud Application where this Association is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdRef? SpringCloudAppIdRef { get; set; }

    /// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderSpringCloudAppIdSelector? SpringCloudAppIdSelector { get; set; }

    /// <summary>Specifies the username which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a Server in dbformysql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a Server in dbformysql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProviderUsernameSelector? UsernameSelector { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in dbformysql to populate databaseName.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in dbformysql to populate databaseName.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Server in dbformysql to populate mysqlServerId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Server in dbformysql to populate mysqlServerId.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the password which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Server in dbformysql to populate username.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Server in dbformysql to populate username.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecInitProvider
{
    /// <summary>Specifies the name of the MySQL Database which the Spring Cloud App should be associated with.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a Database in dbformysql to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a Database in dbformysql to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>Specifies the ID of the MySQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mysqlServerId")]
    public string? MysqlServerId { get; set; }

    /// <summary>Reference to a Server in dbformysql to populate mysqlServerId.</summary>
    [JsonPropertyName("mysqlServerIdRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdRef? MysqlServerIdRef { get; set; }

    /// <summary>Selector for a Server in dbformysql to populate mysqlServerId.</summary>
    [JsonPropertyName("mysqlServerIdSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderMysqlServerIdSelector? MysqlServerIdSelector { get; set; }

    /// <summary>Specifies the password which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Specifies the username which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a Server in dbformysql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a Server in dbformysql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProviderUsernameSelector? UsernameSelector { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecManagementPoliciesEnum
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

public enum V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpringCloudAppMySQLAssociationSpec defines the desired state of SpringCloudAppMySQLAssociation</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppMySQLAssociationSpecDeletionPolicyEnum>))]
    public V1beta1SpringCloudAppMySQLAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudAppMySQLAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudAppMySQLAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudAppMySQLAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpringCloudAppMySQLAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudAppMySQLAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpringCloudAppMySQLAssociationStatusAtProvider
{
    /// <summary>Specifies the name of the MySQL Database which the Spring Cloud App should be associated with.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ID of the Spring Cloud Application MySQL Association.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the ID of the MySQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mysqlServerId")]
    public string? MysqlServerId { get; set; }

    /// <summary>Specifies the ID of the Spring Cloud Application where this Association is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Specifies the username which should be used when connecting to the MySQL Database from the Spring Cloud App.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationStatusConditions
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

/// <summary>SpringCloudAppMySQLAssociationStatus defines the observed state of SpringCloudAppMySQLAssociation.</summary>
public partial class V1beta1SpringCloudAppMySQLAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudAppMySQLAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudAppMySQLAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SpringCloudAppMySQLAssociation is the Schema for the SpringCloudAppMySQLAssociations API. Associates a</summary>
public partial class V1beta1SpringCloudAppMySQLAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudAppMySQLAssociationSpec>, IStatus<V1beta1SpringCloudAppMySQLAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAppMySQLAssociation";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudappmysqlassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudAppMySQLAssociationSpec defines the desired state of SpringCloudAppMySQLAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudAppMySQLAssociationSpec Spec { get; set; }

    /// <summary>SpringCloudAppMySQLAssociationStatus defines the observed state of SpringCloudAppMySQLAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudAppMySQLAssociationStatus? Status { get; set; }
}