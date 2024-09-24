using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opsworks.aws.upbound.io;
public enum V1beta1StackSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1StackSpecForProviderCustomCookbooksSourcePasswordSecretRef
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

public partial class V1beta1StackSpecForProviderCustomCookbooksSourceSshKeySecretRef
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

public partial class V1beta1StackSpecForProviderCustomCookbooksSource
{
    /// <summary>Password to use when authenticating to the source.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1StackSpecForProviderCustomCookbooksSourcePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>For sources that are version-aware, the revision to use.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>SSH key to use when authenticating to the source.</summary>
    [JsonPropertyName("sshKeySecretRef")]
    public V1beta1StackSpecForProviderCustomCookbooksSourceSshKeySecretRef? SshKeySecretRef { get; set; }

    /// <summary>The type of source to use. For example, "archive".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URL where the cookbooks resource can be found.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username to use when authenticating to the source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderDefaultInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderDefaultInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderDefaultSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderDefaultSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderDefaultSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderDefaultSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderDefaultSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderDefaultSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecForProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecForProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecForProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecForProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecForProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecForProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecForProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1StackSpecForProvider
{
    /// <summary>If set to "LATEST", OpsWorks will automatically install the latest version.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>If manage_berkshelf is enabled, the version of Berkshelf to use.</summary>
    [JsonPropertyName("berkshelfVersion")]
    public string? BerkshelfVersion { get; set; }

    /// <summary>Color to paint next to the stack's resources in the OpsWorks console.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>Name of the configuration manager to use. Defaults to "Chef".</summary>
    [JsonPropertyName("configurationManagerName")]
    public string? ConfigurationManagerName { get; set; }

    /// <summary>Version of the configuration manager to use. Defaults to "11.4".</summary>
    [JsonPropertyName("configurationManagerVersion")]
    public string? ConfigurationManagerVersion { get; set; }

    /// <summary>When use_custom_cookbooks is set, provide this sub-object as described below.</summary>
    [JsonPropertyName("customCookbooksSource")]
    public IList<V1beta1StackSpecForProviderCustomCookbooksSource>? CustomCookbooksSource { get; set; }

    /// <summary>User defined JSON passed to "Chef". Use a "here doc" for multiline JSON.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default. Cannot be set when vpc_id is set.</summary>
    [JsonPropertyName("defaultAvailabilityZone")]
    public string? DefaultAvailabilityZone { get; set; }

    /// <summary>The ARN of an IAM Instance Profile that created instances will have by default.</summary>
    [JsonPropertyName("defaultInstanceProfileArn")]
    public string? DefaultInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate defaultInstanceProfileArn.</summary>
    [JsonPropertyName("defaultInstanceProfileArnRef")]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnRef? DefaultInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate defaultInstanceProfileArn.</summary>
    [JsonPropertyName("defaultInstanceProfileArnSelector")]
    public V1beta1StackSpecForProviderDefaultInstanceProfileArnSelector? DefaultInstanceProfileArnSelector { get; set; }

    /// <summary>Name of OS that will be installed on instances by default.</summary>
    [JsonPropertyName("defaultOs")]
    public string? DefaultOs { get; set; }

    /// <summary>Name of the type of root device instances will have by default.</summary>
    [JsonPropertyName("defaultRootDeviceType")]
    public string? DefaultRootDeviceType { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("defaultSshKeyName")]
    public string? DefaultSshKeyName { get; set; }

    /// <summary>ID of the subnet in which instances will be created by default. Required if vpc_id is set to a VPC other than the default VPC, and forbidden if it isn't.</summary>
    [JsonPropertyName("defaultSubnetId")]
    public string? DefaultSubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate defaultSubnetId.</summary>
    [JsonPropertyName("defaultSubnetIdRef")]
    public V1beta1StackSpecForProviderDefaultSubnetIdRef? DefaultSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate defaultSubnetId.</summary>
    [JsonPropertyName("defaultSubnetIdSelector")]
    public V1beta1StackSpecForProviderDefaultSubnetIdSelector? DefaultSubnetIdSelector { get; set; }

    /// <summary>Keyword representing the naming scheme that will be used for instance hostnames within this stack.</summary>
    [JsonPropertyName("hostnameTheme")]
    public string? HostnameTheme { get; set; }

    /// <summary>Boolean value controlling whether Opsworks will run Berkshelf for this stack.</summary>
    [JsonPropertyName("manageBerkshelf")]
    public bool? ManageBerkshelf { get; set; }

    /// <summary>The name of the stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the region where the stack will exist.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ARN of an IAM role that the OpsWorks service will act as.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1StackSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1StackSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Boolean value controlling whether the custom cookbook settings are enabled.</summary>
    [JsonPropertyName("useCustomCookbooks")]
    public bool? UseCustomCookbooks { get; set; }

    /// <summary>Boolean value controlling whether the standard OpsWorks security groups apply to created instances.</summary>
    [JsonPropertyName("useOpsworksSecurityGroups")]
    public bool? UseOpsworksSecurityGroups { get; set; }

    /// <summary>ID of the VPC that this stack belongs to. Defaults to the region's default VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1StackSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1StackSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}

public partial class V1beta1StackSpecInitProviderCustomCookbooksSourcePasswordSecretRef
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

public partial class V1beta1StackSpecInitProviderCustomCookbooksSourceSshKeySecretRef
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

public partial class V1beta1StackSpecInitProviderCustomCookbooksSource
{
    /// <summary>Password to use when authenticating to the source.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1StackSpecInitProviderCustomCookbooksSourcePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>For sources that are version-aware, the revision to use.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>SSH key to use when authenticating to the source.</summary>
    [JsonPropertyName("sshKeySecretRef")]
    public V1beta1StackSpecInitProviderCustomCookbooksSourceSshKeySecretRef? SshKeySecretRef { get; set; }

    /// <summary>The type of source to use. For example, "archive".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URL where the cookbooks resource can be found.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username to use when authenticating to the source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderDefaultInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderDefaultSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderDefaultSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderDefaultSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderDefaultSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecInitProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1StackSpecInitProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecInitProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1StackSpecInitProvider
{
    /// <summary>If set to "LATEST", OpsWorks will automatically install the latest version.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>If manage_berkshelf is enabled, the version of Berkshelf to use.</summary>
    [JsonPropertyName("berkshelfVersion")]
    public string? BerkshelfVersion { get; set; }

    /// <summary>Color to paint next to the stack's resources in the OpsWorks console.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>Name of the configuration manager to use. Defaults to "Chef".</summary>
    [JsonPropertyName("configurationManagerName")]
    public string? ConfigurationManagerName { get; set; }

    /// <summary>Version of the configuration manager to use. Defaults to "11.4".</summary>
    [JsonPropertyName("configurationManagerVersion")]
    public string? ConfigurationManagerVersion { get; set; }

    /// <summary>When use_custom_cookbooks is set, provide this sub-object as described below.</summary>
    [JsonPropertyName("customCookbooksSource")]
    public IList<V1beta1StackSpecInitProviderCustomCookbooksSource>? CustomCookbooksSource { get; set; }

    /// <summary>User defined JSON passed to "Chef". Use a "here doc" for multiline JSON.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default. Cannot be set when vpc_id is set.</summary>
    [JsonPropertyName("defaultAvailabilityZone")]
    public string? DefaultAvailabilityZone { get; set; }

    /// <summary>The ARN of an IAM Instance Profile that created instances will have by default.</summary>
    [JsonPropertyName("defaultInstanceProfileArn")]
    public string? DefaultInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate defaultInstanceProfileArn.</summary>
    [JsonPropertyName("defaultInstanceProfileArnRef")]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnRef? DefaultInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate defaultInstanceProfileArn.</summary>
    [JsonPropertyName("defaultInstanceProfileArnSelector")]
    public V1beta1StackSpecInitProviderDefaultInstanceProfileArnSelector? DefaultInstanceProfileArnSelector { get; set; }

    /// <summary>Name of OS that will be installed on instances by default.</summary>
    [JsonPropertyName("defaultOs")]
    public string? DefaultOs { get; set; }

    /// <summary>Name of the type of root device instances will have by default.</summary>
    [JsonPropertyName("defaultRootDeviceType")]
    public string? DefaultRootDeviceType { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("defaultSshKeyName")]
    public string? DefaultSshKeyName { get; set; }

    /// <summary>ID of the subnet in which instances will be created by default. Required if vpc_id is set to a VPC other than the default VPC, and forbidden if it isn't.</summary>
    [JsonPropertyName("defaultSubnetId")]
    public string? DefaultSubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate defaultSubnetId.</summary>
    [JsonPropertyName("defaultSubnetIdRef")]
    public V1beta1StackSpecInitProviderDefaultSubnetIdRef? DefaultSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate defaultSubnetId.</summary>
    [JsonPropertyName("defaultSubnetIdSelector")]
    public V1beta1StackSpecInitProviderDefaultSubnetIdSelector? DefaultSubnetIdSelector { get; set; }

    /// <summary>Keyword representing the naming scheme that will be used for instance hostnames within this stack.</summary>
    [JsonPropertyName("hostnameTheme")]
    public string? HostnameTheme { get; set; }

    /// <summary>Boolean value controlling whether Opsworks will run Berkshelf for this stack.</summary>
    [JsonPropertyName("manageBerkshelf")]
    public bool? ManageBerkshelf { get; set; }

    /// <summary>The name of the stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of an IAM role that the OpsWorks service will act as.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1StackSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1StackSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Boolean value controlling whether the custom cookbook settings are enabled.</summary>
    [JsonPropertyName("useCustomCookbooks")]
    public bool? UseCustomCookbooks { get; set; }

    /// <summary>Boolean value controlling whether the standard OpsWorks security groups apply to created instances.</summary>
    [JsonPropertyName("useOpsworksSecurityGroups")]
    public bool? UseOpsworksSecurityGroups { get; set; }

    /// <summary>ID of the VPC that this stack belongs to. Defaults to the region's default VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1StackSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1StackSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}

public enum V1beta1StackSpecManagementPoliciesEnum
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

public enum V1beta1StackSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1StackSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1StackSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1StackSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1StackSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StackSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1StackSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1StackSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1StackSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSpecDeletionPolicyEnum>))]
    public V1beta1StackSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StackSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StackSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StackSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StackSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1StackSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StackSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1StackStatusAtProviderCustomCookbooksSource
{
    /// <summary>For sources that are version-aware, the revision to use.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The type of source to use. For example, "archive".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URL where the cookbooks resource can be found.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username to use when authenticating to the source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1StackStatusAtProvider
{
    /// <summary>If set to "LATEST", OpsWorks will automatically install the latest version.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>If manage_berkshelf is enabled, the version of Berkshelf to use.</summary>
    [JsonPropertyName("berkshelfVersion")]
    public string? BerkshelfVersion { get; set; }

    /// <summary>Color to paint next to the stack's resources in the OpsWorks console.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>Name of the configuration manager to use. Defaults to "Chef".</summary>
    [JsonPropertyName("configurationManagerName")]
    public string? ConfigurationManagerName { get; set; }

    /// <summary>Version of the configuration manager to use. Defaults to "11.4".</summary>
    [JsonPropertyName("configurationManagerVersion")]
    public string? ConfigurationManagerVersion { get; set; }

    /// <summary>When use_custom_cookbooks is set, provide this sub-object as described below.</summary>
    [JsonPropertyName("customCookbooksSource")]
    public IList<V1beta1StackStatusAtProviderCustomCookbooksSource>? CustomCookbooksSource { get; set; }

    /// <summary>User defined JSON passed to "Chef". Use a "here doc" for multiline JSON.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default. Cannot be set when vpc_id is set.</summary>
    [JsonPropertyName("defaultAvailabilityZone")]
    public string? DefaultAvailabilityZone { get; set; }

    /// <summary>The ARN of an IAM Instance Profile that created instances will have by default.</summary>
    [JsonPropertyName("defaultInstanceProfileArn")]
    public string? DefaultInstanceProfileArn { get; set; }

    /// <summary>Name of OS that will be installed on instances by default.</summary>
    [JsonPropertyName("defaultOs")]
    public string? DefaultOs { get; set; }

    /// <summary>Name of the type of root device instances will have by default.</summary>
    [JsonPropertyName("defaultRootDeviceType")]
    public string? DefaultRootDeviceType { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("defaultSshKeyName")]
    public string? DefaultSshKeyName { get; set; }

    /// <summary>ID of the subnet in which instances will be created by default. Required if vpc_id is set to a VPC other than the default VPC, and forbidden if it isn't.</summary>
    [JsonPropertyName("defaultSubnetId")]
    public string? DefaultSubnetId { get; set; }

    /// <summary>Keyword representing the naming scheme that will be used for instance hostnames within this stack.</summary>
    [JsonPropertyName("hostnameTheme")]
    public string? HostnameTheme { get; set; }

    /// <summary>The id of the stack.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Boolean value controlling whether Opsworks will run Berkshelf for this stack.</summary>
    [JsonPropertyName("manageBerkshelf")]
    public bool? ManageBerkshelf { get; set; }

    /// <summary>The name of the stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the region where the stack will exist.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of an IAM role that the OpsWorks service will act as.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stackEndpoint")]
    public string? StackEndpoint { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Boolean value controlling whether the custom cookbook settings are enabled.</summary>
    [JsonPropertyName("useCustomCookbooks")]
    public bool? UseCustomCookbooks { get; set; }

    /// <summary>Boolean value controlling whether the standard OpsWorks security groups apply to created instances.</summary>
    [JsonPropertyName("useOpsworksSecurityGroups")]
    public bool? UseOpsworksSecurityGroups { get; set; }

    /// <summary>ID of the VPC that this stack belongs to. Defaults to the region's default VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

public partial class V1beta1StackStatusConditions
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

public partial class V1beta1StackStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StackStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StackStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Stack : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StackSpec>, IStatus<V1beta1StackStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Stack";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "stacks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSpec defines the desired state of Stack</summary>
    [JsonPropertyName("spec")]
    public V1beta1StackSpec Spec { get; set; }

    /// <summary>StackStatus defines the observed state of Stack.</summary>
    [JsonPropertyName("status")]
    public V1beta1StackStatus? Status { get; set; }
}