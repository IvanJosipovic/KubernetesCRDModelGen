using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecForProviderAccelerators
{
    /// <summary>The number of the guest accelerator cards exposed to this node template.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL of the accelerator type resource to expose to this node template.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecForProviderDisks
{
    /// <summary>Specifies the number of such disks.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }
}

/// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
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

/// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
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
    /// <summary>List of the type and count of accelerator cards attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1NodeTemplateSpecForProviderAccelerators>? Accelerators { get; set; }

    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of the type, size and count of disks attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("disks")]
    public IList<V1beta1NodeTemplateSpecForProviderDisks>? Disks { get; set; }

    /// <summary>Labels to use for node affinity, which will be used in instance scheduling.</summary>
    [JsonPropertyName("nodeAffinityLabels")]
    public IDictionary<string, string>? NodeAffinityLabels { get; set; }

    /// <summary>Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1NodeTemplateSpecForProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where nodes using the node template will be created. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
    [JsonPropertyName("serverBinding")]
    public V1beta1NodeTemplateSpecForProviderServerBinding? ServerBinding { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecInitProviderAccelerators
{
    /// <summary>The number of the guest accelerator cards exposed to this node template.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL of the accelerator type resource to expose to this node template.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecInitProviderDisks
{
    /// <summary>Specifies the number of such disks.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }
}

/// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
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

/// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
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
    /// <summary>List of the type and count of accelerator cards attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1NodeTemplateSpecInitProviderAccelerators>? Accelerators { get; set; }

    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of the type, size and count of disks attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("disks")]
    public IList<V1beta1NodeTemplateSpecInitProviderDisks>? Disks { get; set; }

    /// <summary>Labels to use for node affinity, which will be used in instance scheduling.</summary>
    [JsonPropertyName("nodeAffinityLabels")]
    public IDictionary<string, string>? NodeAffinityLabels { get; set; }

    /// <summary>Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1NodeTemplateSpecInitProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
    [JsonPropertyName("serverBinding")]
    public V1beta1NodeTemplateSpecInitProviderServerBinding? ServerBinding { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NodeTemplateSpec defines the desired state of NodeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodeTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodeTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodeTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodeTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusAtProviderAccelerators
{
    /// <summary>The number of the guest accelerator cards exposed to this node template.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL of the accelerator type resource to expose to this node template.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeTemplateStatusAtProviderDisks
{
    /// <summary>Specifies the number of such disks.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>Specifies the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }
}

/// <summary>Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified. Structure is documented below.</summary>
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

/// <summary>The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event. Structure is documented below.</summary>
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
    /// <summary>List of the type and count of accelerator cards attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1NodeTemplateStatusAtProviderAccelerators>? Accelerators { get; set; }

    /// <summary>CPU overcommit. Default value is NONE. Possible values are: ENABLED, NONE.</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of the type, size and count of disks attached to the node template Structure is documented below.</summary>
    [JsonPropertyName("disks")]
    public IList<V1beta1NodeTemplateStatusAtProviderDisks>? Disks { get; set; }

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
    public V1beta1NodeTemplateStatusAtProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

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
    public V1beta1NodeTemplateStatusAtProviderServerBinding? ServerBinding { get; set; }
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
    public const string KubeGroup = "compute.gcp.m.upbound.io";
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

/// <summary>NodeTemplate is the Schema for the NodeTemplates API. Represents a NodeTemplate resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodeTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NodeTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodeTemplateList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "nodetemplates";
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
    public IList<V1beta1NodeTemplate> Items { get; set; }
}