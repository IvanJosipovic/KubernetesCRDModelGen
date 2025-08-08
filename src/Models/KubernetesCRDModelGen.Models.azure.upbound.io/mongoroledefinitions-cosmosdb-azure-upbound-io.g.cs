using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderPrivilegeResource
{
    /// <summary>The name of the Mongo DB Collection that the Role Definition is applied.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the Mongo DB that the Role Definition is applied.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProviderPrivilege
{
    /// <summary>A list of actions that are allowed.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A resource block as defined below.</summary>
    [JsonPropertyName("resource")]
    public V1beta1MongoRoleDefinitionSpecForProviderPrivilegeResource? Resource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecForProvider
{
    /// <summary>The resource ID of the Mongo DB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosMongoDatabaseId")]
    public string? CosmosMongoDatabaseId { get; set; }

    /// <summary>Reference to a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
    [JsonPropertyName("cosmosMongoDatabaseIdRef")]
    public V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdRef? CosmosMongoDatabaseIdRef { get; set; }

    /// <summary>Selector for a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
    [JsonPropertyName("cosmosMongoDatabaseIdSelector")]
    public V1beta1MongoRoleDefinitionSpecForProviderCosmosMongoDatabaseIdSelector? CosmosMongoDatabaseIdSelector { get; set; }

    /// <summary>A list of Mongo Roles which are inherited to the Mongo Role Definition.</summary>
    [JsonPropertyName("inheritedRoleNames")]
    public IList<string>? InheritedRoleNames { get; set; }

    /// <summary>A privilege block as defined below.</summary>
    [JsonPropertyName("privilege")]
    public IList<V1beta1MongoRoleDefinitionSpecForProviderPrivilege>? Privilege { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderPrivilegeResource
{
    /// <summary>The name of the Mongo DB Collection that the Role Definition is applied.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the Mongo DB that the Role Definition is applied.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProviderPrivilege
{
    /// <summary>A list of actions that are allowed.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A resource block as defined below.</summary>
    [JsonPropertyName("resource")]
    public V1beta1MongoRoleDefinitionSpecInitProviderPrivilegeResource? Resource { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecInitProvider
{
    /// <summary>The resource ID of the Mongo DB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosMongoDatabaseId")]
    public string? CosmosMongoDatabaseId { get; set; }

    /// <summary>Reference to a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
    [JsonPropertyName("cosmosMongoDatabaseIdRef")]
    public V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdRef? CosmosMongoDatabaseIdRef { get; set; }

    /// <summary>Selector for a MongoDatabase in cosmosdb to populate cosmosMongoDatabaseId.</summary>
    [JsonPropertyName("cosmosMongoDatabaseIdSelector")]
    public V1beta1MongoRoleDefinitionSpecInitProviderCosmosMongoDatabaseIdSelector? CosmosMongoDatabaseIdSelector { get; set; }

    /// <summary>A list of Mongo Roles which are inherited to the Mongo Role Definition.</summary>
    [JsonPropertyName("inheritedRoleNames")]
    public IList<string>? InheritedRoleNames { get; set; }

    /// <summary>A privilege block as defined below.</summary>
    [JsonPropertyName("privilege")]
    public IList<V1beta1MongoRoleDefinitionSpecInitProviderPrivilege>? Privilege { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecProviderConfigRefPolicy
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
public partial class V1beta1MongoRoleDefinitionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MongoRoleDefinitionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MongoRoleDefinitionSpec defines the desired state of MongoRoleDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MongoRoleDefinitionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MongoRoleDefinitionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MongoRoleDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MongoRoleDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionStatusAtProviderPrivilegeResource
{
    /// <summary>The name of the Mongo DB Collection that the Role Definition is applied.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the Mongo DB that the Role Definition is applied.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionStatusAtProviderPrivilege
{
    /// <summary>A list of actions that are allowed.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A resource block as defined below.</summary>
    [JsonPropertyName("resource")]
    public V1beta1MongoRoleDefinitionStatusAtProviderPrivilegeResource? Resource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionStatusAtProvider
{
    /// <summary>The resource ID of the Mongo DB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosMongoDatabaseId")]
    public string? CosmosMongoDatabaseId { get; set; }

    /// <summary>The ID of the Cosmos DB Mongo Role Definition.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of Mongo Roles which are inherited to the Mongo Role Definition.</summary>
    [JsonPropertyName("inheritedRoleNames")]
    public IList<string>? InheritedRoleNames { get; set; }

    /// <summary>A privilege block as defined below.</summary>
    [JsonPropertyName("privilege")]
    public IList<V1beta1MongoRoleDefinitionStatusAtProviderPrivilege>? Privilege { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionStatusConditions
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

/// <summary>MongoRoleDefinitionStatus defines the observed state of MongoRoleDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MongoRoleDefinitionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MongoRoleDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MongoRoleDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MongoRoleDefinition is the Schema for the MongoRoleDefinitions API. Manages a Cosmos DB Mongo Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MongoRoleDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MongoRoleDefinitionSpec>, IStatus<V1beta1MongoRoleDefinitionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MongoRoleDefinition";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "mongoroledefinitions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MongoRoleDefinitionSpec defines the desired state of MongoRoleDefinition</summary>
    [JsonPropertyName("spec")]
    public V1beta1MongoRoleDefinitionSpec Spec { get; set; }

    /// <summary>MongoRoleDefinitionStatus defines the observed state of MongoRoleDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta1MongoRoleDefinitionStatus? Status { get; set; }
}

/// <summary>MongoRoleDefinition is the Schema for the MongoRoleDefinitions API. Manages a Cosmos DB Mongo Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MongoRoleDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MongoRoleDefinition>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MongoRoleDefinitionList";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "mongoroledefinitions";
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
    public IList<V1beta1MongoRoleDefinition> Items { get; set; }
}