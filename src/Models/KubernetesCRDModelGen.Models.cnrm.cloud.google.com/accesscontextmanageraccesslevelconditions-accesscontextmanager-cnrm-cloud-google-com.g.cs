using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionSpecAccessLevelRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionSpecDevicePolicyOsConstraints
{
    /// <summary>Immutable. The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>Immutable. The operating system type of the device. Possible values: ["OS_UNSPECIFIED", "DESKTOP_MAC", "DESKTOP_WINDOWS", "DESKTOP_LINUX", "DESKTOP_CHROME_OS", "ANDROID", "IOS"].</summary>
    [JsonPropertyName("osType")]
    public string OsType { get; set; }
}

/// <summary>Immutable. Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionSpecDevicePolicy
{
    /// <summary>Immutable. A list of allowed device management levels. An empty list allows all management levels. Possible values: ["MANAGEMENT_UNSPECIFIED", "NONE", "BASIC", "COMPLETE"].</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>Immutable. A list of allowed encryptions statuses. An empty list allows all statuses. Possible values: ["ENCRYPTION_UNSPECIFIED", "ENCRYPTION_UNSUPPORTED", "UNENCRYPTED", "ENCRYPTED"].</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>Immutable. A list of allowed OS versions. An empty list allows all types and all versions.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1alpha1AccessContextManagerAccessLevelConditionSpecDevicePolicyOsConstraints>? OsConstraints { get; set; }

    /// <summary>Immutable. Whether the device needs to be approved by the customer admin.</summary>
    [JsonPropertyName("requireAdminApproval")]
    public bool? RequireAdminApproval { get; set; }

    /// <summary>Immutable. Whether the device needs to be corp owned.</summary>
    [JsonPropertyName("requireCorpOwned")]
    public bool? RequireCorpOwned { get; set; }

    /// <summary>Immutable. Whether or not screenlock is required for the DevicePolicy to be true. Defaults to false.</summary>
    [JsonPropertyName("requireScreenLock")]
    public bool? RequireScreenLock { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionSpec
{
    /// <summary></summary>
    [JsonPropertyName("accessLevelRef")]
    public V1alpha1AccessContextManagerAccessLevelConditionSpecAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Immutable. Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed.</summary>
    [JsonPropertyName("devicePolicy")]
    public V1alpha1AccessContextManagerAccessLevelConditionSpecDevicePolicy? DevicePolicy { get; set; }

    /// <summary>Immutable. A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>Immutable. An allowed list of members (users, service accounts). Using groups is not supported yet.  The signed-in user originating the request must be a part of one of the provided members. If not specified, a request may come from any user (logged in/not logged in, not present in any groups, etc.). Formats: 'user:{emailid}', 'serviceAccount:{emailid}'.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Immutable. Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>Immutable. The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Immutable. A list of other access levels defined in the same Policy, referenced by resource name. Referencing an AccessLevel which does not exist is an error. All access levels listed must be granted for the Condition to be true. Format: accessPolicies/{policy_id}/accessLevels/{short_name}.</summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>Immutable. Optional. The accessLevel of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerAccessLevelConditionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AccessContextManagerAccessLevelConditionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessContextManagerAccessLevelCondition : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccessContextManagerAccessLevelConditionSpec>, IStatus<V1alpha1AccessContextManagerAccessLevelConditionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessContextManagerAccessLevelCondition";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesslevelconditions";
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
    public V1alpha1AccessContextManagerAccessLevelConditionSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AccessContextManagerAccessLevelConditionStatus? Status { get; set; }
}