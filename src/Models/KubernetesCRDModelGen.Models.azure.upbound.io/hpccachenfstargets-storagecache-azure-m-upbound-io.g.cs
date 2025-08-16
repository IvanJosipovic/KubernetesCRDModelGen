using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagecache.azure.m.upbound.io;
/// <summary>HPCCacheNFSTarget is the Schema for the HPCCacheNFSTargets API. Manages a NFS Target within a HPC Cache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HPCCacheNFSTargetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HPCCacheNFSTarget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCacheNFSTargetList";
    public const string KubeGroup = "storagecache.azure.m.upbound.io";
    public const string KubePluralName = "hpccachenfstargets";
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
    public IList<V1beta1HPCCacheNFSTarget> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderCacheNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderCacheNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheNFSTargetSpecForProviderCacheNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderCacheNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderCacheNameSelector
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
    public V1beta1HPCCacheNFSTargetSpecForProviderCacheNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderNamespaceJunction
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The client-facing file path of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The NFS export of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("nfsExport")]
    public string? NfsExport { get; set; }

    /// <summary>The relative subdirectory path from the nfs_export to map to the namespace_path. Defaults to "", in which case the whole nfs_export is exported.</summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameSelector
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
    public V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecForProvider
{
    /// <summary>The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameRef")]
    public V1beta1HPCCacheNFSTargetSpecForProviderCacheNameRef? CacheNameRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameSelector")]
    public V1beta1HPCCacheNFSTargetSpecForProviderCacheNameSelector? CacheNameSelector { get; set; }

    /// <summary>Can be specified multiple times to define multiple namespace_junction. Each namespace_junction block supports fields documented below.</summary>
    [JsonPropertyName("namespaceJunction")]
    public IList<V1beta1HPCCacheNFSTargetSpecForProviderNamespaceJunction>? NamespaceJunction { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HPCCacheNFSTargetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetHostName")]
    public string? TargetHostName { get; set; }

    /// <summary>The type of usage of the HPC Cache NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameSelector
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
    public V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProviderNamespaceJunction
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The client-facing file path of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The NFS export of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("nfsExport")]
    public string? NfsExport { get; set; }

    /// <summary>The relative subdirectory path from the nfs_export to map to the namespace_path. Defaults to "", in which case the whole nfs_export is exported.</summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecInitProvider
{
    /// <summary>The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameRef")]
    public V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameRef? CacheNameRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameSelector")]
    public V1beta1HPCCacheNFSTargetSpecInitProviderCacheNameSelector? CacheNameSelector { get; set; }

    /// <summary>Can be specified multiple times to define multiple namespace_junction. Each namespace_junction block supports fields documented below.</summary>
    [JsonPropertyName("namespaceJunction")]
    public IList<V1beta1HPCCacheNFSTargetSpecInitProviderNamespaceJunction>? NamespaceJunction { get; set; }

    /// <summary>The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetHostName")]
    public string? TargetHostName { get; set; }

    /// <summary>The type of usage of the HPC Cache NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpecProviderConfigRef
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
public partial class V1beta1HPCCacheNFSTargetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>HPCCacheNFSTargetSpec defines the desired state of HPCCacheNFSTarget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HPCCacheNFSTargetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HPCCacheNFSTargetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HPCCacheNFSTargetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HPCCacheNFSTargetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetStatusAtProviderNamespaceJunction
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The client-facing file path of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The NFS export of this NFS target within the HPC Cache NFS Target.</summary>
    [JsonPropertyName("nfsExport")]
    public string? NfsExport { get; set; }

    /// <summary>The relative subdirectory path from the nfs_export to map to the namespace_path. Defaults to "", in which case the whole nfs_export is exported.</summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetStatusAtProvider
{
    /// <summary>The name HPC Cache, which the HPC Cache NFS Target will be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>The ID of the HPC Cache NFS Target.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Can be specified multiple times to define multiple namespace_junction. Each namespace_junction block supports fields documented below.</summary>
    [JsonPropertyName("namespaceJunction")]
    public IList<V1beta1HPCCacheNFSTargetStatusAtProviderNamespaceJunction>? NamespaceJunction { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache NFS Target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The IP address or fully qualified domain name (FQDN) of the HPC Cache NFS target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetHostName")]
    public string? TargetHostName { get; set; }

    /// <summary>The type of usage of the HPC Cache NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetStatusConditions
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

/// <summary>HPCCacheNFSTargetStatus defines the observed state of HPCCacheNFSTarget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheNFSTargetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HPCCacheNFSTargetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HPCCacheNFSTargetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HPCCacheNFSTarget is the Schema for the HPCCacheNFSTargets API. Manages a NFS Target within a HPC Cache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HPCCacheNFSTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HPCCacheNFSTargetSpec>, IStatus<V1beta1HPCCacheNFSTargetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCacheNFSTarget";
    public const string KubeGroup = "storagecache.azure.m.upbound.io";
    public const string KubePluralName = "hpccachenfstargets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HPCCacheNFSTargetSpec defines the desired state of HPCCacheNFSTarget</summary>
    [JsonPropertyName("spec")]
    public V1beta1HPCCacheNFSTargetSpec Spec { get; set; }

    /// <summary>HPCCacheNFSTargetStatus defines the observed state of HPCCacheNFSTarget.</summary>
    [JsonPropertyName("status")]
    public V1beta1HPCCacheNFSTargetStatus? Status { get; set; }
}