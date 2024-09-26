using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecForProviderOptionOptionSettings
{
    /// <summary>Name of the setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the setting.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecForProviderOption
{
    /// <summary>List of DB Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("dbSecurityGroupMemberships")]
    public IList<string>? DbSecurityGroupMemberships { get; set; }

    /// <summary>Name of the option (e.g., MEMCACHED).</summary>
    [JsonPropertyName("optionName")]
    public string? OptionName { get; set; }

    /// <summary>The option settings to apply. See option_settings Block below for more details.</summary>
    [JsonPropertyName("optionSettings")]
    public IList<V1beta1OptionGroupSpecForProviderOptionOptionSettings>? OptionSettings { get; set; }

    /// <summary>Port number when connecting to the option (e.g., 11211). Leaving out or removing port from your configuration does not remove or clear a port from the option in AWS. AWS may assign a default port. Not including port in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any port changes.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Version of the option (e.g., 13.1.0.0). Leaving out or removing version from your configuration does not remove or clear a version from the option in AWS. AWS may assign a default version. Not including version in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any version changes.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>List of VPC Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("vpcSecurityGroupMemberships")]
    public IList<string>? VpcSecurityGroupMemberships { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecForProvider
{
    /// <summary>Specifies the name of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>Specifies the major version of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("majorEngineVersion")]
    public string? MajorEngineVersion { get; set; }

    /// <summary>The options to apply. See option Block below for more details.</summary>
    [JsonPropertyName("option")]
    public IList<V1beta1OptionGroupSpecForProviderOption>? Option { get; set; }

    /// <summary>Description of the option group.</summary>
    [JsonPropertyName("optionGroupDescription")]
    public string? OptionGroupDescription { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecInitProviderOptionOptionSettings
{
    /// <summary>Name of the setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the setting.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecInitProviderOption
{
    /// <summary>List of DB Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("dbSecurityGroupMemberships")]
    public IList<string>? DbSecurityGroupMemberships { get; set; }

    /// <summary>Name of the option (e.g., MEMCACHED).</summary>
    [JsonPropertyName("optionName")]
    public string? OptionName { get; set; }

    /// <summary>The option settings to apply. See option_settings Block below for more details.</summary>
    [JsonPropertyName("optionSettings")]
    public IList<V1beta1OptionGroupSpecInitProviderOptionOptionSettings>? OptionSettings { get; set; }

    /// <summary>Port number when connecting to the option (e.g., 11211). Leaving out or removing port from your configuration does not remove or clear a port from the option in AWS. AWS may assign a default port. Not including port in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any port changes.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Version of the option (e.g., 13.1.0.0). Leaving out or removing version from your configuration does not remove or clear a version from the option in AWS. AWS may assign a default version. Not including version in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any version changes.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>List of VPC Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("vpcSecurityGroupMemberships")]
    public IList<string>? VpcSecurityGroupMemberships { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecInitProvider
{
    /// <summary>Specifies the name of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>Specifies the major version of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("majorEngineVersion")]
    public string? MajorEngineVersion { get; set; }

    /// <summary>The options to apply. See option Block below for more details.</summary>
    [JsonPropertyName("option")]
    public IList<V1beta1OptionGroupSpecInitProviderOption>? Option { get; set; }

    /// <summary>Description of the option group.</summary>
    [JsonPropertyName("optionGroupDescription")]
    public string? OptionGroupDescription { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecProviderConfigRefPolicy
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
public partial class V1beta1OptionGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OptionGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1OptionGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OptionGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1OptionGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1OptionGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1OptionGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>OptionGroupSpec defines the desired state of OptionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OptionGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OptionGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OptionGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1OptionGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OptionGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupStatusAtProviderOptionOptionSettings
{
    /// <summary>Name of the setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the setting.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupStatusAtProviderOption
{
    /// <summary>List of DB Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("dbSecurityGroupMemberships")]
    public IList<string>? DbSecurityGroupMemberships { get; set; }

    /// <summary>Name of the option (e.g., MEMCACHED).</summary>
    [JsonPropertyName("optionName")]
    public string? OptionName { get; set; }

    /// <summary>The option settings to apply. See option_settings Block below for more details.</summary>
    [JsonPropertyName("optionSettings")]
    public IList<V1beta1OptionGroupStatusAtProviderOptionOptionSettings>? OptionSettings { get; set; }

    /// <summary>Port number when connecting to the option (e.g., 11211). Leaving out or removing port from your configuration does not remove or clear a port from the option in AWS. AWS may assign a default port. Not including port in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any port changes.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Version of the option (e.g., 13.1.0.0). Leaving out or removing version from your configuration does not remove or clear a version from the option in AWS. AWS may assign a default version. Not including version in your configuration means that the AWS provider will ignore a previously set value, a value set by AWS, and any version changes.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>List of VPC Security Groups for which the option is enabled.</summary>
    [JsonPropertyName("vpcSecurityGroupMemberships")]
    public IList<string>? VpcSecurityGroupMemberships { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupStatusAtProvider
{
    /// <summary>ARN of the DB option group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies the name of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>DB option group name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the major version of the engine that this option group should be associated with.</summary>
    [JsonPropertyName("majorEngineVersion")]
    public string? MajorEngineVersion { get; set; }

    /// <summary>The options to apply. See option Block below for more details.</summary>
    [JsonPropertyName("option")]
    public IList<V1beta1OptionGroupStatusAtProviderOption>? Option { get; set; }

    /// <summary>Description of the option group.</summary>
    [JsonPropertyName("optionGroupDescription")]
    public string? OptionGroupDescription { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupStatusConditions
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

/// <summary>OptionGroupStatus defines the observed state of OptionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OptionGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OptionGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OptionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OptionGroup is the Schema for the OptionGroups API. Provides an RDS DB option group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OptionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OptionGroupSpec>, IStatus<V1beta1OptionGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OptionGroup";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "optiongroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OptionGroupSpec defines the desired state of OptionGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1OptionGroupSpec Spec { get; set; }

    /// <summary>OptionGroupStatus defines the observed state of OptionGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1OptionGroupStatus? Status { get; set; }
}