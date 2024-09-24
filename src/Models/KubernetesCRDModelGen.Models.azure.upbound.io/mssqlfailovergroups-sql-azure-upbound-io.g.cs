using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.upbound.io;
public enum V1beta1MSSQLFailoverGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefsPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderPartnerServer
{
    /// <summary>The ID of a partner SQL server to include in the failover group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a MSSQLServer in sql to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdRef? IdRef { get; set; }

    /// <summary>Selector for a MSSQLServer in sql to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1MSSQLFailoverGroupSpecForProviderPartnerServerIdSelector? IdSelector { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>The grace period in minutes, before failover with data loss is attempted for the read-write endpoint. Required when mode is Automatic.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover policy of the read-write endpoint for the failover group. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecForProvider
{
    /// <summary>A set of database names to include in the failover group.</summary>
    [JsonPropertyName("databases")]
    public IList<string>? Databases { get; set; }

    /// <summary>References to MSSQLDatabase in sql to populate databases.</summary>
    [JsonPropertyName("databasesRefs")]
    public IList<V1beta1MSSQLFailoverGroupSpecForProviderDatabasesRefs>? DatabasesRefs { get; set; }

    /// <summary>Selector for a list of MSSQLDatabase in sql to populate databases.</summary>
    [JsonPropertyName("databasesSelector")]
    public V1beta1MSSQLFailoverGroupSpecForProviderDatabasesSelector? DatabasesSelector { get; set; }

    /// <summary>A partner_server block as defined below.</summary>
    [JsonPropertyName("partnerServer")]
    public IList<V1beta1MSSQLFailoverGroupSpecForProviderPartnerServer>? PartnerServer { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public IList<V1beta1MSSQLFailoverGroupSpecForProviderReadWriteEndpointFailoverPolicy>? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Whether failover is enabled for the readonly endpoint. Defaults to false.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>The ID of the primary SQL Server on which to create the failover group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serverId")]
    public string? ServerId { get; set; }

    /// <summary>Reference to a MSSQLServer in sql to populate serverId.</summary>
    [JsonPropertyName("serverIdRef")]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdRef? ServerIdRef { get; set; }

    /// <summary>Selector for a MSSQLServer in sql to populate serverId.</summary>
    [JsonPropertyName("serverIdSelector")]
    public V1beta1MSSQLFailoverGroupSpecForProviderServerIdSelector? ServerIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefsPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServer
{
    /// <summary>The ID of a partner SQL server to include in the failover group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a MSSQLServer in sql to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdRef? IdRef { get; set; }

    /// <summary>Selector for a MSSQLServer in sql to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServerIdSelector? IdSelector { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>The grace period in minutes, before failover with data loss is attempted for the read-write endpoint. Required when mode is Automatic.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover policy of the read-write endpoint for the failover group. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecInitProvider
{
    /// <summary>A set of database names to include in the failover group.</summary>
    [JsonPropertyName("databases")]
    public IList<string>? Databases { get; set; }

    /// <summary>References to MSSQLDatabase in sql to populate databases.</summary>
    [JsonPropertyName("databasesRefs")]
    public IList<V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesRefs>? DatabasesRefs { get; set; }

    /// <summary>Selector for a list of MSSQLDatabase in sql to populate databases.</summary>
    [JsonPropertyName("databasesSelector")]
    public V1beta1MSSQLFailoverGroupSpecInitProviderDatabasesSelector? DatabasesSelector { get; set; }

    /// <summary>A partner_server block as defined below.</summary>
    [JsonPropertyName("partnerServer")]
    public IList<V1beta1MSSQLFailoverGroupSpecInitProviderPartnerServer>? PartnerServer { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public IList<V1beta1MSSQLFailoverGroupSpecInitProviderReadWriteEndpointFailoverPolicy>? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Whether failover is enabled for the readonly endpoint. Defaults to false.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecManagementPoliciesEnum
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

public enum V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLFailoverGroupSpecDeletionPolicyEnum>))]
    public V1beta1MSSQLFailoverGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLFailoverGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLFailoverGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MSSQLFailoverGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLFailoverGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MSSQLFailoverGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLFailoverGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupStatusAtProviderPartnerServer
{
    /// <summary>The ID of a partner SQL server to include in the failover group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the partner server.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The replication role of the partner server. Possible values include Primary or Secondary.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupStatusAtProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>The grace period in minutes, before failover with data loss is attempted for the read-write endpoint. Required when mode is Automatic.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover policy of the read-write endpoint for the failover group. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupStatusAtProvider
{
    /// <summary>A set of database names to include in the failover group.</summary>
    [JsonPropertyName("databases")]
    public IList<string>? Databases { get; set; }

    /// <summary>The ID of the Failover Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A partner_server block as defined below.</summary>
    [JsonPropertyName("partnerServer")]
    public IList<V1beta1MSSQLFailoverGroupStatusAtProviderPartnerServer>? PartnerServer { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public IList<V1beta1MSSQLFailoverGroupStatusAtProviderReadWriteEndpointFailoverPolicy>? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Whether failover is enabled for the readonly endpoint. Defaults to false.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>The ID of the primary SQL Server on which to create the failover group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serverId")]
    public string? ServerId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1beta1MSSQLFailoverGroupStatusConditions
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

public partial class V1beta1MSSQLFailoverGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLFailoverGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLFailoverGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLFailoverGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLFailoverGroupSpec>, IStatus<V1beta1MSSQLFailoverGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLFailoverGroup";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlfailovergroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLFailoverGroupSpec defines the desired state of MSSQLFailoverGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLFailoverGroupSpec Spec { get; set; }

    /// <summary>MSSQLFailoverGroupStatus defines the observed state of MSSQLFailoverGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLFailoverGroupStatus? Status { get; set; }
}