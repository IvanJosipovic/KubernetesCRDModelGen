using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groups.azuread.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecForProviderDynamicMembership
{
    /// <summary>Whether rule processing is "On" (true) or "Paused" (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The rule that determines membership of this group. For more information, see official documentation on membership rules syntax. Rule to determine members for a dynamic group. Required when `group_types` contains 'DynamicMembership'</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecForProvider
{
    /// <summary>The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level. The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.</summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created. Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.</summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups. Indicates whether new members added to the group will be auto-subscribed to receive email notifications.</summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created. The group behaviours for a Microsoft 365 group</summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>The description for the group. The description for the group</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for the group. The display name for the group</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property. An optional block to configure dynamic membership for the group. Cannot be used with `members`</summary>
    [JsonPropertyName("dynamicMembership")]
    public IList<V1beta1GroupSpecForProviderDynamicMembership>? DynamicMembership { get; set; }

    /// <summary>Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups. Indicates whether people external to the organization can send messages to the group.</summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups. Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.</summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups. Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.</summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    /// <summary>Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property). Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled</summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created. The mail alias for the group, unique in the organisation</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block. A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup. Indicates the target on-premise group type the group will be written back as</summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed. A set of owners who own this group. Supported object types are Users or Service Principals</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>If true, will return an error if an existing group is found with the same name. Defaults to false. If `true`, will return an error if an existing group is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created. The group provisioning options for a Microsoft 365 group</summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property). Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled</summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set. The colour theme for a Microsoft 365 group</summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created. A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility. Specifies the group join policy and group content visibility</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used. Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecInitProviderDynamicMembership
{
    /// <summary>Whether rule processing is "On" (true) or "Paused" (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The rule that determines membership of this group. For more information, see official documentation on membership rules syntax. Rule to determine members for a dynamic group. Required when `group_types` contains 'DynamicMembership'</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecInitProvider
{
    /// <summary>The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level. The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.</summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created. Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.</summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups. Indicates whether new members added to the group will be auto-subscribed to receive email notifications.</summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created. The group behaviours for a Microsoft 365 group</summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>The description for the group. The description for the group</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for the group. The display name for the group</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property. An optional block to configure dynamic membership for the group. Cannot be used with `members`</summary>
    [JsonPropertyName("dynamicMembership")]
    public IList<V1beta1GroupSpecInitProviderDynamicMembership>? DynamicMembership { get; set; }

    /// <summary>Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups. Indicates whether people external to the organization can send messages to the group.</summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups. Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.</summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups. Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.</summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    /// <summary>Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property). Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled</summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created. The mail alias for the group, unique in the organisation</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block. A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup. Indicates the target on-premise group type the group will be written back as</summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed. A set of owners who own this group. Supported object types are Users or Service Principals</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>If true, will return an error if an existing group is found with the same name. Defaults to false. If `true`, will return an error if an existing group is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created. The group provisioning options for a Microsoft 365 group</summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property). Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled</summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set. The colour theme for a Microsoft 365 group</summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created. A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility. Specifies the group join policy and group content visibility</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used. Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1GroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1GroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1GroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1GroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1GroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>GroupSpec defines the desired state of Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecDeletionPolicyEnum>))]
    public V1beta1GroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1GroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusAtProviderDynamicMembership
{
    /// <summary>Whether rule processing is "On" (true) or "Paused" (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The rule that determines membership of this group. For more information, see official documentation on membership rules syntax. Rule to determine members for a dynamic group. Required when `group_types` contains 'DynamicMembership'</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusAtProvider
{
    /// <summary>The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level. The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.</summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created. Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.</summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups. Indicates whether new members added to the group will be auto-subscribed to receive email notifications.</summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created. The group behaviours for a Microsoft 365 group</summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>The description for the group. The description for the group</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for the group. The display name for the group</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property. An optional block to configure dynamic membership for the group. Cannot be used with `members`</summary>
    [JsonPropertyName("dynamicMembership")]
    public IList<V1beta1GroupStatusAtProviderDynamicMembership>? DynamicMembership { get; set; }

    /// <summary>Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups. Indicates whether people external to the organization can send messages to the group.</summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups. Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.</summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups. Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.</summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The SMTP address for the group. The SMTP address for the group</summary>
    [JsonPropertyName("mail")]
    public string? Mail { get; set; }

    /// <summary>Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property). Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled</summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created. The mail alias for the group, unique in the organisation</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block. A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The object ID of the group. The object ID of the group</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The on-premises FQDN, also called dnsDomainName, synchronised from the on-premises directory when Azure AD Connect is used. The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("onpremisesDomainName")]
    public string? OnpremisesDomainName { get; set; }

    /// <summary>The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup. Indicates the target on-premise group type the group will be written back as</summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>The on-premises NetBIOS name, synchronised from the on-premises directory when Azure AD Connect is used. The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("onpremisesNetbiosName")]
    public string? OnpremisesNetbiosName { get; set; }

    /// <summary>The on-premises SAM account name, synchronised from the on-premises directory when Azure AD Connect is used. The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("onpremisesSamAccountName")]
    public string? OnpremisesSamAccountName { get; set; }

    /// <summary>The on-premises security identifier (SID), synchronised from the on-premises directory when Azure AD Connect is used. The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("onpremisesSecurityIdentifier")]
    public string? OnpremisesSecurityIdentifier { get; set; }

    /// <summary>Whether this group is synchronised from an on-premises directory (true), no longer synchronised (false), or has never been synchronised (null). Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)</summary>
    [JsonPropertyName("onpremisesSyncEnabled")]
    public bool? OnpremisesSyncEnabled { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed. A set of owners who own this group. Supported object types are Users or Service Principals</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>The preferred language for a Microsoft 365 group, in ISO 639-1 notation. The preferred language for a Microsoft 365 group, in ISO 639-1 notation</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>If true, will return an error if an existing group is found with the same name. Defaults to false. If `true`, will return an error if an existing group is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created. The group provisioning options for a Microsoft 365 group</summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>List of email addresses for the group that direct to the same group mailbox. Email addresses for the group that direct to the same group mailbox</summary>
    [JsonPropertyName("proxyAddresses")]
    public IList<string>? ProxyAddresses { get; set; }

    /// <summary>Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property). Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled</summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set. The colour theme for a Microsoft 365 group</summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created. A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility. Specifies the group join policy and group content visibility</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used. Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used</summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusConditions
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

/// <summary>GroupStatus defines the observed state of Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Group is the Schema for the Groups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Group : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GroupSpec>, IStatus<V1beta1GroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Group";
    public const string KubeGroup = "groups.azuread.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GroupSpec defines the desired state of Group</summary>
    [JsonPropertyName("spec")]
    public V1beta1GroupSpec Spec { get; set; }

    /// <summary>GroupStatus defines the observed state of Group.</summary>
    [JsonPropertyName("status")]
    public V1beta1GroupStatus? Status { get; set; }
}