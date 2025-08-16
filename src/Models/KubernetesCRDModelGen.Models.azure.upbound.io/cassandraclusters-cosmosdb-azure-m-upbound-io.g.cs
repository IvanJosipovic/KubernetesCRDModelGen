using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.m.upbound.io;
/// <summary>CassandraCluster is the Schema for the CassandraClusters API. Manages a Cassandra Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CassandraCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraClusterList";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "cassandraclusters";
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
    public IList<V1beta1CassandraCluster> Items { get; set; }
}

/// <summary>The initial admin password for this Cassandra Cluster. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderDefaultAdminPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdSelector
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
    public V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Cassandra Cluster. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta1CassandraClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecForProvider
{
    /// <summary>The authentication method that is used to authenticate clients. Possible values are None and Cassandra. Defaults to Cassandra.</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize client connecting to the Cassandra Cluster.</summary>
    [JsonPropertyName("clientCertificatePems")]
    public IList<string>? ClientCertificatePems { get; set; }

    /// <summary>The initial admin password for this Cassandra Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultAdminPasswordSecretRef")]
    public V1beta1CassandraClusterSpecForProviderDefaultAdminPasswordSecretRef? DefaultAdminPasswordSecretRef { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Cluster. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdRef")]
    public V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdRef? DelegatedManagementSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdSelector")]
    public V1beta1CassandraClusterSpecForProviderDelegatedManagementSubnetIdSelector? DelegatedManagementSubnetIdSelector { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize gossip from unmanaged Cassandra Data Center.</summary>
    [JsonPropertyName("externalGossipCertificatePems")]
    public IList<string>? ExternalGossipCertificatePems { get; set; }

    /// <summary>A list of IP Addresses of the seed nodes in unmanaged the Cassandra Data Center which will be added to the seed node lists of all managed nodes.</summary>
    [JsonPropertyName("externalSeedNodeIpAddresses")]
    public IList<string>? ExternalSeedNodeIpAddresses { get; set; }

    /// <summary>The number of hours to wait between taking a backup of the Cassandra Cluster. Defaults to 24.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public double? HoursBetweenBackups { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1CassandraClusterSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Cassandra Cluster should exist. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is the automatic repair enabled on the Cassandra Cluster? Defaults to true.</summary>
    [JsonPropertyName("repairEnabled")]
    public bool? RepairEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Cassandra Cluster should exist. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1CassandraClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1CassandraClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of Cassandra what the Cluster converges to run. Possible values are 3.11 and 4.0. Defaults to 3.11. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The initial admin password for this Cassandra Cluster. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderDefaultAdminPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdSelector
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
    public V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProviderIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Cassandra Cluster. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecInitProvider
{
    /// <summary>The authentication method that is used to authenticate clients. Possible values are None and Cassandra. Defaults to Cassandra.</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize client connecting to the Cassandra Cluster.</summary>
    [JsonPropertyName("clientCertificatePems")]
    public IList<string>? ClientCertificatePems { get; set; }

    /// <summary>The initial admin password for this Cassandra Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultAdminPasswordSecretRef")]
    public V1beta1CassandraClusterSpecInitProviderDefaultAdminPasswordSecretRef DefaultAdminPasswordSecretRef { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Cluster. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdRef")]
    public V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdRef? DelegatedManagementSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdSelector")]
    public V1beta1CassandraClusterSpecInitProviderDelegatedManagementSubnetIdSelector? DelegatedManagementSubnetIdSelector { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize gossip from unmanaged Cassandra Data Center.</summary>
    [JsonPropertyName("externalGossipCertificatePems")]
    public IList<string>? ExternalGossipCertificatePems { get; set; }

    /// <summary>A list of IP Addresses of the seed nodes in unmanaged the Cassandra Data Center which will be added to the seed node lists of all managed nodes.</summary>
    [JsonPropertyName("externalSeedNodeIpAddresses")]
    public IList<string>? ExternalSeedNodeIpAddresses { get; set; }

    /// <summary>The number of hours to wait between taking a backup of the Cassandra Cluster. Defaults to 24.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public double? HoursBetweenBackups { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1CassandraClusterSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Cassandra Cluster should exist. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is the automatic repair enabled on the Cassandra Cluster? Defaults to true.</summary>
    [JsonPropertyName("repairEnabled")]
    public bool? RepairEnabled { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of Cassandra what the Cluster converges to run. Possible values are 3.11 and 4.0. Defaults to 3.11. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpecProviderConfigRef
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
public partial class V1beta1CassandraClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>CassandraClusterSpec defines the desired state of CassandraCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CassandraClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CassandraClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CassandraClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CassandraClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterStatusAtProviderIdentity
{
    /// <summary>The ID of the Cassandra Cluster.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Cassandra Cluster.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Cassandra Cluster. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterStatusAtProvider
{
    /// <summary>The authentication method that is used to authenticate clients. Possible values are None and Cassandra. Defaults to Cassandra.</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize client connecting to the Cassandra Cluster.</summary>
    [JsonPropertyName("clientCertificatePems")]
    public IList<string>? ClientCertificatePems { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Cluster. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>A list of TLS certificates that is used to authorize gossip from unmanaged Cassandra Data Center.</summary>
    [JsonPropertyName("externalGossipCertificatePems")]
    public IList<string>? ExternalGossipCertificatePems { get; set; }

    /// <summary>A list of IP Addresses of the seed nodes in unmanaged the Cassandra Data Center which will be added to the seed node lists of all managed nodes.</summary>
    [JsonPropertyName("externalSeedNodeIpAddresses")]
    public IList<string>? ExternalSeedNodeIpAddresses { get; set; }

    /// <summary>The number of hours to wait between taking a backup of the Cassandra Cluster. Defaults to 24.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public double? HoursBetweenBackups { get; set; }

    /// <summary>The ID of the Cassandra Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1CassandraClusterStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Cassandra Cluster should exist. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is the automatic repair enabled on the Cassandra Cluster? Defaults to true.</summary>
    [JsonPropertyName("repairEnabled")]
    public bool? RepairEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Cassandra Cluster should exist. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of Cassandra what the Cluster converges to run. Possible values are 3.11 and 4.0. Defaults to 3.11. Changing this forces a new Cassandra Cluster to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterStatusConditions
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

/// <summary>CassandraClusterStatus defines the observed state of CassandraCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CassandraClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CassandraClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CassandraCluster is the Schema for the CassandraClusters API. Manages a Cassandra Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CassandraClusterSpec>, IStatus<V1beta1CassandraClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraCluster";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "cassandraclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CassandraClusterSpec defines the desired state of CassandraCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1CassandraClusterSpec Spec { get; set; }

    /// <summary>CassandraClusterStatus defines the observed state of CassandraCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1CassandraClusterStatus? Status { get; set; }
}