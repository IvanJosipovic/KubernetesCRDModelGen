using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tf.upbound.io;
public enum V1beta1WorkspaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1WorkspaceSpecForProviderEnvConfigMapKeyRef
{
    /// <summary>Key within the referenced resource.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referenced resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced resource.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderEnvSecretKeyRef
{
    /// <summary>Key within the referenced resource.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referenced resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced resource.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderEnv
{
    /// <summary>A ConfigMap key containing the desired env var value.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1WorkspaceSpecForProviderEnvConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A Secret key containing the desired env var value.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1WorkspaceSpecForProviderEnvSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderInlineFormatEnum
{
    [EnumMember(Value = "HCL"), JsonStringEnumMemberName("HCL")]
    /// <summary>HCL</summary>
    HCL,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    /// <summary>JSON</summary>
    JSON
}

public enum V1beta1WorkspaceSpecForProviderSourceEnum
{
    [EnumMember(Value = "Remote"), JsonStringEnumMemberName("Remote")]
    /// <summary>Remote</summary>
    Remote,
    [EnumMember(Value = "Inline"), JsonStringEnumMemberName("Inline")]
    /// <summary>Inline</summary>
    Inline
}

public partial class V1beta1WorkspaceSpecForProviderVarFilesConfigMapKeyRef
{
    /// <summary>Key within the referenced resource.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referenced resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced resource.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderVarFilesFormatEnum
{
    [EnumMember(Value = "HCL"), JsonStringEnumMemberName("HCL")]
    /// <summary>HCL</summary>
    HCL,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    /// <summary>JSON</summary>
    JSON
}

public partial class V1beta1WorkspaceSpecForProviderVarFilesSecretKeyRef
{
    /// <summary>Key within the referenced resource.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referenced resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced resource.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderVarFilesSourceEnum
{
    [EnumMember(Value = "ConfigMapKey"), JsonStringEnumMemberName("ConfigMapKey")]
    /// <summary>ConfigMapKey</summary>
    ConfigMapKey,
    [EnumMember(Value = "SecretKey"), JsonStringEnumMemberName("SecretKey")]
    /// <summary>SecretKey</summary>
    SecretKey
}

public partial class V1beta1WorkspaceSpecForProviderVarFiles
{
    /// <summary>A ConfigMap key containing the vars file.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1WorkspaceSpecForProviderVarFilesConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Format of this vars file.</summary>
    [JsonPropertyName("format")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderVarFilesFormatEnum>))]
    public V1beta1WorkspaceSpecForProviderVarFilesFormatEnum? Format { get; set; }

    /// <summary>A Secret key containing the vars file.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1WorkspaceSpecForProviderVarFilesSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Source of this vars file.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderVarFilesSourceEnum>))]
    public V1beta1WorkspaceSpecForProviderVarFilesSourceEnum Source { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderVars
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1beta1WorkspaceSpecForProvider
{
    /// <summary>Arguments to be included in the terraform apply CLI command</summary>
    [JsonPropertyName("applyArgs")]
    public IList<string>? ApplyArgs { get; set; }

    /// <summary>Arguments to be included in the terraform destroy CLI command</summary>
    [JsonPropertyName("destroyArgs")]
    public IList<string>? DestroyArgs { get; set; }

    /// <summary>Boolean value to indicate  CLI logging of terraform execution is enabled or not</summary>
    [JsonPropertyName("enableTerraformCLILogging")]
    public bool? EnableTerraformCLILogging { get; set; }

    /// <summary>Entrypoint for `terraform init` within the module</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>Environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1WorkspaceSpecForProviderEnv>? Env { get; set; }

    /// <summary>Arguments to be included in the terraform init CLI command</summary>
    [JsonPropertyName("initArgs")]
    public IList<string>? InitArgs { get; set; }

    /// <summary>Specifies the format of the inline Terraform content if Source is 'Inline'</summary>
    [JsonPropertyName("inlineFormat")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderInlineFormatEnum>))]
    public V1beta1WorkspaceSpecForProviderInlineFormatEnum? InlineFormat { get; set; }

    /// <summary>The root module of this workspace; i.e. the module containing its main.tf file. When the workspace's source is 'Remote' (the default) this can be any address supported by terraform init -from-module, for example a git repository or an S3 bucket. When the workspace's source is 'Inline' the content of a simple main.tf or main.tf.json file may be written inline.</summary>
    [JsonPropertyName("module")]
    public string Module { get; set; }

    /// <summary>Arguments to be included in the terraform plan CLI command</summary>
    [JsonPropertyName("planArgs")]
    public IList<string>? PlanArgs { get; set; }

    /// <summary>Source of the root module of this workspace.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderSourceEnum>))]
    public V1beta1WorkspaceSpecForProviderSourceEnum Source { get; set; }

    /// <summary>Files of configuration variables. Explicitly declared vars take precedence.</summary>
    [JsonPropertyName("varFiles")]
    public IList<V1beta1WorkspaceSpecForProviderVarFiles>? VarFiles { get; set; }

    /// <summary>Terraform Variable Map. Should be a valid JSON representation of the input vars</summary>
    [JsonPropertyName("varmap")]
    public JsonNode? Varmap { get; set; }

    /// <summary>Configuration variables.</summary>
    [JsonPropertyName("vars")]
    public IList<V1beta1WorkspaceSpecForProviderVars>? Vars { get; set; }
}

public enum V1beta1WorkspaceSpecManagementPoliciesEnum
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

public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1WorkspaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WorkspaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecDeletionPolicyEnum>))]
    public V1beta1WorkspaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary>WorkspaceParameters are the configurable fields of a Workspace.</summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkspaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkspaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1WorkspaceStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputs")]
    public IDictionary<string, JsonNode>? Outputs { get; set; }
}

public partial class V1beta1WorkspaceStatusConditions
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

public partial class V1beta1WorkspaceStatus
{
    /// <summary>WorkspaceObservation are the observable fields of a Workspace.</summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSpec>, IStatus<V1beta1WorkspaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "tf.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A WorkspaceSpec defines the desired state of a Workspace.</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkspaceSpec Spec { get; set; }

    /// <summary>A WorkspaceStatus represents the observed state of a Workspace.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspaceStatus? Status { get; set; }
}