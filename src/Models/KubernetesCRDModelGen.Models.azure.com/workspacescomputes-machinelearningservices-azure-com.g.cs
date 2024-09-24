using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210701storageWorkspacesComputeSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20210701.Identity Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210701storageWorkspacesComputeSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.AksNetworkingConfiguration Advance configuration for AKS networking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference? SubnetReference { get; set; }
}

/// <summary>Storage version of v1api20210701.SslConfiguration The ssl configuration for scoring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leafDomainLabel")]
    public string? LeafDomainLabel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("overwriteExistingDomain")]
    public bool? OverwriteExistingDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210701.AKS_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>Storage version of v1api20210701.AksNetworkingConfiguration Advance configuration for AKS networking</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterPurpose")]
    public string? ClusterPurpose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerSubnet")]
    public string? LoadBalancerSubnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Storage version of v1api20210701.SslConfiguration The ssl configuration for scoring</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAksResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.AKS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.AKS_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAksResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.ScaleSettings scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeIdleTimeBeforeScaleDown")]
    public string? NodeIdleTimeBeforeScaleDown { get; set; }
}

/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference Reference { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210701.UserAccountCredentials Settings for user account that gets created on each on the nodes of a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminUserPassword")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword? AdminUserPassword { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminUserSshPublicKey")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey? AdminUserSshPublicKey { get; set; }
}

/// <summary>Reference: Virtual Machine image path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineImage Virtual Machine image for Windows AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Virtual Machine image path</summary>
    [JsonPropertyName("reference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference Reference { get; set; }
}

/// <summary>Storage version of v1api20210701.AmlComputeProperties AML Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public string? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>Storage version of v1api20210701.ScaleSettings scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Storage version of v1api20210701.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>Storage version of v1api20210701.UserAccountCredentials Settings for user account that gets created on each on the nodes of a compute.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineImage Virtual Machine image for Windows AML Compute</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputeResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesAmlCompute
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.AmlComputeProperties AML Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlComputeResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.AssignedUser A user that can be assigned to a compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20210701.PersonalComputeInstanceSettings Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AssignedUser A user that can be assigned to a compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptReference Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptReference Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptsToExecute Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptReference Script reference</summary>
    [JsonPropertyName("creationScript")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptReference Script reference</summary>
    [JsonPropertyName("startupScript")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>Storage version of v1api20210701.SetupScripts Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptsToExecute Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceSshSettings Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminPublicKey")]
    public string? AdminPublicKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicAccess")]
    public string? SshPublicAccess { get; set; }
}

/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference Reference { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceProperties Compute Instance properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstanceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public string? ApplicationSharingPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public string? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>Storage version of v1api20210701.PersonalComputeInstanceSettings Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Storage version of v1api20210701.SetupScripts Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceSshSettings Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>Storage version of v1api20210701.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstanceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstance
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceProperties Compute Instance properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstanceResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDataFactoryResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.DataFactory</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDataFactory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDataFactoryResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.DataLakeAnalytics_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.DataLakeAnalytics</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalytics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.DataLakeAnalytics_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.DatabricksProperties Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDatabricksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databricksAccessToken")]
    public string? DatabricksAccessToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDatabricksResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesDatabricks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.DatabricksProperties Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDatabricksResourceReference? ResourceReference { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateKeyData")]
    public string? PrivateKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeyData")]
    public string? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20210701.HDInsightProperties HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.HDInsight</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesHdInsight
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.HDInsightProperties HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesHdInsightResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.InstanceTypeSchema_Resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Storage version of v1api20210701.InstanceTypeSchema Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Storage version of v1api20210701.InstanceTypeSchema_Resources</summary>
    [JsonPropertyName("resources")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210701.KubernetesProperties Kubernetes properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultInstanceType")]
    public string? DefaultInstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionInstanceReleaseTrain")]
    public string? ExtensionInstanceReleaseTrain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionPrincipalId")]
    public string? ExtensionPrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceTypes")]
    public IDictionary<string, V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("relayConnectionString")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString? RelayConnectionString { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("serviceBusConnectionString")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString? ServiceBusConnectionString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.Kubernetes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesKubernetes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.KubernetesProperties Kubernetes properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetesResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.AutoPauseProperties Auto pause properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20210701.AutoScaleProperties Auto scale properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Storage version of v1api20210701.SynapseSpark_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AutoPauseProperties Auto pause properties</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>Storage version of v1api20210701.AutoScaleProperties Auto scale properties</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.SynapseSpark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSpark
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.SynapseSpark_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSparkResourceReference? ResourceReference { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateKeyData")]
    public string? PrivateKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeyData")]
    public string? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachine_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachineProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachineResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachine
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachine_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachineResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20210701.Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AKS</summary>
    [JsonPropertyName("aks")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAks? Aks { get; set; }

    /// <summary>Storage version of v1api20210701.AmlCompute</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstance</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>Storage version of v1api20210701.DataFactory</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>Storage version of v1api20210701.DataLakeAnalytics</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Storage version of v1api20210701.Databricks</summary>
    [JsonPropertyName("databricks")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesDatabricks? Databricks { get; set; }

    /// <summary>Storage version of v1api20210701.HDInsight</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Storage version of v1api20210701.Kubernetes</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>Storage version of v1api20210701.SynapseSpark</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachine</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20210701storageWorkspacesComputeSpecPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>Storage version of v1api20210701.Sku Sku of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20210701.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpecSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20210701.Workspaces_Compute_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20210701.Identity Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspacesComputeSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210701storageWorkspacesComputeSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20210701.Compute</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeSpecProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20210701.Sku Sku of the resource</summary>
    [JsonPropertyName("sku")]
    public V1api20210701storageWorkspacesComputeSpecSku? Sku { get; set; }

    /// <summary>Storage version of v1api20210701.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701storageWorkspacesComputeSpecSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20210701.UserAssignedIdentity_STATUS User Assigned Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20210701.Identity_STATUS Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210701storageWorkspacesComputeStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20210701.AksNetworkingConfiguration_STATUS Advance configuration for AKS networking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>Storage version of v1api20210701.SslConfiguration_STATUS The ssl configuration for scoring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leafDomainLabel")]
    public string? LeafDomainLabel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("overwriteExistingDomain")]
    public bool? OverwriteExistingDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210701.SystemService_STATUS A system service running on a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesSystemServices
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("systemServiceType")]
    public string? SystemServiceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Storage version of v1api20210701.AKS_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>Storage version of v1api20210701.AksNetworkingConfiguration_STATUS Advance configuration for AKS networking</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterPurpose")]
    public string? ClusterPurpose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerSubnet")]
    public string? LoadBalancerSubnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Storage version of v1api20210701.SslConfiguration_STATUS The ssl configuration for scoring</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("systemServices")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAksPropertiesSystemServices>? SystemServices { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.AKS_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.AKS_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAksProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.NodeStateCounts_STATUS Counts of various compute node states on the amlCompute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleNodeCount")]
    public int? IdleNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leavingNodeCount")]
    public int? LeavingNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preemptedNodeCount")]
    public int? PreemptedNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preparingNodeCount")]
    public int? PreparingNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runningNodeCount")]
    public int? RunningNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unusableNodeCount")]
    public int? UnusableNodeCount { get; set; }
}

/// <summary>Storage version of v1api20210701.ScaleSettings_STATUS scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeIdleTimeBeforeScaleDown")]
    public string? NodeIdleTimeBeforeScaleDown { get; set; }
}

/// <summary>Storage version of v1api20210701.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20210701.UserAccountCredentials_STATUS Settings for user account that gets created on each on the nodes of a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineImage_STATUS Virtual Machine image for Windows AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20210701.AmlComputeProperties_STATUS AML Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allocationState")]
    public string? AllocationState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allocationStateTransitionTime")]
    public string? AllocationStateTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentNodeCount")]
    public int? CurrentNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrors>? Errors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary>Storage version of v1api20210701.NodeStateCounts_STATUS Counts of various compute node states on the amlCompute.</summary>
    [JsonPropertyName("nodeStateCounts")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts? NodeStateCounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public string? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>Storage version of v1api20210701.ScaleSettings_STATUS scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Storage version of v1api20210701.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetNodeCount")]
    public int? TargetNodeCount { get; set; }

    /// <summary>Storage version of v1api20210701.UserAccountCredentials_STATUS Settings for user account that gets created on each on the nodes of a compute.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineImage_STATUS Virtual Machine image for Windows AML Compute</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.AmlCompute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesAmlCompute
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.AmlComputeProperties_STATUS AML Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceApplication_STATUS Defines an Aml Instance application and its connectivity endpoint URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceConnectivityEndpoints_STATUS Defines all connectivity endpoints and properties for an ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceCreatedBy_STATUS Describes information on user who created this ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userOrgId")]
    public string? UserOrgId { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceLastOperation_STATUS The last operation on ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationStatus")]
    public string? OperationStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationTime")]
    public string? OperationTime { get; set; }
}

/// <summary>Storage version of v1api20210701.AssignedUser_STATUS A user that can be assigned to a compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20210701.PersonalComputeInstanceSettings_STATUS Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AssignedUser_STATUS A user that can be assigned to a compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptReference_STATUS Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptReference_STATUS Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Storage version of v1api20210701.ScriptsToExecute_STATUS Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptReference_STATUS Script reference</summary>
    [JsonPropertyName("creationScript")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptReference_STATUS Script reference</summary>
    [JsonPropertyName("startupScript")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>Storage version of v1api20210701.SetupScripts_STATUS Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ScriptsToExecute_STATUS Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceSshSettings_STATUS Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminPublicKey")]
    public string? AdminPublicKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicAccess")]
    public string? SshPublicAccess { get; set; }
}

/// <summary>Storage version of v1api20210701.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstanceProperties_STATUS Compute Instance properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public string? ApplicationSharingPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applications")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications>? Applications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public string? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceConnectivityEndpoints_STATUS Defines all connectivity endpoints and properties for an ComputeInstance.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints? ConnectivityEndpoints { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceCreatedBy_STATUS Describes information on user who created this ComputeInstance.</summary>
    [JsonPropertyName("createdBy")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors>? Errors { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceLastOperation_STATUS The last operation on ComputeInstance.</summary>
    [JsonPropertyName("lastOperation")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation? LastOperation { get; set; }

    /// <summary>Storage version of v1api20210701.PersonalComputeInstanceSettings_STATUS Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Storage version of v1api20210701.SetupScripts_STATUS Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceSshSettings_STATUS Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage version of v1api20210701.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.ComputeInstance_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstance
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstanceProperties_STATUS Compute Instance properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.DataFactory_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataFactory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.DataLakeAnalytics_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.DataLakeAnalytics_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalytics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.DataLakeAnalytics_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.DatabricksProperties_STATUS Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databricksAccessToken")]
    public string? DatabricksAccessToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.Databricks_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesDatabricks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.DatabricksProperties_STATUS Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateKeyData")]
    public string? PrivateKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeyData")]
    public string? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20210701.HDInsightProperties_STATUS HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.HDInsight_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesHdInsight
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.HDInsightProperties_STATUS HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.InstanceTypeSchema_Resources_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Storage version of v1api20210701.InstanceTypeSchema_STATUS Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Storage version of v1api20210701.InstanceTypeSchema_Resources_STATUS</summary>
    [JsonPropertyName("resources")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>Storage version of v1api20210701.KubernetesProperties_STATUS Kubernetes properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultInstanceType")]
    public string? DefaultInstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionInstanceReleaseTrain")]
    public string? ExtensionInstanceReleaseTrain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionPrincipalId")]
    public string? ExtensionPrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceTypes")]
    public IDictionary<string, V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.Kubernetes_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesKubernetes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.KubernetesProperties_STATUS Kubernetes properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.AutoPauseProperties_STATUS Auto pause properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20210701.AutoScaleProperties_STATUS Auto scale properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Storage version of v1api20210701.SynapseSpark_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AutoPauseProperties_STATUS Auto pause properties</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>Storage version of v1api20210701.AutoScaleProperties_STATUS Auto scale properties</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.SynapseSpark_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSpark
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.SynapseSpark_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateKeyData")]
    public string? PrivateKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeyData")]
    public string? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachine_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20210701.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError? Error { get; set; }
}

/// <summary>Storage version of v1api20210701.VirtualMachine_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachine
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachine_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.Compute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.AKS_STATUS</summary>
    [JsonPropertyName("aks")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAks? Aks { get; set; }

    /// <summary>Storage version of v1api20210701.AmlCompute_STATUS</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>Storage version of v1api20210701.ComputeInstance_STATUS</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>Storage version of v1api20210701.DataFactory_STATUS</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>Storage version of v1api20210701.DataLakeAnalytics_STATUS</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Storage version of v1api20210701.Databricks_STATUS</summary>
    [JsonPropertyName("databricks")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesDatabricks? Databricks { get; set; }

    /// <summary>Storage version of v1api20210701.HDInsight_STATUS</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Storage version of v1api20210701.Kubernetes_STATUS</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>Storage version of v1api20210701.SynapseSpark_STATUS</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>Storage version of v1api20210701.VirtualMachine_STATUS</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20210701storageWorkspacesComputeStatusPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>Storage version of v1api20210701.Sku_STATUS Sku of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20210701.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20210701.Workspaces_Compute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701storageWorkspacesComputeStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210701storageWorkspacesComputeStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20210701.Identity_STATUS Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspacesComputeStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210701.Compute_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20210701storageWorkspacesComputeStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20210701.Sku_STATUS Sku of the resource</summary>
    [JsonPropertyName("sku")]
    public V1api20210701storageWorkspacesComputeStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20210701.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701storageWorkspacesComputeStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210701.WorkspacesCompute Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210701storageWorkspacesCompute : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210701storageWorkspacesComputeSpec>, IStatus<V1api20210701storageWorkspacesComputeStatus>
{
    public const string KubeApiVersion = "v1api20210701storage";
    public const string KubeKind = "WorkspacesCompute";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacescomputes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210701.Workspaces_Compute_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210701storageWorkspacesComputeSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210701.Workspaces_Compute_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210701storageWorkspacesComputeStatus? Status { get; set; }
}