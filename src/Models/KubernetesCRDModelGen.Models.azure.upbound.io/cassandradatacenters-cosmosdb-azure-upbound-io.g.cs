using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.upbound.io;
#nullable enable
/// <summary>CassandraDatacenter is the Schema for the CassandraDatacenters API. Manages a Cassandra Datacenter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraDatacenterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CassandraDatacenter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraDatacenterList";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "cassandradatacenters";
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
    public IList<V1beta1CassandraDatacenter> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a CassandraCluster in cosmosdb to populate cassandraClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a CassandraCluster in cosmosdb to populate cassandraClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecForProvider
{
    /// <summary>Determines whether availability zones are enabled. Defaults to true.</summary>
    [JsonPropertyName("availabilityZonesEnabled")]
    public bool? AvailabilityZonesEnabled { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the backup Storage Account.</summary>
    [JsonPropertyName("backupStorageCustomerKeyUri")]
    public string? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>The fragment of the cassandra.yaml configuration file to be included in the cassandra.yaml for all nodes in this Cassandra Datacenter. The fragment should be Base64 encoded and only a subset of keys is allowed.</summary>
    [JsonPropertyName("base64EncodedYamlFragment")]
    public string? Base64EncodedYamlFragment { get; set; }

    /// <summary>The ID of the Cassandra Cluster. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("cassandraClusterId")]
    public string? CassandraClusterId { get; set; }

    /// <summary>Reference to a CassandraCluster in cosmosdb to populate cassandraClusterId.</summary>
    [JsonPropertyName("cassandraClusterIdRef")]
    public V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdRef? CassandraClusterIdRef { get; set; }

    /// <summary>Selector for a CassandraCluster in cosmosdb to populate cassandraClusterId.</summary>
    [JsonPropertyName("cassandraClusterIdSelector")]
    public V1beta1CassandraDatacenterSpecForProviderCassandraClusterIdSelector? CassandraClusterIdSelector { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Datacenter. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdRef")]
    public V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdRef? DelegatedManagementSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdSelector")]
    public V1beta1CassandraDatacenterSpecForProviderDelegatedManagementSubnetIdSelector? DelegatedManagementSubnetIdSelector { get; set; }

    /// <summary>Determines the number of p30 disks that are attached to each node.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>The Disk SKU that is used for this Cassandra Datacenter. Defaults to P30.</summary>
    [JsonPropertyName("diskSku")]
    public string? DiskSku { get; set; }

    /// <summary>The Azure Region where the Cassandra Datacenter should exist. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the Managed Disk.</summary>
    [JsonPropertyName("managedDiskCustomerKeyUri")]
    public string? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>The number of nodes the Cassandra Datacenter should have. The number should be equal or greater than 3. Defaults to 3.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>Determines the selected sku.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecInitProvider
{
    /// <summary>Determines whether availability zones are enabled. Defaults to true.</summary>
    [JsonPropertyName("availabilityZonesEnabled")]
    public bool? AvailabilityZonesEnabled { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the backup Storage Account.</summary>
    [JsonPropertyName("backupStorageCustomerKeyUri")]
    public string? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>The fragment of the cassandra.yaml configuration file to be included in the cassandra.yaml for all nodes in this Cassandra Datacenter. The fragment should be Base64 encoded and only a subset of keys is allowed.</summary>
    [JsonPropertyName("base64EncodedYamlFragment")]
    public string? Base64EncodedYamlFragment { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Datacenter. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdRef")]
    public V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdRef? DelegatedManagementSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedManagementSubnetId.</summary>
    [JsonPropertyName("delegatedManagementSubnetIdSelector")]
    public V1beta1CassandraDatacenterSpecInitProviderDelegatedManagementSubnetIdSelector? DelegatedManagementSubnetIdSelector { get; set; }

    /// <summary>Determines the number of p30 disks that are attached to each node.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>The Disk SKU that is used for this Cassandra Datacenter. Defaults to P30.</summary>
    [JsonPropertyName("diskSku")]
    public string? DiskSku { get; set; }

    /// <summary>The Azure Region where the Cassandra Datacenter should exist. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the Managed Disk.</summary>
    [JsonPropertyName("managedDiskCustomerKeyUri")]
    public string? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>The number of nodes the Cassandra Datacenter should have. The number should be equal or greater than 3. Defaults to 3.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>Determines the selected sku.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraDatacenterSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CassandraDatacenterSpec defines the desired state of CassandraDatacenter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CassandraDatacenterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CassandraDatacenterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CassandraDatacenterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CassandraDatacenterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterStatusAtProvider
{
    /// <summary>Determines whether availability zones are enabled. Defaults to true.</summary>
    [JsonPropertyName("availabilityZonesEnabled")]
    public bool? AvailabilityZonesEnabled { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the backup Storage Account.</summary>
    [JsonPropertyName("backupStorageCustomerKeyUri")]
    public string? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>The fragment of the cassandra.yaml configuration file to be included in the cassandra.yaml for all nodes in this Cassandra Datacenter. The fragment should be Base64 encoded and only a subset of keys is allowed.</summary>
    [JsonPropertyName("base64EncodedYamlFragment")]
    public string? Base64EncodedYamlFragment { get; set; }

    /// <summary>The ID of the Cassandra Cluster. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("cassandraClusterId")]
    public string? CassandraClusterId { get; set; }

    /// <summary>The ID of the delegated management subnet for this Cassandra Datacenter. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Determines the number of p30 disks that are attached to each node.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>The Disk SKU that is used for this Cassandra Datacenter. Defaults to P30.</summary>
    [JsonPropertyName("diskSku")]
    public string? DiskSku { get; set; }

    /// <summary>The ID of the Cassandra Datacenter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Cassandra Datacenter should exist. Changing this forces a new Cassandra Datacenter to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The key URI of the customer key to use for the encryption of the Managed Disk.</summary>
    [JsonPropertyName("managedDiskCustomerKeyUri")]
    public string? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>The number of nodes the Cassandra Datacenter should have. The number should be equal or greater than 3. Defaults to 3.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A list of IP Address for the seed nodes in this Cassandra Datacenter.</summary>
    [JsonPropertyName("seedNodeIpAddresses")]
    public IList<string>? SeedNodeIpAddresses { get; set; }

    /// <summary>Determines the selected sku.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterStatusConditions
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
#nullable disable

#nullable enable
/// <summary>CassandraDatacenterStatus defines the observed state of CassandraDatacenter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraDatacenterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CassandraDatacenterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CassandraDatacenterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CassandraDatacenter is the Schema for the CassandraDatacenters API. Manages a Cassandra Datacenter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraDatacenter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CassandraDatacenterSpec>, IStatus<V1beta1CassandraDatacenterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraDatacenter";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "cassandradatacenters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CassandraDatacenterSpec defines the desired state of CassandraDatacenter</summary>
    [JsonPropertyName("spec")]
    public V1beta1CassandraDatacenterSpec Spec { get; set; }

    /// <summary>CassandraDatacenterStatus defines the observed state of CassandraDatacenter.</summary>
    [JsonPropertyName("status")]
    public V1beta1CassandraDatacenterStatus? Status { get; set; }
}
#nullable disable
