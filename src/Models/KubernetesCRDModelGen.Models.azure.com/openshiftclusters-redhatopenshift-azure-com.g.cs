using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redhatopenshift.azure.com;
/// <summary>Storage version of v1api20231122.OpenShiftCluster Generator information: - Generated from: /redhatopenshift/resource-manager/Microsoft.RedHatOpenShift/openshiftclusters/stable/2023-11-22/redhatopenshift.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RedHatOpenShift/openShiftClusters/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231122storageOpenShiftClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20231122storageOpenShiftCluster>
{
    public const string KubeApiVersion = "v1api20231122storage";
    public const string KubeKind = "OpenShiftClusterList";
    public const string KubeGroup = "redhatopenshift.azure.com";
    public const string KubePluralName = "openshiftclusters";
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
    public IList<V1api20231122storageOpenShiftCluster> Items { get; set; }
}

/// <summary>Storage version of v1api20231122.APIServerProfile APIServerProfile represents an API server profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecApiserverProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecClusterProfilePullSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20231122.ClusterProfile ClusterProfile represents a cluster profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecClusterProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fipsValidatedModules")]
    public string? FipsValidatedModules { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("pullSecret")]
    public V1api20231122storageOpenShiftClusterSpecClusterProfilePullSecret? PullSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Storage version of v1api20231122.IngressProfile IngressProfile represents an ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecIngressProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecMasterProfileDiskEncryptionSetReference
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

/// <summary>SubnetReference: The Azure resource ID of the master subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecMasterProfileSubnetReference
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

/// <summary>Storage version of v1api20231122.MasterProfile MasterProfile represents a master profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecMasterProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20231122storageOpenShiftClusterSpecMasterProfileDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary>SubnetReference: The Azure resource ID of the master subnet.</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20231122storageOpenShiftClusterSpecMasterProfileSubnetReference? SubnetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20231122.ManagedOutboundIPs ManagedOutboundIPs represents the desired managed outbound IPs for the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>Storage version of v1api20231122.LoadBalancerProfile LoadBalancerProfile represents the profile of the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231122.ManagedOutboundIPs ManagedOutboundIPs represents the desired managed outbound IPs for the cluster public load balancer.</summary>
    [JsonPropertyName("managedOutboundIps")]
    public V1api20231122storageOpenShiftClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIps? ManagedOutboundIps { get; set; }
}

/// <summary>Storage version of v1api20231122.NetworkProfile NetworkProfile represents a network profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231122.LoadBalancerProfile LoadBalancerProfile represents the profile of the cluster public load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20231122storageOpenShiftClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preconfiguredNSG")]
    public string? PreconfiguredNSG { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecConfigMapExpressions
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

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretExpressions
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

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsAdminCredentials
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsUsername
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20231122.OpenShiftClusterOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("adminCredentials")]
    public V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("password")]
    public V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsPassword? Password { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("username")]
    public V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretsUsername? Username { get; set; }
}

/// <summary>Storage version of v1api20231122.OpenShiftClusterOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231122storageOpenShiftClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231122storageOpenShiftClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20231122.OpenShiftClusterOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20231122storageOpenShiftClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecServicePrincipalProfileClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecServicePrincipalProfileClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20231122.ServicePrincipalProfile ServicePrincipalProfile represents a service principal profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecServicePrincipalProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20231122storageOpenShiftClusterSpecServicePrincipalProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20231122storageOpenShiftClusterSpecServicePrincipalProfileClientSecret? ClientSecret { get; set; }
}

/// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecWorkerProfilesDiskEncryptionSetReference
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

/// <summary>SubnetReference: The Azure resource ID of the worker subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecWorkerProfilesSubnetReference
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

/// <summary>Storage version of v1api20231122.WorkerProfile WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpecWorkerProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20231122storageOpenShiftClusterSpecWorkerProfilesDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SubnetReference: The Azure resource ID of the worker subnet.</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20231122storageOpenShiftClusterSpecWorkerProfilesSubnetReference? SubnetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20231122.OpenShiftCluster_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231122.APIServerProfile APIServerProfile represents an API server profile.</summary>
    [JsonPropertyName("apiserverProfile")]
    public V1api20231122storageOpenShiftClusterSpecApiserverProfile? ApiserverProfile { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20231122.ClusterProfile ClusterProfile represents a cluster profile.</summary>
    [JsonPropertyName("clusterProfile")]
    public V1api20231122storageOpenShiftClusterSpecClusterProfile? ClusterProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingressProfiles")]
    public IList<V1api20231122storageOpenShiftClusterSpecIngressProfiles>? IngressProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20231122.MasterProfile MasterProfile represents a master profile.</summary>
    [JsonPropertyName("masterProfile")]
    public V1api20231122storageOpenShiftClusterSpecMasterProfile? MasterProfile { get; set; }

    /// <summary>Storage version of v1api20231122.NetworkProfile NetworkProfile represents a network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20231122storageOpenShiftClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v1api20231122.OpenShiftClusterOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231122storageOpenShiftClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231122storageOpenShiftClusterSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231122.ServicePrincipalProfile ServicePrincipalProfile represents a service principal profile.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20231122storageOpenShiftClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerProfiles")]
    public IList<V1api20231122storageOpenShiftClusterSpecWorkerProfiles>? WorkerProfiles { get; set; }
}

/// <summary>Storage version of v1api20231122.APIServerProfile_STATUS APIServerProfile represents an API server profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusApiserverProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>Storage version of v1api20231122.ClusterProfile_STATUS ClusterProfile represents a cluster profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusClusterProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fipsValidatedModules")]
    public string? FipsValidatedModules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusConditions
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

/// <summary>Storage version of v1api20231122.ConsoleProfile_STATUS ConsoleProfile represents a console profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusConsoleProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Storage version of v1api20231122.IngressProfile_STATUS IngressProfile represents an ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusIngressProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>Storage version of v1api20231122.MasterProfile_STATUS MasterProfile represents a master profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusMasterProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20231122.EffectiveOutboundIP_STATUS EffectiveOutboundIP represents an effective outbound IP resource of the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20231122.ManagedOutboundIPs_STATUS ManagedOutboundIPs represents the desired managed outbound IPs for the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>Storage version of v1api20231122.LoadBalancerProfile_STATUS LoadBalancerProfile represents the profile of the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveOutboundIps")]
    public IList<V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIps>? EffectiveOutboundIps { get; set; }

    /// <summary>Storage version of v1api20231122.ManagedOutboundIPs_STATUS ManagedOutboundIPs represents the desired managed outbound IPs for the cluster public load balancer.</summary>
    [JsonPropertyName("managedOutboundIps")]
    public V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIps? ManagedOutboundIps { get; set; }
}

/// <summary>Storage version of v1api20231122.NetworkProfile_STATUS NetworkProfile represents a network profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231122.LoadBalancerProfile_STATUS LoadBalancerProfile represents the profile of the cluster public load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20231122storageOpenShiftClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preconfiguredNSG")]
    public string? PreconfiguredNSG { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }
}

/// <summary>Storage version of v1api20231122.ServicePrincipalProfile_STATUS ServicePrincipalProfile represents a service principal profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusServicePrincipalProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Storage version of v1api20231122.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusSystemData
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

/// <summary>Storage version of v1api20231122.WorkerProfile_STATUS WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusWorkerProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20231122.WorkerProfile_STATUS WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatusWorkerProfilesStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20231122.OpenShiftCluster_STATUS OpenShiftCluster represents an Azure Red Hat OpenShift cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122storageOpenShiftClusterStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231122.APIServerProfile_STATUS APIServerProfile represents an API server profile.</summary>
    [JsonPropertyName("apiserverProfile")]
    public V1api20231122storageOpenShiftClusterStatusApiserverProfile? ApiserverProfile { get; set; }

    /// <summary>Storage version of v1api20231122.ClusterProfile_STATUS ClusterProfile represents a cluster profile.</summary>
    [JsonPropertyName("clusterProfile")]
    public V1api20231122storageOpenShiftClusterStatusClusterProfile? ClusterProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231122storageOpenShiftClusterStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20231122.ConsoleProfile_STATUS ConsoleProfile represents a console profile.</summary>
    [JsonPropertyName("consoleProfile")]
    public V1api20231122storageOpenShiftClusterStatusConsoleProfile? ConsoleProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingressProfiles")]
    public IList<V1api20231122storageOpenShiftClusterStatusIngressProfiles>? IngressProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20231122.MasterProfile_STATUS MasterProfile represents a master profile.</summary>
    [JsonPropertyName("masterProfile")]
    public V1api20231122storageOpenShiftClusterStatusMasterProfile? MasterProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231122.NetworkProfile_STATUS NetworkProfile represents a network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20231122storageOpenShiftClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20231122.ServicePrincipalProfile_STATUS ServicePrincipalProfile represents a service principal profile.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20231122storageOpenShiftClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Storage version of v1api20231122.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231122storageOpenShiftClusterStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerProfiles")]
    public IList<V1api20231122storageOpenShiftClusterStatusWorkerProfiles>? WorkerProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerProfilesStatus")]
    public IList<V1api20231122storageOpenShiftClusterStatusWorkerProfilesStatus>? WorkerProfilesStatus { get; set; }
}

/// <summary>Storage version of v1api20231122.OpenShiftCluster Generator information: - Generated from: /redhatopenshift/resource-manager/Microsoft.RedHatOpenShift/openshiftclusters/stable/2023-11-22/redhatopenshift.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RedHatOpenShift/openShiftClusters/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231122storageOpenShiftCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231122storageOpenShiftClusterSpec>, IStatus<V1api20231122storageOpenShiftClusterStatus>
{
    public const string KubeApiVersion = "v1api20231122storage";
    public const string KubeKind = "OpenShiftCluster";
    public const string KubeGroup = "redhatopenshift.azure.com";
    public const string KubePluralName = "openshiftclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231122.OpenShiftCluster_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231122storageOpenShiftClusterSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231122.OpenShiftCluster_STATUS OpenShiftCluster represents an Azure Red Hat OpenShift cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20231122storageOpenShiftClusterStatus? Status { get; set; }
}