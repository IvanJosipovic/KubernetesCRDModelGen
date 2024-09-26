using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gamelift.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderBuildIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderBuildIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderBuildIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderBuildIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderBuildIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderBuildIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderInstanceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderInstanceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderInstanceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderInstanceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderInstanceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderInstanceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta1FleetSpecForProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecForProvider
{
    /// <summary>ID of the GameLift Build to be deployed on the fleet.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Reference to a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdRef")]
    public V1beta1FleetSpecForProviderBuildIdRef? BuildIdRef { get; set; }

    /// <summary>Selector for a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdSelector")]
    public V1beta1FleetSpecForProviderBuildIdSelector? BuildIdSelector { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public IList<V1beta1FleetSpecForProviderCertificateConfiguration>? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta1FleetSpecForProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnRef")]
    public V1beta1FleetSpecForProviderInstanceRoleArnRef? InstanceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnSelector")]
    public V1beta1FleetSpecForProviderInstanceRoleArnSelector? InstanceRoleArnSelector { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public IList<V1beta1FleetSpecForProviderResourceCreationLimitPolicy>? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public IList<V1beta1FleetSpecForProviderRuntimeConfiguration>? RuntimeConfiguration { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderBuildIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderBuildIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderBuildIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderBuildIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Build in gamelift to populate buildId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderBuildIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderBuildIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderInstanceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderInstanceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderInstanceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderInstanceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderInstanceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderInstanceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta1FleetSpecInitProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecInitProvider
{
    /// <summary>ID of the GameLift Build to be deployed on the fleet.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Reference to a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdRef")]
    public V1beta1FleetSpecInitProviderBuildIdRef? BuildIdRef { get; set; }

    /// <summary>Selector for a Build in gamelift to populate buildId.</summary>
    [JsonPropertyName("buildIdSelector")]
    public V1beta1FleetSpecInitProviderBuildIdSelector? BuildIdSelector { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public IList<V1beta1FleetSpecInitProviderCertificateConfiguration>? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta1FleetSpecInitProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnRef")]
    public V1beta1FleetSpecInitProviderInstanceRoleArnRef? InstanceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate instanceRoleArn.</summary>
    [JsonPropertyName("instanceRoleArnSelector")]
    public V1beta1FleetSpecInitProviderInstanceRoleArnSelector? InstanceRoleArnSelector { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public IList<V1beta1FleetSpecInitProviderResourceCreationLimitPolicy>? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public IList<V1beta1FleetSpecInitProviderRuntimeConfiguration>? RuntimeConfiguration { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FleetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FleetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FleetSpec defines the desired state of Fleet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FleetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FleetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FleetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FleetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FleetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProviderCertificateConfiguration
{
    /// <summary>Indicates whether a TLS/SSL certificate is generated for a fleet. Valid values are DISABLED and GENERATED. Default value is DISABLED.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProviderEc2InboundPermission
{
    /// <summary>Starting value for a range of allowed port numbers.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Range of allowed IP addresses expressed in CIDR notationE.g., 000.000.000.000/[subnet mask] or 0.0.0.0/[subnet mask].</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Network communication protocol used by the fleetE.g., TCP or UDP</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProviderResourceCreationLimitPolicy
{
    /// <summary>Maximum number of game sessions that an individual can create during the policy period.</summary>
    [JsonPropertyName("newGameSessionsPerCreator")]
    public double? NewGameSessionsPerCreator { get; set; }

    /// <summary>Time span used in evaluating the resource creation limit policy.</summary>
    [JsonPropertyName("policyPeriodInMinutes")]
    public double? PolicyPeriodInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProviderRuntimeConfigurationServerProcess
{
    /// <summary>Number of server processes using this configuration to run concurrently on an instance.</summary>
    [JsonPropertyName("concurrentExecutions")]
    public double? ConcurrentExecutions { get; set; }

    /// <summary>Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances C:\game, and for Linux instances /local/game.</summary>
    [JsonPropertyName("launchPath")]
    public string? LaunchPath { get; set; }

    /// <summary>Optional list of parameters to pass to the server executable on launch.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProviderRuntimeConfiguration
{
    /// <summary>Maximum amount of time (in seconds) that a game session can remain in status ACTIVATING.</summary>
    [JsonPropertyName("gameSessionActivationTimeoutSeconds")]
    public double? GameSessionActivationTimeoutSeconds { get; set; }

    /// <summary>Maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.</summary>
    [JsonPropertyName("maxConcurrentGameSessionActivations")]
    public double? MaxConcurrentGameSessionActivations { get; set; }

    /// <summary>Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.</summary>
    [JsonPropertyName("serverProcess")]
    public IList<V1beta1FleetStatusAtProviderRuntimeConfigurationServerProcess>? ServerProcess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusAtProvider
{
    /// <summary>Fleet ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Build ARN.</summary>
    [JsonPropertyName("buildArn")]
    public string? BuildArn { get; set; }

    /// <summary>ID of the GameLift Build to be deployed on the fleet.</summary>
    [JsonPropertyName("buildId")]
    public string? BuildId { get; set; }

    /// <summary>Prompts GameLift to generate a TLS/SSL certificate for the fleet. See certificate_configuration.</summary>
    [JsonPropertyName("certificateConfiguration")]
    public IList<V1beta1FleetStatusAtProviderCertificateConfiguration>? CertificateConfiguration { get; set; }

    /// <summary>Human-readable description of the fleet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.</summary>
    [JsonPropertyName("ec2InboundPermission")]
    public IList<V1beta1FleetStatusAtProviderEc2InboundPermission>? Ec2InboundPermission { get; set; }

    /// <summary>Name of an EC2 instance typeE.g., t2.micro</summary>
    [JsonPropertyName("ec2InstanceType")]
    public string? Ec2InstanceType { get; set; }

    /// <summary>Type of fleet. This value must be ON_DEMAND or SPOT. Defaults to ON_DEMAND.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>Fleet ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of an IAM role that instances in the fleet can assume.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logPaths")]
    public IList<string>? LogPaths { get; set; }

    /// <summary>List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to default.</summary>
    [JsonPropertyName("metricGroups")]
    public IList<string>? MetricGroups { get; set; }

    /// <summary>The name of the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Game session protection policy to apply to all instances in this fleetE.g., FullProtection. Defaults to NoProtection.</summary>
    [JsonPropertyName("newGameSessionProtectionPolicy")]
    public string? NewGameSessionProtectionPolicy { get; set; }

    /// <summary>Operating system of the fleet's computing resources.</summary>
    [JsonPropertyName("operatingSystem")]
    public string? OperatingSystem { get; set; }

    /// <summary>Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.</summary>
    [JsonPropertyName("resourceCreationLimitPolicy")]
    public IList<V1beta1FleetStatusAtProviderResourceCreationLimitPolicy>? ResourceCreationLimitPolicy { get; set; }

    /// <summary>Instructions for launching server processes on each instance in the fleet. See below.</summary>
    [JsonPropertyName("runtimeConfiguration")]
    public IList<V1beta1FleetStatusAtProviderRuntimeConfiguration>? RuntimeConfiguration { get; set; }

    /// <summary>Script ARN.</summary>
    [JsonPropertyName("scriptArn")]
    public string? ScriptArn { get; set; }

    /// <summary>ID of the GameLift Script to be deployed on the fleet.</summary>
    [JsonPropertyName("scriptId")]
    public string? ScriptId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatusConditions
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

/// <summary>FleetStatus defines the observed state of Fleet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FleetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FleetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FleetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Fleet is the Schema for the Fleets API. Provides a GameLift Fleet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Fleet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FleetSpec>, IStatus<V1beta1FleetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Fleet";
    public const string KubeGroup = "gamelift.aws.upbound.io";
    public const string KubePluralName = "fleet";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FleetSpec defines the desired state of Fleet</summary>
    [JsonPropertyName("spec")]
    public V1beta1FleetSpec Spec { get; set; }

    /// <summary>FleetStatus defines the observed state of Fleet.</summary>
    [JsonPropertyName("status")]
    public V1beta1FleetStatus? Status { get; set; }
}