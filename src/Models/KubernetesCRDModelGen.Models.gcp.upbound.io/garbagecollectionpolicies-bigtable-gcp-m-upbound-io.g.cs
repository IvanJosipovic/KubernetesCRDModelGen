using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.gcp.m.upbound.io;
/// <summary>GarbageCollectionPolicy is the Schema for the GarbageCollectionPolicys API. Creates a Google Cloud Bigtable GC Policy inside a family.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GarbageCollectionPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GarbageCollectionPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GarbageCollectionPolicyList";
    public const string KubeGroup = "bigtable.gcp.m.upbound.io";
    public const string KubePluralName = "garbagecollectionpolicies";
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
    public IList<V1beta1GarbageCollectionPolicy> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderInstanceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderInstanceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GarbageCollectionPolicySpecForProviderInstanceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderInstanceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderInstanceNameSelector
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
    public V1beta1GarbageCollectionPolicySpecForProviderInstanceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>GC policy that applies to all cells older than the given age.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderMaxAge
{
    /// <summary>Number of days before applying GC policy.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Duration before applying GC policy (ex. "8h"). This is required when days isn't set</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderMaxVersion
{
    /// <summary>Number of version before applying the GC policy.</summary>
    [JsonPropertyName("number")]
    public double? Number { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderTableRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigtable to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderTableRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GarbageCollectionPolicySpecForProviderTableRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderTableSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigtable to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProviderTableSelector
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
    public V1beta1GarbageCollectionPolicySpecForProviderTableSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecForProvider
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("columnFamily")]
    public string? ColumnFamily { get; set; }

    /// <summary>The deletion policy for the GC policy. Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted in a replicated instance.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>Serialized JSON object to represent a more complex GC policy. Conflicts with mode, max_age and max_version. Conflicts with mode, max_age and max_version.</summary>
    [JsonPropertyName("gcRules")]
    public string? GcRules { get; set; }

    /// <summary>Boolean for whether to allow ignoring warnings when updating the gc policy. Setting this to true allows relaxing the gc policy for replicated clusters by up to 90 days, but keep in mind this may increase how long clusters are inconsistent. Make sure you understand the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing before setting this option.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary>The name of the Bigtable instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameRef")]
    public V1beta1GarbageCollectionPolicySpecForProviderInstanceNameRef? InstanceNameRef { get; set; }

    /// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameSelector")]
    public V1beta1GarbageCollectionPolicySpecForProviderInstanceNameSelector? InstanceNameSelector { get; set; }

    /// <summary>GC policy that applies to all cells older than the given age.</summary>
    [JsonPropertyName("maxAge")]
    public V1beta1GarbageCollectionPolicySpecForProviderMaxAge? MaxAge { get; set; }

    /// <summary>GC policy that applies to all versions of a cell except for the most recent.</summary>
    [JsonPropertyName("maxVersion")]
    public IList<V1beta1GarbageCollectionPolicySpecForProviderMaxVersion>? MaxVersion { get; set; }

    /// <summary>If multiple policies are set, you should choose between UNION OR INTERSECTION.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Reference to a Table in bigtable to populate table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1GarbageCollectionPolicySpecForProviderTableRef? TableRef { get; set; }

    /// <summary>Selector for a Table in bigtable to populate table.</summary>
    [JsonPropertyName("tableSelector")]
    public V1beta1GarbageCollectionPolicySpecForProviderTableSelector? TableSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameSelector
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
    public V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>GC policy that applies to all cells older than the given age.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderMaxAge
{
    /// <summary>Number of days before applying GC policy.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Duration before applying GC policy (ex. "8h"). This is required when days isn't set</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderMaxVersion
{
    /// <summary>Number of version before applying the GC policy.</summary>
    [JsonPropertyName("number")]
    public double? Number { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderTableRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigtable to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderTableRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GarbageCollectionPolicySpecInitProviderTableRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderTableSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigtable to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProviderTableSelector
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
    public V1beta1GarbageCollectionPolicySpecInitProviderTableSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecInitProvider
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("columnFamily")]
    public string? ColumnFamily { get; set; }

    /// <summary>The deletion policy for the GC policy. Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted in a replicated instance.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>Serialized JSON object to represent a more complex GC policy. Conflicts with mode, max_age and max_version. Conflicts with mode, max_age and max_version.</summary>
    [JsonPropertyName("gcRules")]
    public string? GcRules { get; set; }

    /// <summary>Boolean for whether to allow ignoring warnings when updating the gc policy. Setting this to true allows relaxing the gc policy for replicated clusters by up to 90 days, but keep in mind this may increase how long clusters are inconsistent. Make sure you understand the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing before setting this option.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary>The name of the Bigtable instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Reference to a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameRef")]
    public V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameRef? InstanceNameRef { get; set; }

    /// <summary>Selector for a Instance in bigtable to populate instanceName.</summary>
    [JsonPropertyName("instanceNameSelector")]
    public V1beta1GarbageCollectionPolicySpecInitProviderInstanceNameSelector? InstanceNameSelector { get; set; }

    /// <summary>GC policy that applies to all cells older than the given age.</summary>
    [JsonPropertyName("maxAge")]
    public V1beta1GarbageCollectionPolicySpecInitProviderMaxAge? MaxAge { get; set; }

    /// <summary>GC policy that applies to all versions of a cell except for the most recent.</summary>
    [JsonPropertyName("maxVersion")]
    public IList<V1beta1GarbageCollectionPolicySpecInitProviderMaxVersion>? MaxVersion { get; set; }

    /// <summary>If multiple policies are set, you should choose between UNION OR INTERSECTION.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Reference to a Table in bigtable to populate table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1GarbageCollectionPolicySpecInitProviderTableRef? TableRef { get; set; }

    /// <summary>Selector for a Table in bigtable to populate table.</summary>
    [JsonPropertyName("tableSelector")]
    public V1beta1GarbageCollectionPolicySpecInitProviderTableSelector? TableSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpecProviderConfigRef
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
public partial class V1beta1GarbageCollectionPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GarbageCollectionPolicySpec defines the desired state of GarbageCollectionPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GarbageCollectionPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GarbageCollectionPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GarbageCollectionPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GarbageCollectionPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>GC policy that applies to all cells older than the given age.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicyStatusAtProviderMaxAge
{
    /// <summary>Number of days before applying GC policy.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Duration before applying GC policy (ex. "8h"). This is required when days isn't set</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicyStatusAtProviderMaxVersion
{
    /// <summary>Number of version before applying the GC policy.</summary>
    [JsonPropertyName("number")]
    public double? Number { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicyStatusAtProvider
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("columnFamily")]
    public string? ColumnFamily { get; set; }

    /// <summary>The deletion policy for the GC policy. Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted in a replicated instance.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>Serialized JSON object to represent a more complex GC policy. Conflicts with mode, max_age and max_version. Conflicts with mode, max_age and max_version.</summary>
    [JsonPropertyName("gcRules")]
    public string? GcRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Boolean for whether to allow ignoring warnings when updating the gc policy. Setting this to true allows relaxing the gc policy for replicated clusters by up to 90 days, but keep in mind this may increase how long clusters are inconsistent. Make sure you understand the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing before setting this option.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary>The name of the Bigtable instance.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>GC policy that applies to all cells older than the given age.</summary>
    [JsonPropertyName("maxAge")]
    public V1beta1GarbageCollectionPolicyStatusAtProviderMaxAge? MaxAge { get; set; }

    /// <summary>GC policy that applies to all versions of a cell except for the most recent.</summary>
    [JsonPropertyName("maxVersion")]
    public IList<V1beta1GarbageCollectionPolicyStatusAtProviderMaxVersion>? MaxVersion { get; set; }

    /// <summary>If multiple policies are set, you should choose between UNION OR INTERSECTION.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicyStatusConditions
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

/// <summary>GarbageCollectionPolicyStatus defines the observed state of GarbageCollectionPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GarbageCollectionPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GarbageCollectionPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GarbageCollectionPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GarbageCollectionPolicy is the Schema for the GarbageCollectionPolicys API. Creates a Google Cloud Bigtable GC Policy inside a family.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GarbageCollectionPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GarbageCollectionPolicySpec>, IStatus<V1beta1GarbageCollectionPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GarbageCollectionPolicy";
    public const string KubeGroup = "bigtable.gcp.m.upbound.io";
    public const string KubePluralName = "garbagecollectionpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GarbageCollectionPolicySpec defines the desired state of GarbageCollectionPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1GarbageCollectionPolicySpec Spec { get; set; }

    /// <summary>GarbageCollectionPolicyStatus defines the observed state of GarbageCollectionPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1GarbageCollectionPolicyStatus? Status { get; set; }
}