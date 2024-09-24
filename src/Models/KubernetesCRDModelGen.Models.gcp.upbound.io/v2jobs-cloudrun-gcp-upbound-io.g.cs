using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudrun.gcp.upbound.io;
public enum V1beta1V2JobSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelector? SecretSelector { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any route environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the maximum length is 32768 bytes</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersResources
{
    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersResources>? Resources { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecretSecretSelector? SecretSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVolumesSecret>? Secret { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run job.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplateTemplate
{
    /// <summary>Holds the single container that defines the unit of execution for this task. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The execution environment being used to host this Task. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplateVpcAccess>? VpcAccess { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the maximum desired number of tasks the execution should run at given time. Must be &lt;= taskCount. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>Describes the task(s) that will be created when executing an execution Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobSpecForProviderTemplateTemplate>? Template { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecForProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2JobSpecForProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of the cloud run job</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The template used to create executions for this Job. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobSpecForProviderTemplate>? Template { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretSelector? SecretSelector { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any route environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the maximum length is 32768 bytes</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersResources
{
    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersResources>? Resources { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecretSecretSelector? SecretSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVolumesSecret>? Secret { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run job.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplateTemplate
{
    /// <summary>Holds the single container that defines the unit of execution for this task. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The execution environment being used to host this Task. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplateVpcAccess>? VpcAccess { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobSpecInitProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the maximum desired number of tasks the execution should run at given time. Must be &lt;= taskCount. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>Describes the task(s) that will be created when executing an execution Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobSpecInitProviderTemplateTemplate>? Template { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1V2JobSpecInitProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2JobSpecInitProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The template used to create executions for this Job. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobSpecInitProviderTemplate>? Template { get; set; }
}

public enum V1beta1V2JobSpecManagementPoliciesEnum
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

public enum V1beta1V2JobSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1V2JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1V2JobSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2JobSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1V2JobSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1V2JobSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1V2JobSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1V2JobSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1V2JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>V2JobSpec defines the desired state of V2Job</summary>
public partial class V1beta1V2JobSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2JobSpecDeletionPolicyEnum>))]
    public V1beta1V2JobSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1V2JobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1V2JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1V2JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1V2JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1V2JobSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1V2JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderConditions
{
    /// <summary>(Output) A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>(Output) Last time the condition transitioned from one status to another. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>(Output) A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>(Output) How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>(Output) State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Output) type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderLatestCreatedExecution
{
    /// <summary>(Output) Completion timestamp of the execution. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("completionTime")]
    public string? CompletionTime { get; set; }

    /// <summary>(Output) Creation timestamp of the execution. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>(Output) Name of the execution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any route environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the maximum length is 32768 bytes</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersResources
{
    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersResources>? Resources { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVolumesSecret>? Secret { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run job.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplateTemplate
{
    /// <summary>Holds the single container that defines the unit of execution for this task. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The execution environment being used to host this Task. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplateVpcAccess>? VpcAccess { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the maximum desired number of tasks the execution should run at given time. Must be &lt;= taskCount. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>Describes the task(s) that will be created when executing an execution Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobStatusAtProviderTemplateTemplate>? Template { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProviderTerminalCondition
{
    /// <summary>(Output) A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>(Output) Last time the condition transitioned from one status to another. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>(Output) A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>(Output) How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>(Output) State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Output) type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1V2JobStatusAtProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2JobStatusAtProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Job does not reach its desired state. See comments in reconciling for additional information on reconciliation process in Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1V2JobStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Email address of the authenticated creator.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>The deletion time.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Number of executions created for this job.</summary>
    [JsonPropertyName("executionCount")]
    public double? ExecutionCount { get; set; }

    /// <summary>For a deleted resource, the time after which it will be permamently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>A number that monotonically increases every time the user modifies the desired state.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/jobs/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 ExecutionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Name of the last created execution. Structure is documented below.</summary>
    [JsonPropertyName("latestCreatedExecution")]
    public IList<V1beta1V2JobStatusAtProviderLatestCreatedExecution>? LatestCreatedExecution { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of the cloud run job</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The generation of this Job. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("observedGeneration")]
    public string? ObservedGeneration { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Returns true if the Job is currently being acted upon by the system to bring it into the desired state. When a new Job is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Job to the desired state. This process is called reconciliation. While reconciliation is in process, observedGeneration and latest_succeeded_execution, will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state. If reconciliation succeeded, the following fields will match: observedGeneration and generation, latest_succeeded_execution and latestCreatedExecution. If reconciliation failed, observedGeneration and latest_succeeded_execution will have the state of the last succeeded execution or empty for newly created Job. Additional information on the failure can be found in terminalCondition and conditions</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The template used to create executions for this Job. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2JobStatusAtProviderTemplate>? Template { get; set; }

    /// <summary>The Condition of this Job, containing its readiness status, and detailed error information in case it did not reach the desired state Structure is documented below.</summary>
    [JsonPropertyName("terminalCondition")]
    public IList<V1beta1V2JobStatusAtProviderTerminalCondition>? TerminalCondition { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1V2JobStatusConditions
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

/// <summary>V2JobStatus defines the observed state of V2Job.</summary>
public partial class V1beta1V2JobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1V2JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1V2JobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>V2Job is the Schema for the V2Jobs API. A Cloud Run Job resource that references a container image which is run to completion.</summary>
public partial class V1beta1V2Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1V2JobSpec>, IStatus<V1beta1V2JobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "V2Job";
    public const string KubeGroup = "cloudrun.gcp.upbound.io";
    public const string KubePluralName = "v2jobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>V2JobSpec defines the desired state of V2Job</summary>
    [JsonPropertyName("spec")]
    public V1beta1V2JobSpec Spec { get; set; }

    /// <summary>V2JobStatus defines the observed state of V2Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1V2JobStatus? Status { get; set; }
}