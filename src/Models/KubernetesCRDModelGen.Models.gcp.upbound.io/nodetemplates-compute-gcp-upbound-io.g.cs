using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecForProviderNodeTypeFlexibility
{
    /// <summary>Number of virtual CPUs to use.</summary>
    [JsonPropertyName("cpus")]
    public string? Cpus { get; set; }

    /// <summary>Physical memory available to the node, defined in MB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecForProviderServerBinding
{
    /// <summary>Type of server binding policy. If RESTART_NODE_ON_ANY_SERVER, nodes using this template will restart on any physical server following a maintenance event. If RESTART_NODE_ON_MINIMAL_SERVER, nodes using this template will restart on the same physical server following a maintenance event, instead of being live migrated to or restarted on a new physical server. This option may be useful if you are using software licenses tied to the underlying server characteristics such as physical sockets or cores, to avoid the need for additional licenses when maintenance occurs. However, VMs on such nodes will experience outages while maintenance is applied. Possible values are: RESTART_NODE_ON_ANY_SERVER, RESTART_NODE_ON_MINIMAL_SERVERS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecForProvider
{
    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Labels to use for node affinity, which will be used in instance scheduling.</summary>
    [JsonPropertyName("nodeAffinityLabels")]
    public IDictionary<string, string>? NodeAffinityLabels { get; set; }

    /// <summary>Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public IList<V1beta1NodeTemplateSpecForProviderNodeTypeFlexibility>? NodeTypeFlexibility { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where nodes using the node template will be created. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
    [JsonPropertyName("serverBinding")]
    public IList<V1beta1NodeTemplateSpecForProviderServerBinding>? ServerBinding { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecInitProviderNodeTypeFlexibility
{
    /// <summary>Number of virtual CPUs to use.</summary>
    [JsonPropertyName("cpus")]
    public string? Cpus { get; set; }

    /// <summary>Physical memory available to the node, defined in MB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecInitProviderServerBinding
{
    /// <summary>Type of server binding policy. If RESTART_NODE_ON_ANY_SERVER, nodes using this template will restart on any physical server following a maintenance event. If RESTART_NODE_ON_MINIMAL_SERVER, nodes using this template will restart on the same physical server following a maintenance event, instead of being live migrated to or restarted on a new physical server. This option may be useful if you are using software licenses tied to the underlying server characteristics such as physical sockets or cores, to avoid the need for additional licenses when maintenance occurs. However, VMs on such nodes will experience outages while maintenance is applied. Possible values are: RESTART_NODE_ON_ANY_SERVER, RESTART_NODE_ON_MINIMAL_SERVERS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecInitProvider
{
    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Labels to use for node affinity, which will be used in instance scheduling.</summary>
    [JsonPropertyName("nodeAffinityLabels")]
    public IDictionary<string, string>? NodeAffinityLabels { get; set; }

    /// <summary>Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public IList<V1beta1NodeTemplateSpecInitProviderNodeTypeFlexibility>? NodeTypeFlexibility { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
    [JsonPropertyName("serverBinding")]
    public IList<V1beta1NodeTemplateSpecInitProviderServerBinding>? ServerBinding { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecProviderConfigRefPolicy
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
public partial class V1beta1NodeTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1NodeTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1NodeTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NodeTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NodeTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NodeTemplateSpec defines the desired state of NodeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodeTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodeTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodeTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NodeTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodeTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusAtProviderNodeTypeFlexibility
{
    /// <summary>Number of virtual CPUs to use.</summary>
    [JsonPropertyName("cpus")]
    public string? Cpus { get; set; }

    /// <summary>(Output) Use local SSD</summary>
    [JsonPropertyName("localSsd")]
    public string? LocalSsd { get; set; }

    /// <summary>Physical memory available to the node, defined in MB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusAtProviderServerBinding
{
    /// <summary>Type of server binding policy. If RESTART_NODE_ON_ANY_SERVER, nodes using this template will restart on any physical server following a maintenance event. If RESTART_NODE_ON_MINIMAL_SERVER, nodes using this template will restart on the same physical server following a maintenance event, instead of being live migrated to or restarted on a new physical server. This option may be useful if you are using software licenses tied to the underlying server characteristics such as physical sockets or cores, to avoid the need for additional licenses when maintenance occurs. However, VMs on such nodes will experience outages while maintenance is applied. Possible values are: RESTART_NODE_ON_ANY_SERVER, RESTART_NODE_ON_MINIMAL_SERVERS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusAtProvider
{
    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/nodeTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Labels to use for node affinity, which will be used in instance scheduling.</summary>
    [JsonPropertyName("nodeAffinityLabels")]
    public IDictionary<string, string>? NodeAffinityLabels { get; set; }

    /// <summary>Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public IList<V1beta1NodeTemplateStatusAtProviderNodeTypeFlexibility>? NodeTypeFlexibility { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where nodes using the node template will be created. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
    [JsonPropertyName("serverBinding")]
    public IList<V1beta1NodeTemplateStatusAtProviderServerBinding>? ServerBinding { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusConditions
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

/// <summary>NodeTemplateStatus defines the observed state of NodeTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NodeTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodeTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodeTemplate is the Schema for the NodeTemplates API. Represents a NodeTemplate resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodeTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodeTemplateSpec>, IStatus<V1beta1NodeTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodeTemplate";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "nodetemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodeTemplateSpec defines the desired state of NodeTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1NodeTemplateSpec Spec { get; set; }

    /// <summary>NodeTemplateStatus defines the observed state of NodeTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodeTemplateStatus? Status { get; set; }
}