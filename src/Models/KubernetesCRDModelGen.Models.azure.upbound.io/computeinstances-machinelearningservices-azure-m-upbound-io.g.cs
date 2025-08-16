using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.m.upbound.io;
/// <summary>ComputeInstance is the Schema for the ComputeInstances API. Manages a Machine Learning Compute Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeInstanceList";
    public const string KubeGroup = "machinelearningservices.azure.m.upbound.io";
    public const string KubePluralName = "computeinstances";
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
    public IList<V1beta1ComputeInstance> Items { get; set; }
}

/// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderAssignToUser
{
    /// <summary>User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderSsh
{
    /// <summary>Specifies the SSH rsa public key file as a string. Use "ssh-keygen -t rsa -b 2048" to generate your SSH key pairs.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderSubnetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderSubnetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecForProviderSubnetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderSubnetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProviderSubnetResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecForProviderSubnetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecForProvider
{
    /// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("assignToUser")]
    public V1beta1ComputeInstanceSpecForProviderAssignToUser? AssignToUser { get; set; }

    /// <summary>The Compute Instance Authorization type. Possible values include: personal. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>The description of the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeInstanceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>The ID of the Machine Learning Workspace. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdRef")]
    public V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdRef? MachineLearningWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdSelector")]
    public V1beta1ComputeInstanceSpecForProviderMachineLearningWorkspaceIdSelector? MachineLearningWorkspaceIdSelector { get; set; }

    /// <summary>Whether the compute instance will have a public ip. To set this to false a subnet_resource_id needs to be set. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeInstanceSpecForProviderSsh? Ssh { get; set; }

    /// <summary>Virtual network subnet resource ID the compute nodes belong to. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdRef")]
    public V1beta1ComputeInstanceSpecForProviderSubnetResourceIdRef? SubnetResourceIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdSelector")]
    public V1beta1ComputeInstanceSpecForProviderSubnetResourceIdSelector? SubnetResourceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Virtual Machine Size. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderAssignToUser
{
    /// <summary>User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderSsh
{
    /// <summary>Specifies the SSH rsa public key file as a string. Use "ssh-keygen -t rsa -b 2048" to generate your SSH key pairs.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecInitProvider
{
    /// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("assignToUser")]
    public V1beta1ComputeInstanceSpecInitProviderAssignToUser? AssignToUser { get; set; }

    /// <summary>The Compute Instance Authorization type. Possible values include: personal. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>The description of the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeInstanceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Whether the compute instance will have a public ip. To set this to false a subnet_resource_id needs to be set. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeInstanceSpecInitProviderSsh? Ssh { get; set; }

    /// <summary>Virtual network subnet resource ID the compute nodes belong to. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdRef")]
    public V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdRef? SubnetResourceIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdSelector")]
    public V1beta1ComputeInstanceSpecInitProviderSubnetResourceIdSelector? SubnetResourceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Virtual Machine Size. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpecProviderConfigRef
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
public partial class V1beta1ComputeInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ComputeInstanceSpec defines the desired state of ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ComputeInstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ComputeInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ComputeInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ComputeInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatusAtProviderAssignToUser
{
    /// <summary>User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this Machine Learning Compute Instance.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this Machine Learning Compute Instance.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatusAtProviderSsh
{
    /// <summary>Describes the port for connecting through SSH.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specifies the SSH rsa public key file as a string. Use "ssh-keygen -t rsa -b 2048" to generate your SSH key pairs.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The admin username of this Machine Learning Compute Instance.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatusAtProvider
{
    /// <summary>A assign_to_user block as defined below. A user explicitly assigned to a personal compute instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("assignToUser")]
    public V1beta1ComputeInstanceStatusAtProviderAssignToUser? AssignToUser { get; set; }

    /// <summary>The Compute Instance Authorization type. Possible values include: personal. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>The description of the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Machine Learning Compute Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeInstanceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>The ID of the Machine Learning Workspace. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Whether the compute instance will have a public ip. To set this to false a subnet_resource_id needs to be set. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A ssh block as defined below. Specifies policy and settings for SSH access. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeInstanceStatusAtProviderSsh? Ssh { get; set; }

    /// <summary>Virtual network subnet resource ID the compute nodes belong to. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Instance. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Virtual Machine Size. Changing this forces a new Machine Learning Compute Instance to be created.</summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatusConditions
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

/// <summary>ComputeInstanceStatus defines the observed state of ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ComputeInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ComputeInstance is the Schema for the ComputeInstances API. Manages a Machine Learning Compute Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeInstanceSpec>, IStatus<V1beta1ComputeInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeInstance";
    public const string KubeGroup = "machinelearningservices.azure.m.upbound.io";
    public const string KubePluralName = "computeinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeInstanceSpec defines the desired state of ComputeInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeInstanceSpec Spec { get; set; }

    /// <summary>ComputeInstanceStatus defines the observed state of ComputeInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeInstanceStatus? Status { get; set; }
}