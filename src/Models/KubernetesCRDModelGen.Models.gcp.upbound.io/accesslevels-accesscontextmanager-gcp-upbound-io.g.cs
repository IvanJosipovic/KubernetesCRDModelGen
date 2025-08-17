using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.gcp.upbound.io;
#nullable enable
/// <summary>AccessLevel is the Schema for the AccessLevels API. An AccessLevel is a label that can be applied to requests to GCP services, along with a list of requirements necessary for the label to be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessLevelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccessLevel>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessLevelList";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "accesslevels";
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
    public IList<V1beta1AccessLevel> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasicConditionsDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelSpecForProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasicConditionsVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelSpecForProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasicConditions
{
    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelSpecForProviderBasicConditionsDevicePolicy>? DevicePolicy { get; set; }

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
    public IList<V1beta1AccessLevelSpecForProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderBasic
{
    /// <summary>How the conditions list should be combined to determine if a request is granted this AccessLevel. If AND is used, each Condition in conditions must be satisfied for the AccessLevel to be applied. If OR is used, at least one Condition in conditions must be satisfied for the AccessLevel to be applied. Default value is AND. Possible values are: AND, OR.</summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>A set of requirements for the AccessLevel to be granted. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessLevelSpecForProviderBasicConditions>? Conditions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProviderCustom
{
    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1AccessLevelSpecForProviderCustomExpr>? Expr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecForProvider
{
    /// <summary>A set of predefined conditions for the access level and a combining function. Structure is documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1AccessLevelSpecForProviderBasic>? Basic { get; set; }

    /// <summary>Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec. Structure is documented below.</summary>
    [JsonPropertyName("custom")]
    public IList<V1beta1AccessLevelSpecForProviderCustom>? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Resource name for the Access Level. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this AccessLevel lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasicConditionsDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelSpecInitProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasicConditionsVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelSpecInitProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasicConditions
{
    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelSpecInitProviderBasicConditionsDevicePolicy>? DevicePolicy { get; set; }

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
    public IList<V1beta1AccessLevelSpecInitProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderBasic
{
    /// <summary>How the conditions list should be combined to determine if a request is granted this AccessLevel. If AND is used, each Condition in conditions must be satisfied for the AccessLevel to be applied. If OR is used, at least one Condition in conditions must be satisfied for the AccessLevel to be applied. Default value is AND. Possible values are: AND, OR.</summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>A set of requirements for the AccessLevel to be granted. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessLevelSpecInitProviderBasicConditions>? Conditions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProviderCustom
{
    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1AccessLevelSpecInitProviderCustomExpr>? Expr { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecInitProvider
{
    /// <summary>A set of predefined conditions for the access level and a combining function. Structure is documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1AccessLevelSpecInitProviderBasic>? Basic { get; set; }

    /// <summary>Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec. Structure is documented below.</summary>
    [JsonPropertyName("custom")]
    public IList<V1beta1AccessLevelSpecInitProviderCustom>? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Resource name for the Access Level. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this AccessLevel lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessLevelSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AccessLevelSpec defines the desired state of AccessLevel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccessLevelSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccessLevelSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccessLevelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccessLevelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasicConditionsDevicePolicyOsConstraints
{
    /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format: "major.minor.patch" such as "10.5.301", "9.2.1".</summary>
    [JsonPropertyName("minimumVersion")]
    public string? MinimumVersion { get; set; }

    /// <summary>The operating system type of the device. Possible values are: OS_UNSPECIFIED, DESKTOP_MAC, DESKTOP_WINDOWS, DESKTOP_LINUX, DESKTOP_CHROME_OS, ANDROID, IOS.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.</summary>
    [JsonPropertyName("requireVerifiedChromeOs")]
    public bool? RequireVerifiedChromeOs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasicConditionsDevicePolicy
{
    /// <summary>A list of allowed device management levels. An empty list allows all management levels. Each value may be one of: MANAGEMENT_UNSPECIFIED, NONE, BASIC, COMPLETE.</summary>
    [JsonPropertyName("allowedDeviceManagementLevels")]
    public IList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>A list of allowed encryptions statuses. An empty list allows all statuses. Each value may be one of: ENCRYPTION_UNSPECIFIED, ENCRYPTION_UNSUPPORTED, UNENCRYPTED, ENCRYPTED.</summary>
    [JsonPropertyName("allowedEncryptionStatuses")]
    public IList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>A list of allowed OS versions. An empty list allows all types and all versions. Structure is documented below.</summary>
    [JsonPropertyName("osConstraints")]
    public IList<V1beta1AccessLevelStatusAtProviderBasicConditionsDevicePolicyOsConstraints>? OsConstraints { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork
{
    /// <summary>Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires compute.network.get permission to be granted to caller.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>CIDR block IP subnetwork specification. Must be IPv4.</summary>
    [JsonPropertyName("vpcIpSubnetworks")]
    public IList<string>? VpcIpSubnetworks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasicConditionsVpcNetworkSources
{
    /// <summary>Sub networks within a VPC network. Structure is documented below.</summary>
    [JsonPropertyName("vpcSubnetwork")]
    public IList<V1beta1AccessLevelStatusAtProviderBasicConditionsVpcNetworkSourcesVpcSubnetwork>? VpcSubnetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasicConditions
{
    /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all devices are allowed. Structure is documented below.</summary>
    [JsonPropertyName("devicePolicy")]
    public IList<V1beta1AccessLevelStatusAtProviderBasicConditionsDevicePolicy>? DevicePolicy { get; set; }

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
    public IList<V1beta1AccessLevelStatusAtProviderBasicConditionsVpcNetworkSources>? VpcNetworkSources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderBasic
{
    /// <summary>How the conditions list should be combined to determine if a request is granted this AccessLevel. If AND is used, each Condition in conditions must be satisfied for the AccessLevel to be applied. If OR is used, at least one Condition in conditions must be satisfied for the AccessLevel to be applied. Default value is AND. Possible values are: AND, OR.</summary>
    [JsonPropertyName("combiningFunction")]
    public string? CombiningFunction { get; set; }

    /// <summary>A set of requirements for the AccessLevel to be granted. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessLevelStatusAtProviderBasicConditions>? Conditions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderCustomExpr
{
    /// <summary>Description of the expression</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProviderCustom
{
    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. This page details the objects and attributes that are used to the build the CEL expressions for custom access levels - https://cloud.google.com/access-context-manager/docs/custom-access-level-spec. Structure is documented below.</summary>
    [JsonPropertyName("expr")]
    public IList<V1beta1AccessLevelStatusAtProviderCustomExpr>? Expr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusAtProvider
{
    /// <summary>A set of predefined conditions for the access level and a combining function. Structure is documented below.</summary>
    [JsonPropertyName("basic")]
    public IList<V1beta1AccessLevelStatusAtProviderBasic>? Basic { get; set; }

    /// <summary>Custom access level conditions are set using the Cloud Common Expression Language to represent the necessary conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec. Structure is documented below.</summary>
    [JsonPropertyName("custom")]
    public IList<V1beta1AccessLevelStatusAtProviderCustom>? Custom { get; set; }

    /// <summary>Description of the AccessLevel and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource name for the Access Level. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/accessLevels/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this AccessLevel lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatusConditions
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
/// <summary>AccessLevelStatus defines the observed state of AccessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessLevelStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccessLevelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessLevelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AccessLevel is the Schema for the AccessLevels API. An AccessLevel is a label that can be applied to requests to GCP services, along with a list of requirements necessary for the label to be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessLevel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessLevelSpec>, IStatus<V1beta1AccessLevelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessLevel";
    public const string KubeGroup = "accesscontextmanager.gcp.upbound.io";
    public const string KubePluralName = "accesslevels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessLevelSpec defines the desired state of AccessLevel</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessLevelSpec Spec { get; set; }

    /// <summary>AccessLevelStatus defines the observed state of AccessLevel.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessLevelStatus? Status { get; set; }
}
#nullable disable
