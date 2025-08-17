using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
#nullable enable
/// <summary>Storage version of v1api20240401.WorkspacesCompute Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/machineLearningServices.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspacesComputeList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401storageWorkspacesCompute>
{
    public const string KubeApiVersion = "v1api20240401storage";
    public const string KubeKind = "WorkspacesComputeList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1api20240401storageWorkspacesCompute> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecIdentityUserAssignedIdentitiesReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspacesComputeSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ManagedServiceIdentity Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240401storageWorkspacesComputeSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.WorkspacesComputeOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401storageWorkspacesComputeSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401storageWorkspacesComputeSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AksNetworkingConfiguration Advance configuration for AKS networking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration
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
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference? SubnetReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LoadBalancerSubnetReference: Load Balancer Subnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerSubnetReference
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
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SslConfiguration The ssl configuration for scoring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("cert")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert? Cert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("key")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey? Key { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AKS_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksProperties
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

    /// <summary>Storage version of v1api20240401.AksNetworkingConfiguration Advance configuration for AKS networking</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterPurpose")]
    public string? ClusterPurpose { get; set; }

    /// <summary>LoadBalancerSubnetReference: Load Balancer Subnet</summary>
    [JsonPropertyName("loadBalancerSubnetReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerSubnetReference? LoadBalancerSubnetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>Storage version of v1api20240401.SslConfiguration The ssl configuration for scoring</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAksResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AKS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAks
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

    /// <summary>Storage version of v1api20240401.AKS_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAksResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScaleSettings scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings
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
#nullable disable

#nullable enable
/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.UserAccountCredentials Settings for user account that gets created on each on the nodes of a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminUserPassword")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword? AdminUserPassword { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminUserSshPublicKey")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey? AdminUserSshPublicKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Virtual Machine image path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineImage Virtual Machine image for Windows AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Virtual Machine image path</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AmlComputeProperties AML Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputeProperties
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
    [JsonPropertyName("propertyBag1")]
    public IDictionary<string, JsonNode>? PropertyBag1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public string? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>Storage version of v1api20240401.ScaleSettings scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>Storage version of v1api20240401.UserAccountCredentials Settings for user account that gets created on each on the nodes of a compute.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineImage Virtual Machine image for Windows AML Compute</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputeResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesAmlCompute
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

    /// <summary>Storage version of v1api20240401.AmlComputeProperties AML Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlComputeResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Docker Docker container configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesDocker
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Endpoint Describes the endpoint configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIp")]
    public string? HostIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("published")]
    public int? Published { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public int? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.EnvironmentVariable Environment Variables for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Image Describes the Image Specifications</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.BindOptions Describes the bind options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesBind
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createHostPath")]
    public bool? CreateHostPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("propagation")]
    public string? Propagation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selinux")]
    public string? Selinux { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.TmpfsOptions Describes the tmpfs options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VolumeOptions Describes the volume options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesVolume
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nocopy")]
    public bool? Nocopy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VolumeDefinition Describes the volume configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.BindOptions Describes the bind options for the container</summary>
    [JsonPropertyName("bind")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesBind? Bind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Storage version of v1api20240401.TmpfsOptions Describes the tmpfs options for the container</summary>
    [JsonPropertyName("tmpfs")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs? Tmpfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240401.VolumeOptions Describes the volume options for the container</summary>
    [JsonPropertyName("volume")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesVolume? Volume { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.CustomService Specifies the custom service configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServices
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.Docker Docker container configuration</summary>
    [JsonPropertyName("docker")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesDocker? Docker { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpoints>? Endpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Storage version of v1api20240401.Image Describes the Image Specifications</summary>
    [JsonPropertyName("image")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImage? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserObjectIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AssignedUser A user that can be assigned to a compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserTenantIdFromConfig? TenantIdFromConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.PersonalComputeInstanceSettings Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AssignedUser A user that can be assigned to a compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Cron The workflow trigger cron for ComputeStartStop schedule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeRecurrenceSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthDays")]
    public IList<int>? MonthDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Recurrence The workflow trigger recurrence for ComputeStartStop schedule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeRecurrenceSchedule</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: A system assigned id for the schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScheduleBase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary>Reference: A system assigned id for the schedule.</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeStartStopSchedule Compute start stop schedule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStop
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Storage version of v1api20240401.Cron The workflow trigger cron for ComputeStartStop schedule type.</summary>
    [JsonPropertyName("cron")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron? Cron { get; set; }

    /// <summary>Storage version of v1api20240401.Recurrence The workflow trigger recurrence for ComputeStartStop schedule type.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence? Recurrence { get; set; }

    /// <summary>Storage version of v1api20240401.ScheduleBase</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeSchedules The list of schedules to be applied on the computes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeStartStop")]
    public IList<V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStop>? ComputeStartStop { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptReference Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptReference Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptsToExecute Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptReference Script reference</summary>
    [JsonPropertyName("creationScript")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptReference Script reference</summary>
    [JsonPropertyName("startupScript")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SetupScripts Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptsToExecute Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceSshSettings Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings
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
#nullable disable

#nullable enable
/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceProperties Compute Instance properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstanceProperties
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

    /// <summary></summary>
    [JsonPropertyName("customServices")]
    public IList<V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServices>? CustomServices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>Storage version of v1api20240401.PersonalComputeInstanceSettings Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeSchedules The list of schedules to be applied on the computes</summary>
    [JsonPropertyName("schedules")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedules? Schedules { get; set; }

    /// <summary>Storage version of v1api20240401.SetupScripts Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceSshSettings Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ResourceId Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstanceResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstance
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

    /// <summary>Storage version of v1api20240401.ComputeInstanceProperties Compute Instance properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstanceResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDataFactoryResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataFactory</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDataFactory
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
    public V1api20240401storageWorkspacesComputeSpecPropertiesDataFactoryResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataLakeAnalytics_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataLakeAnalytics</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalytics
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

    /// <summary>Storage version of v1api20240401.DataLakeAnalytics_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DatabricksProperties Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("databricksAccessToken")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken? DatabricksAccessToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesDatabricks
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

    /// <summary>Storage version of v1api20240401.DatabricksProperties Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDatabricksResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.HDInsightProperties HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.HDInsight</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesHdInsight
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

    /// <summary>Storage version of v1api20240401.HDInsightProperties HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsightResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesExtensionPrincipalIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.InstanceTypeSchema_Resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.InstanceTypeSchema Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Storage version of v1api20240401.InstanceTypeSchema_Resources</summary>
    [JsonPropertyName("resources")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.KubernetesProperties Kubernetes properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesProperties
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

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("extensionPrincipalIdFromConfig")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesExtensionPrincipalIdFromConfig? ExtensionPrincipalIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceTypes")]
    public IDictionary<string, V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("relayConnectionString")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString? RelayConnectionString { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("serviceBusConnectionString")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString? ServiceBusConnectionString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Kubernetes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesKubernetes
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

    /// <summary>Storage version of v1api20240401.KubernetesProperties Kubernetes properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetesResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AutoPauseProperties Auto pause properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AutoScaleProperties Auto scale properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SynapseSpark_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AutoPauseProperties Auto pause properties</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>Storage version of v1api20240401.AutoScaleProperties Auto scale properties</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

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
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SynapseSpark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSpark
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

    /// <summary>Storage version of v1api20240401.SynapseSpark_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSparkResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachine_Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachineProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookServerPort")]
    public int? NotebookServerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachineResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachine
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

    /// <summary>Storage version of v1api20240401.VirtualMachine_Properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachineResourceReference? ResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AKS</summary>
    [JsonPropertyName("aks")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAks? Aks { get; set; }

    /// <summary>Storage version of v1api20240401.AmlCompute</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstance</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>Storage version of v1api20240401.DataFactory</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>Storage version of v1api20240401.DataLakeAnalytics</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Storage version of v1api20240401.Databricks</summary>
    [JsonPropertyName("databricks")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesDatabricks? Databricks { get; set; }

    /// <summary>Storage version of v1api20240401.HDInsight</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Storage version of v1api20240401.Kubernetes</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>Storage version of v1api20240401.SynapseSpark</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachine</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20240401storageWorkspacesComputeSpecPropertiesVirtualMachine? VirtualMachine { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Sku The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.WorkspacesCompute_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedServiceIdentity Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspacesComputeSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspacesComputeOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401storageWorkspacesComputeSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240401storageWorkspacesComputeSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240401.Compute</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeSpecProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20240401.Sku The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20240401storageWorkspacesComputeSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.UserAssignedIdentity_STATUS User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusIdentityUserAssignedIdentities
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
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ManagedServiceIdentity_STATUS Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusIdentity
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
    public IDictionary<string, V1api20240401storageWorkspacesComputeStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AksNetworkingConfiguration_STATUS Advance configuration for AKS networking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SslConfiguration_STATUS The ssl configuration for scoring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SystemService_STATUS A system service running on a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesSystemServices
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AKS_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProperties
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

    /// <summary>Storage version of v1api20240401.AksNetworkingConfiguration_STATUS Advance configuration for AKS networking</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

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

    /// <summary>Storage version of v1api20240401.SslConfiguration_STATUS The ssl configuration for scoring</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("systemServices")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAksPropertiesSystemServices>? SystemServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AKS_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAks
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

    /// <summary>Storage version of v1api20240401.AKS_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAksProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.NodeStateCounts_STATUS Counts of various compute node states on the amlCompute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScaleSettings_STATUS scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.UserAccountCredentials_STATUS Settings for user account that gets created on each on the nodes of a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineImage_STATUS Virtual Machine image for Windows AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AmlComputeProperties_STATUS AML Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProperties
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
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesErrors>? Errors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary>Storage version of v1api20240401.NodeStateCounts_STATUS Counts of various compute node states on the amlCompute.</summary>
    [JsonPropertyName("nodeStateCounts")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts? NodeStateCounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("propertyBag1")]
    public IDictionary<string, JsonNode>? PropertyBag1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public string? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>Storage version of v1api20240401.ScaleSettings_STATUS scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetNodeCount")]
    public int? TargetNodeCount { get; set; }

    /// <summary>Storage version of v1api20240401.UserAccountCredentials_STATUS Settings for user account that gets created on each on the nodes of a compute.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineImage_STATUS Virtual Machine image for Windows AML Compute</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AmlCompute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesAmlCompute
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

    /// <summary>Storage version of v1api20240401.AmlComputeProperties_STATUS AML Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceApplication_STATUS Defines an Aml Instance application and its connectivity endpoint URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceConnectivityEndpoints_STATUS Defines all connectivity endpoints and properties for an ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceEnvironmentInfo_STATUS Environment information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesContainersEnvironment
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceContainer_STATUS Defines an Aml Instance container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesContainers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autosave")]
    public string? Autosave { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceEnvironmentInfo_STATUS Environment information</summary>
    [JsonPropertyName("environment")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesContainersEnvironment? Environment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpu")]
    public string? Gpu { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public IList<IDictionary<string, JsonNode>>? Services { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceCreatedBy_STATUS Describes information on user who created this ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Docker_STATUS Docker container configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesDocker
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Endpoint_STATUS Describes the endpoint configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIp")]
    public string? HostIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("published")]
    public int? Published { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public int? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.EnvironmentVariable_STATUS Environment Variables for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Image_STATUS Describes the Image Specifications</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.BindOptions_STATUS Describes the bind options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesBind
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createHostPath")]
    public bool? CreateHostPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("propagation")]
    public string? Propagation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selinux")]
    public string? Selinux { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.TmpfsOptions_STATUS Describes the tmpfs options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VolumeOptions_STATUS Describes the volume options for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesVolume
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nocopy")]
    public bool? Nocopy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VolumeDefinition_STATUS Describes the volume configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.BindOptions_STATUS Describes the bind options for the container</summary>
    [JsonPropertyName("bind")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesBind? Bind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Storage version of v1api20240401.TmpfsOptions_STATUS Describes the tmpfs options for the container</summary>
    [JsonPropertyName("tmpfs")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs? Tmpfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240401.VolumeOptions_STATUS Describes the volume options for the container</summary>
    [JsonPropertyName("volume")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesVolume? Volume { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.CustomService_STATUS Specifies the custom service configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServices
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.Docker_STATUS Docker container configuration</summary>
    [JsonPropertyName("docker")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesDocker? Docker { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEndpoints>? Endpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Storage version of v1api20240401.Image_STATUS Describes the Image Specifications</summary>
    [JsonPropertyName("image")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesImage? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceDataDisk_STATUS Defines an Aml Instance DataDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesDataDisks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceDataMount_STATUS Defines an Aml Instance DataMount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesDataMounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountAction")]
    public string? MountAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountName")]
    public string? MountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountState")]
    public string? MountState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountedOn")]
    public string? MountedOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceLastOperation_STATUS The last operation on ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation
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

    /// <summary></summary>
    [JsonPropertyName("operationTrigger")]
    public string? OperationTrigger { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ImageMetadata_STATUS Returns metadata about the operating system image for this compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesOsImageMetadata
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentImageVersion")]
    public string? CurrentImageVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isLatestOsImageVersion")]
    public bool? IsLatestOsImageVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestImageVersion")]
    public string? LatestImageVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AssignedUser_STATUS A user that can be assigned to a compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.PersonalComputeInstanceSettings_STATUS Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AssignedUser_STATUS A user that can be assigned to a compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Cron_STATUS The workflow trigger cron for ComputeStartStop schedule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeRecurrenceSchedule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthDays")]
    public IList<int>? MonthDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Recurrence_STATUS The workflow trigger recurrence for ComputeStartStop schedule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeRecurrenceSchedule_STATUS</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScheduleBase_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeStartStopSchedule_STATUS Compute start stop schedule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStop
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Storage version of v1api20240401.Cron_STATUS The workflow trigger cron for ComputeStartStop schedule type.</summary>
    [JsonPropertyName("cron")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron? Cron { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary>Storage version of v1api20240401.Recurrence_STATUS The workflow trigger recurrence for ComputeStartStop schedule type.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence? Recurrence { get; set; }

    /// <summary>Storage version of v1api20240401.ScheduleBase_STATUS</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeSchedules_STATUS The list of schedules to be applied on the computes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeStartStop")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStop>? ComputeStartStop { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptReference_STATUS Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptReference_STATUS Script reference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ScriptsToExecute_STATUS Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptReference_STATUS Script reference</summary>
    [JsonPropertyName("creationScript")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptReference_STATUS Script reference</summary>
    [JsonPropertyName("startupScript")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SetupScripts_STATUS Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ScriptsToExecute_STATUS Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceSshSettings_STATUS Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceVersion_STATUS Version of computeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesVersions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstanceProperties_STATUS Compute Instance properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public string? ApplicationSharingPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applications")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications>? Applications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public string? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceConnectivityEndpoints_STATUS Defines all connectivity endpoints and properties for an ComputeInstance.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints? ConnectivityEndpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesContainers>? Containers { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceCreatedBy_STATUS Describes information on user who created this ComputeInstance.</summary>
    [JsonPropertyName("createdBy")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customServices")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServices>? CustomServices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesDataDisks>? DataDisks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataMounts")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesDataMounts>? DataMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors>? Errors { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceLastOperation_STATUS The last operation on ComputeInstance.</summary>
    [JsonPropertyName("lastOperation")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation? LastOperation { get; set; }

    /// <summary>Storage version of v1api20240401.ImageMetadata_STATUS Returns metadata about the operating system image for this compute instance.</summary>
    [JsonPropertyName("osImageMetadata")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesOsImageMetadata? OsImageMetadata { get; set; }

    /// <summary>Storage version of v1api20240401.PersonalComputeInstanceSettings_STATUS Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeSchedules_STATUS The list of schedules to be applied on the computes</summary>
    [JsonPropertyName("schedules")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedules? Schedules { get; set; }

    /// <summary>Storage version of v1api20240401.SetupScripts_STATUS Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceSshSettings_STATUS Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage version of v1api20240401.ResourceId_STATUS Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstanceVersion_STATUS Version of computeInstance.</summary>
    [JsonPropertyName("versions")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstancePropertiesVersions? Versions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ComputeInstance_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstance
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

    /// <summary>Storage version of v1api20240401.ComputeInstanceProperties_STATUS Compute Instance properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataFactory_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataFactory
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
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataLakeAnalytics_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DataLakeAnalytics_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalytics
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

    /// <summary>Storage version of v1api20240401.DataLakeAnalytics_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.DatabricksProperties_STATUS Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Databricks_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesDatabricks
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

    /// <summary>Storage version of v1api20240401.DatabricksProperties_STATUS Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesDatabricksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.HDInsightProperties_STATUS HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.HDInsight_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesHdInsight
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

    /// <summary>Storage version of v1api20240401.HDInsightProperties_STATUS HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesHdInsightProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.InstanceTypeSchema_Resources_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.InstanceTypeSchema_STATUS Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Storage version of v1api20240401.InstanceTypeSchema_Resources_STATUS</summary>
    [JsonPropertyName("resources")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.KubernetesProperties_STATUS Kubernetes properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProperties
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
    public IDictionary<string, V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Kubernetes_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesKubernetes
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

    /// <summary>Storage version of v1api20240401.KubernetesProperties_STATUS Kubernetes properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesKubernetesProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AutoPauseProperties_STATUS Auto pause properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.AutoScaleProperties_STATUS Auto scale properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SynapseSpark_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AutoPauseProperties_STATUS Auto pause properties</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>Storage version of v1api20240401.AutoScaleProperties_STATUS Auto scale properties</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SynapseSpark_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSpark
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

    /// <summary>Storage version of v1api20240401.SynapseSpark_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachine_Properties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachineSshCredentials_STATUS Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookServerPort")]
    public int? NotebookServerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.ErrorResponse_STATUS Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError? Error { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.VirtualMachine_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachine
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

    /// <summary>Storage version of v1api20240401.VirtualMachine_Properties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Compute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AKS_STATUS</summary>
    [JsonPropertyName("aks")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAks? Aks { get; set; }

    /// <summary>Storage version of v1api20240401.AmlCompute_STATUS</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeInstance_STATUS</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>Storage version of v1api20240401.DataFactory_STATUS</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>Storage version of v1api20240401.DataLakeAnalytics_STATUS</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Storage version of v1api20240401.Databricks_STATUS</summary>
    [JsonPropertyName("databricks")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesDatabricks? Databricks { get; set; }

    /// <summary>Storage version of v1api20240401.HDInsight_STATUS</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Storage version of v1api20240401.Kubernetes_STATUS</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>Storage version of v1api20240401.SynapseSpark_STATUS</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>Storage version of v1api20240401.VirtualMachine_STATUS</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20240401storageWorkspacesComputeStatusPropertiesVirtualMachine? VirtualMachine { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.Sku_STATUS The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatusSystemData
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.WorkspacesCompute_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesComputeStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401storageWorkspacesComputeStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedServiceIdentity_STATUS Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspacesComputeStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240401.Compute_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesComputeStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20240401.Sku_STATUS The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20240401storageWorkspacesComputeStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401storageWorkspacesComputeStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240401.WorkspacesCompute Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/machineLearningServices.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspacesCompute : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401storageWorkspacesComputeSpec>, IStatus<V1api20240401storageWorkspacesComputeStatus>
{
    public const string KubeApiVersion = "v1api20240401storage";
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

    /// <summary>Storage version of v1api20240401.WorkspacesCompute_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240401storageWorkspacesComputeSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspacesCompute_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240401storageWorkspacesComputeStatus? Status { get; set; }
}
#nullable disable
