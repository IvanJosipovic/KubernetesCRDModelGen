using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
public enum V1beta1NamespaceDisasterRecoveryConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecForProvider
{
    /// <summary>The Shared access policies used to access the connection string for the alias.</summary>
    [JsonPropertyName("aliasAuthorizationRuleId")]
    public string? AliasAuthorizationRuleId { get; set; }

    /// <summary>Reference to a NamespaceAuthorizationRule in servicebus to populate aliasAuthorizationRuleId.</summary>
    [JsonPropertyName("aliasAuthorizationRuleIdRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdRef? AliasAuthorizationRuleIdRef { get; set; }

    /// <summary>Selector for a NamespaceAuthorizationRule in servicebus to populate aliasAuthorizationRuleId.</summary>
    [JsonPropertyName("aliasAuthorizationRuleIdSelector")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderAliasAuthorizationRuleIdSelector? AliasAuthorizationRuleIdSelector { get; set; }

    /// <summary>The ID of the Service Bus Namespace to replicate to.</summary>
    [JsonPropertyName("partnerNamespaceId")]
    public string? PartnerNamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate partnerNamespaceId.</summary>
    [JsonPropertyName("partnerNamespaceIdRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdRef? PartnerNamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate partnerNamespaceId.</summary>
    [JsonPropertyName("partnerNamespaceIdSelector")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPartnerNamespaceIdSelector? PartnerNamespaceIdSelector { get; set; }

    /// <summary>The ID of the primary Service Bus Namespace to replicate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("primaryNamespaceId")]
    public string? PrimaryNamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate primaryNamespaceId.</summary>
    [JsonPropertyName("primaryNamespaceIdRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdRef? PrimaryNamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate primaryNamespaceId.</summary>
    [JsonPropertyName("primaryNamespaceIdSelector")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProviderPrimaryNamespaceIdSelector? PrimaryNamespaceIdSelector { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecInitProvider
{
    /// <summary>The Shared access policies used to access the connection string for the alias.</summary>
    [JsonPropertyName("aliasAuthorizationRuleId")]
    public string? AliasAuthorizationRuleId { get; set; }

    /// <summary>Reference to a NamespaceAuthorizationRule in servicebus to populate aliasAuthorizationRuleId.</summary>
    [JsonPropertyName("aliasAuthorizationRuleIdRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdRef? AliasAuthorizationRuleIdRef { get; set; }

    /// <summary>Selector for a NamespaceAuthorizationRule in servicebus to populate aliasAuthorizationRuleId.</summary>
    [JsonPropertyName("aliasAuthorizationRuleIdSelector")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderAliasAuthorizationRuleIdSelector? AliasAuthorizationRuleIdSelector { get; set; }

    /// <summary>The ID of the Service Bus Namespace to replicate to.</summary>
    [JsonPropertyName("partnerNamespaceId")]
    public string? PartnerNamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate partnerNamespaceId.</summary>
    [JsonPropertyName("partnerNamespaceIdRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdRef? PartnerNamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate partnerNamespaceId.</summary>
    [JsonPropertyName("partnerNamespaceIdSelector")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProviderPartnerNamespaceIdSelector? PartnerNamespaceIdSelector { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecManagementPoliciesEnum
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

public enum V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceDisasterRecoveryConfigSpecDeletionPolicyEnum>))]
    public V1beta1NamespaceDisasterRecoveryConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NamespaceDisasterRecoveryConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NamespaceDisasterRecoveryConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigStatusAtProvider
{
    /// <summary>The Shared access policies used to access the connection string for the alias.</summary>
    [JsonPropertyName("aliasAuthorizationRuleId")]
    public string? AliasAuthorizationRuleId { get; set; }

    /// <summary>The Service Bus Namespace Disaster Recovery Config ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Service Bus Namespace to replicate to.</summary>
    [JsonPropertyName("partnerNamespaceId")]
    public string? PartnerNamespaceId { get; set; }

    /// <summary>The ID of the primary Service Bus Namespace to replicate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("primaryNamespaceId")]
    public string? PrimaryNamespaceId { get; set; }
}

public partial class V1beta1NamespaceDisasterRecoveryConfigStatusConditions
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

public partial class V1beta1NamespaceDisasterRecoveryConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NamespaceDisasterRecoveryConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NamespaceDisasterRecoveryConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NamespaceDisasterRecoveryConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NamespaceDisasterRecoveryConfigSpec>, IStatus<V1beta1NamespaceDisasterRecoveryConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespaceDisasterRecoveryConfig";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "namespacedisasterrecoveryconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NamespaceDisasterRecoveryConfigSpec defines the desired state of NamespaceDisasterRecoveryConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1NamespaceDisasterRecoveryConfigSpec Spec { get; set; }

    /// <summary>NamespaceDisasterRecoveryConfigStatus defines the observed state of NamespaceDisasterRecoveryConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1NamespaceDisasterRecoveryConfigStatus? Status { get; set; }
}