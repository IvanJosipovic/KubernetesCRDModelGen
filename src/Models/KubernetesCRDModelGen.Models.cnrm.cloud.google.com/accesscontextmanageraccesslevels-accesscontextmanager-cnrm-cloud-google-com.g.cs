using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerAccessLevel lives in.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecAccessPolicyRef
{
    /// <summary>Allowed value: string of the format `accessPolicies/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values: ["OS_UNSPECIFIED", "DESKTOP_MAC", "DESKTOP_WINDOWS", "DESKTOP_LINUX", "DESKTOP_CHROME_OS", "ANDROID", "IOS"].</summary>
    [JsonPropertyName("osType")]
    public string OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}

/// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Possible values: ["MANAGEMENT_UNSPECIFIED", "NONE", "BASIC", "COMPLETE"].</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Possible values: ["ENCRYPTION_UNSPECIFIED", "ENCRYPTION_UNSUPPORTED", "UNENCRYPTED", "ENCRYPTED"].</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>Whether or not screenlock is required for the DevicePolicy to be true. Defaults to false.</summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembersServiceAccountRef
{
    /// <summary>Allowed value: string of the format `serviceAccount:{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>An allowed list of members (users, service accounts). Using groups is not supported.  The signed-in user originating the request must be a part of one of the provided members. If not specified, a request may come from any user (logged in/not logged in, not present in any groups, etc.).</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembers
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembersServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>A list of other access levels defined in the same policy. Referencing an AccessContextManagerAccessLevel which does not exist is an error. All access levels listed must be granted for the condition to be true.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditionsRequiredAccessLevels
{
    /// <summary>Allowed value: The `name` field of an `AccessContextManagerAccessLevel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasicConditions
{
    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
    [JsonPropertyName("devicePolicy")]
    public V1beta1AccessContextManagerAccessLevelSpecBasicConditionsDevicePolicy? DevicePolicy { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("members")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsMembers>? Members { get; set; }

    /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditionsRequiredAccessLevels>? RequiredAccessLevels { get; set; }
}

/// <summary>A set of predefined conditions for the access level and a combining function.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecBasic
{
    /// <summary>How the conditions list should be combined to determine if a request is granted this AccessLevel. If AND is used, each Condition in conditions must be satisfied for the AccessLevel to be applied. If OR is used, at least one Condition in conditions must be satisfied for the AccessLevel to be applied. Default value: "AND" Possible values: ["AND", "OR"].</summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>A set of requirements for the AccessLevel to be granted.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerAccessLevelSpecBasicConditions> Conditions { get; set; }
}

/// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecCustomExpr
{
    /// <summary>Description of the expression.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec.</summary>
public partial class V1beta1AccessContextManagerAccessLevelSpecCustom
{
    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec.</summary>
    [JsonPropertyName("expr")]
    public V1beta1AccessContextManagerAccessLevelSpecCustomExpr Expr { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelSpec
{
    /// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerAccessLevel lives in.</summary>
    [JsonPropertyName("accessPolicyRef")]
    public V1beta1AccessContextManagerAccessLevelSpecAccessPolicyRef AccessPolicyRef { get; set; }

    /// <summary>A set of predefined conditions for the access level and a combining function.</summary>
    [JsonPropertyName("basic")]
    public V1beta1AccessContextManagerAccessLevelSpecBasic? Basic { get; set; }

    /// <summary>Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec.</summary>
    [JsonPropertyName("custom")]
    public V1beta1AccessContextManagerAccessLevelSpecCustom? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevelStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerAccessLevelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1AccessContextManagerAccessLevel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessContextManagerAccessLevelSpec>, IStatus<V1beta1AccessContextManagerAccessLevelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerAccessLevel";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesslevels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessContextManagerAccessLevelSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerAccessLevelStatus? Status { get; set; }
}