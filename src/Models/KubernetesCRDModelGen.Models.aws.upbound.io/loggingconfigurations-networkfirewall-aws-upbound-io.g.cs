using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.aws.upbound.io;
public enum V1beta1LoggingConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecForProviderFirewallArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnRefPolicy? Policy { get; set; }
}

public enum V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecForProviderFirewallArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecForProviderLoggingConfigurationLogDestinationConfig
{
    /// <summary>A map describing the logging destination for the chosen log_destination_type.</summary>
    [JsonPropertyName("logDestination")]
    public IDictionary<string, string>? LogDestination { get; set; }

    /// <summary>The location to send logs to. Valid values: S3, CloudWatchLogs, KinesisDataFirehose.</summary>
    [JsonPropertyName("logDestinationType")]
    public string? LogDestinationType { get; set; }

    /// <summary>The type of log to send. Valid values: ALERT or FLOW. Alert logs report traffic that matches a StatefulRule with an action setting that sends a log message. Flow logs are standard network traffic flow logs.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecForProviderLoggingConfiguration
{
    /// <summary>Set of configuration blocks describing the logging details for a firewall. See Log Destination Config below for details. At most, only two blocks can be specified; one for FLOW logs and one for ALERT logs.</summary>
    [JsonPropertyName("logDestinationConfig")]
    public IList<V1beta1LoggingConfigurationSpecForProviderLoggingConfigurationLogDestinationConfig>? LogDestinationConfig { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecForProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Network Firewall firewall.</summary>
    [JsonPropertyName("firewallArn")]
    public string? FirewallArn { get; set; }

    /// <summary>Reference to a Firewall in networkfirewall to populate firewallArn.</summary>
    [JsonPropertyName("firewallArnRef")]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnRef? FirewallArnRef { get; set; }

    /// <summary>Selector for a Firewall in networkfirewall to populate firewallArn.</summary>
    [JsonPropertyName("firewallArnSelector")]
    public V1beta1LoggingConfigurationSpecForProviderFirewallArnSelector? FirewallArnSelector { get; set; }

    /// <summary>A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1LoggingConfigurationSpecForProviderLoggingConfiguration>? LoggingConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecInitProviderFirewallArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnRefPolicy? Policy { get; set; }
}

public enum V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecInitProviderLoggingConfigurationLogDestinationConfig
{
    /// <summary>A map describing the logging destination for the chosen log_destination_type.</summary>
    [JsonPropertyName("logDestination")]
    public IDictionary<string, string>? LogDestination { get; set; }

    /// <summary>The location to send logs to. Valid values: S3, CloudWatchLogs, KinesisDataFirehose.</summary>
    [JsonPropertyName("logDestinationType")]
    public string? LogDestinationType { get; set; }

    /// <summary>The type of log to send. Valid values: ALERT or FLOW. Alert logs report traffic that matches a StatefulRule with an action setting that sends a log message. Flow logs are standard network traffic flow logs.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecInitProviderLoggingConfiguration
{
    /// <summary>Set of configuration blocks describing the logging details for a firewall. See Log Destination Config below for details. At most, only two blocks can be specified; one for FLOW logs and one for ALERT logs.</summary>
    [JsonPropertyName("logDestinationConfig")]
    public IList<V1beta1LoggingConfigurationSpecInitProviderLoggingConfigurationLogDestinationConfig>? LogDestinationConfig { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecInitProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Network Firewall firewall.</summary>
    [JsonPropertyName("firewallArn")]
    public string? FirewallArn { get; set; }

    /// <summary>Reference to a Firewall in networkfirewall to populate firewallArn.</summary>
    [JsonPropertyName("firewallArnRef")]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnRef? FirewallArnRef { get; set; }

    /// <summary>Selector for a Firewall in networkfirewall to populate firewallArn.</summary>
    [JsonPropertyName("firewallArnSelector")]
    public V1beta1LoggingConfigurationSpecInitProviderFirewallArnSelector? FirewallArnSelector { get; set; }

    /// <summary>A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1LoggingConfigurationSpecInitProviderLoggingConfiguration>? LoggingConfiguration { get; set; }
}

public enum V1beta1LoggingConfigurationSpecManagementPoliciesEnum
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

public enum V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1LoggingConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1LoggingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1LoggingConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoggingConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1LoggingConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LoggingConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LoggingConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LoggingConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LoggingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LoggingConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LoggingConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1LoggingConfigurationStatusAtProviderLoggingConfigurationLogDestinationConfig
{
    /// <summary>A map describing the logging destination for the chosen log_destination_type.</summary>
    [JsonPropertyName("logDestination")]
    public IDictionary<string, string>? LogDestination { get; set; }

    /// <summary>The location to send logs to. Valid values: S3, CloudWatchLogs, KinesisDataFirehose.</summary>
    [JsonPropertyName("logDestinationType")]
    public string? LogDestinationType { get; set; }

    /// <summary>The type of log to send. Valid values: ALERT or FLOW. Alert logs report traffic that matches a StatefulRule with an action setting that sends a log message. Flow logs are standard network traffic flow logs.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

public partial class V1beta1LoggingConfigurationStatusAtProviderLoggingConfiguration
{
    /// <summary>Set of configuration blocks describing the logging details for a firewall. See Log Destination Config below for details. At most, only two blocks can be specified; one for FLOW logs and one for ALERT logs.</summary>
    [JsonPropertyName("logDestinationConfig")]
    public IList<V1beta1LoggingConfigurationStatusAtProviderLoggingConfigurationLogDestinationConfig>? LogDestinationConfig { get; set; }
}

public partial class V1beta1LoggingConfigurationStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Network Firewall firewall.</summary>
    [JsonPropertyName("firewallArn")]
    public string? FirewallArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the associated firewall.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public IList<V1beta1LoggingConfigurationStatusAtProviderLoggingConfiguration>? LoggingConfiguration { get; set; }
}

public partial class V1beta1LoggingConfigurationStatusConditions
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

public partial class V1beta1LoggingConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LoggingConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingConfigurationSpec>, IStatus<V1beta1LoggingConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingConfiguration";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "loggingconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoggingConfigurationSpec defines the desired state of LoggingConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1LoggingConfigurationSpec Spec { get; set; }

    /// <summary>LoggingConfigurationStatus defines the observed state of LoggingConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingConfigurationStatus? Status { get; set; }
}