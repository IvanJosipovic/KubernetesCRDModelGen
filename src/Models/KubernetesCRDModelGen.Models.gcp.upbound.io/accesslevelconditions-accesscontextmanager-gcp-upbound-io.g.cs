using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolveEnum
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
public partial class V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderAccessLevelSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelConditionSpecForProviderDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProviderVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelConditionSpecForProviderVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecForProvider
{
    /// <summary>The name of the Access Level to add this condition to.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta1AccessLevelConditionSpecForProviderAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelConditionSpecForProviderDevicePolicy>? DevicePolicy { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>An allowed list of members (users, service accounts). Using groups is not supported yet. The signed-in user originating the request must be a part of one of the provided members. If not specified, a request may come from any user (logged in/not logged in, not present in any groups, etc.). Formats: user:{emailid}, serviceAccount:{emailid}</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>A list of other access levels defined in the same Policy, referenced by resource name. Referencing an AccessLevel which does not exist is an error. All access levels listed must be granted for the Condition to be true. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1AccessLevelConditionSpecForProviderVpcNetworkSources>? VpcNetworkSources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolveEnum
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
public partial class V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelConditionSpecInitProviderDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProviderVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelConditionSpecInitProviderVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecInitProvider
{
    /// <summary>The name of the Access Level to add this condition to.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta1AccessLevelConditionSpecInitProviderAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelConditionSpecInitProviderDevicePolicy>? DevicePolicy { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>An allowed list of members (users, service accounts). Using groups is not supported yet. The signed-in user originating the request must be a part of one of the provided members. If not specified, a request may come from any user (logged in/not logged in, not present in any groups, etc.). Formats: user:{emailid}, serviceAccount:{emailid}</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>A list of other access levels defined in the same Policy, referenced by resource name. Referencing an AccessLevel which does not exist is an error. All access levels listed must be granted for the Condition to be true. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1AccessLevelConditionSpecInitProviderVpcNetworkSources>? VpcNetworkSources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1AccessLevelConditionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AccessLevelConditionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccessLevelConditionSpec defines the desired state of AccessLevelCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessLevelConditionSpecDeletionPolicyEnum>))]
    public V1beta1AccessLevelConditionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccessLevelConditionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccessLevelConditionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AccessLevelConditionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccessLevelConditionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccessLevelConditionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccessLevelConditionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusAtProviderDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusAtProviderDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelConditionStatusAtProviderDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusAtProviderVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusAtProviderVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelConditionStatusAtProviderVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusAtProvider
{
    /// <summary>The name of the Access Level to add this condition to.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelConditionStatusAtProviderDevicePolicy>? DevicePolicy { get; set; }

    /// <summary>an identifier for the resource with format {{access_level}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.</summary>
    [JsonPropertyName("ipSubnetworks")]
    public IList<string>? IpSubnetworks { get; set; }

    /// <summary>An allowed list of members (users, service accounts). Using groups is not supported yet. The signed-in user originating the request must be a part of one of the provided members. If not specified, a request may come from any user (logged in/not logged in, not present in any groups, etc.). Formats: user:{emailid}, serviceAccount:{emailid}</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The request must originate from one of the provided countries/regions. Format: A valid ISO 3166-1 alpha-2 code.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>A list of other access levels defined in the same Policy, referenced by resource name. Referencing an AccessLevel which does not exist is an error. All access levels listed must be granted for the Condition to be true. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("requiredAccessLevels")]
    public IList<string>? RequiredAccessLevels { get; set; }

    /// <summary>The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field together with ip_subnetworks. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1AccessLevelConditionStatusAtProviderVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatusConditions
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

/// <summary>AccessLevelConditionStatus defines the observed state of AccessLevelCondition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelConditionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccessLevelConditionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessLevelConditionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccessLevelCondition is the Schema for the AccessLevelConditions API. Allows configuring a single access level condition to be appended to an access level's conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessLevelCondition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessLevelConditionSpec>, IStatus<V1beta1AccessLevelConditionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessLevelCondition";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "accesslevelconditions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessLevelConditionSpec defines the desired state of AccessLevelCondition</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessLevelConditionSpec Spec { get; set; }

    /// <summary>AccessLevelConditionStatus defines the observed state of AccessLevelCondition.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessLevelConditionStatus? Status { get; set; }
}