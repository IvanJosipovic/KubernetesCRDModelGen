using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.medialive.aws.upbound.io;
public enum V1beta1InputSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1InputSpecForProviderDestinations
{
    /// <summary>A unique name for the location the RTMP stream is being pushed to.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

public partial class V1beta1InputSpecForProviderInputDevices
{
    /// <summary>The unique ID for the device.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1beta1InputSpecForProviderMediaConnectFlows
{
    /// <summary>The ARN of the MediaConnect Flow</summary>
    [JsonPropertyName("flowArn")]
    public string? FlowArn { get; set; }
}

public enum V1beta1InputSpecForProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecForProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1InputSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecForProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1InputSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1InputSpecForProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1InputSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1InputSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1InputSpecForProviderSources
{
    /// <summary>The key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>The URL where the stream is pulled from.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username for the input source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1InputSpecForProviderVpc
{
    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Input.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of 2 VPC subnet IDs from the same VPC.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1InputSpecForProvider
{
    /// <summary>Destination settings for PUSH type inputs. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1InputSpecForProviderDestinations>? Destinations { get; set; }

    /// <summary>Settings for the devices. See Input Devices for more details.</summary>
    [JsonPropertyName("inputDevices")]
    public IList<V1beta1InputSpecForProviderInputDevices>? InputDevices { get; set; }

    /// <summary>List of input security groups.</summary>
    [JsonPropertyName("inputSecurityGroups")]
    public IList<string>? InputSecurityGroups { get; set; }

    /// <summary>A list of the MediaConnect Flows. See Media Connect Flows for more details.</summary>
    [JsonPropertyName("mediaConnectFlows")]
    public IList<V1beta1InputSpecForProviderMediaConnectFlows>? MediaConnectFlows { get; set; }

    /// <summary>Name of the input.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ARN of the role this input assumes during and after creation.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1InputSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1InputSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The source URLs for a PULL-type input. See Sources for more details.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1InputSpecForProviderSources>? Sources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The different types of inputs that AWS Elemental MediaLive supports.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Settings for a private VPC Input. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1InputSpecForProviderVpc>? Vpc { get; set; }
}

public partial class V1beta1InputSpecInitProviderDestinations
{
    /// <summary>A unique name for the location the RTMP stream is being pushed to.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

public partial class V1beta1InputSpecInitProviderInputDevices
{
    /// <summary>The unique ID for the device.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1beta1InputSpecInitProviderMediaConnectFlows
{
    /// <summary>The ARN of the MediaConnect Flow</summary>
    [JsonPropertyName("flowArn")]
    public string? FlowArn { get; set; }
}

public enum V1beta1InputSpecInitProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1InputSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecInitProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1InputSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1InputSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1InputSpecInitProviderSources
{
    /// <summary>The key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>The URL where the stream is pulled from.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username for the input source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1InputSpecInitProviderVpc
{
    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Input.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of 2 VPC subnet IDs from the same VPC.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1InputSpecInitProvider
{
    /// <summary>Destination settings for PUSH type inputs. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1InputSpecInitProviderDestinations>? Destinations { get; set; }

    /// <summary>Settings for the devices. See Input Devices for more details.</summary>
    [JsonPropertyName("inputDevices")]
    public IList<V1beta1InputSpecInitProviderInputDevices>? InputDevices { get; set; }

    /// <summary>List of input security groups.</summary>
    [JsonPropertyName("inputSecurityGroups")]
    public IList<string>? InputSecurityGroups { get; set; }

    /// <summary>A list of the MediaConnect Flows. See Media Connect Flows for more details.</summary>
    [JsonPropertyName("mediaConnectFlows")]
    public IList<V1beta1InputSpecInitProviderMediaConnectFlows>? MediaConnectFlows { get; set; }

    /// <summary>Name of the input.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the role this input assumes during and after creation.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1InputSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1InputSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The source URLs for a PULL-type input. See Sources for more details.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1InputSpecInitProviderSources>? Sources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The different types of inputs that AWS Elemental MediaLive supports.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Settings for a private VPC Input. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1InputSpecInitProviderVpc>? Vpc { get; set; }
}

public enum V1beta1InputSpecManagementPoliciesEnum
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

public enum V1beta1InputSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InputSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InputSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InputSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InputSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1InputSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1InputSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InputSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InputSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1InputSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1InputSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InputSpecDeletionPolicyEnum>))]
    public V1beta1InputSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InputSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InputSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InputSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InputSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InputSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InputSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1InputStatusAtProviderDestinations
{
    /// <summary>A unique name for the location the RTMP stream is being pushed to.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

public partial class V1beta1InputStatusAtProviderInputDevices
{
    /// <summary>The unique ID for the device.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1beta1InputStatusAtProviderMediaConnectFlows
{
    /// <summary>The ARN of the MediaConnect Flow</summary>
    [JsonPropertyName("flowArn")]
    public string? FlowArn { get; set; }
}

public partial class V1beta1InputStatusAtProviderSources
{
    /// <summary>The key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>The URL where the stream is pulled from.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username for the input source.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1InputStatusAtProviderVpc
{
    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Input.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of 2 VPC subnet IDs from the same VPC.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1InputStatusAtProvider
{
    /// <summary>ARN of the Input.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Channels attached to Input.</summary>
    [JsonPropertyName("attachedChannels")]
    public IList<string>? AttachedChannels { get; set; }

    /// <summary>Destination settings for PUSH type inputs. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1InputStatusAtProviderDestinations>? Destinations { get; set; }

    /// <summary>The unique ID for the device.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The input class.</summary>
    [JsonPropertyName("inputClass")]
    public string? InputClass { get; set; }

    /// <summary>Settings for the devices. See Input Devices for more details.</summary>
    [JsonPropertyName("inputDevices")]
    public IList<V1beta1InputStatusAtProviderInputDevices>? InputDevices { get; set; }

    /// <summary>A list of IDs for all Inputs which are partners of this one.</summary>
    [JsonPropertyName("inputPartnerIds")]
    public IList<string>? InputPartnerIds { get; set; }

    /// <summary>List of input security groups.</summary>
    [JsonPropertyName("inputSecurityGroups")]
    public IList<string>? InputSecurityGroups { get; set; }

    /// <summary>Source type of the input.</summary>
    [JsonPropertyName("inputSourceType")]
    public string? InputSourceType { get; set; }

    /// <summary>A list of the MediaConnect Flows. See Media Connect Flows for more details.</summary>
    [JsonPropertyName("mediaConnectFlows")]
    public IList<V1beta1InputStatusAtProviderMediaConnectFlows>? MediaConnectFlows { get; set; }

    /// <summary>Name of the input.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the role this input assumes during and after creation.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The source URLs for a PULL-type input. See Sources for more details.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1InputStatusAtProviderSources>? Sources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The different types of inputs that AWS Elemental MediaLive supports.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Settings for a private VPC Input. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1InputStatusAtProviderVpc>? Vpc { get; set; }
}

public partial class V1beta1InputStatusConditions
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

public partial class V1beta1InputStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InputStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InputStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Input : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InputSpec>, IStatus<V1beta1InputStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Input";
    public const string KubeGroup = "medialive.aws.upbound.io";
    public const string KubePluralName = "inputs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InputSpec defines the desired state of Input</summary>
    [JsonPropertyName("spec")]
    public V1beta1InputSpec Spec { get; set; }

    /// <summary>InputStatus defines the observed state of Input.</summary>
    [JsonPropertyName("status")]
    public V1beta1InputStatus? Status { get; set; }
}