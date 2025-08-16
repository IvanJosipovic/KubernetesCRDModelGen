using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.databricks.crossplane.io;
/// <summary>Entitlements is the Schema for the Entitlementss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EntitlementsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Entitlements>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EntitlementsList";
    public const string KubeGroup = "security.databricks.crossplane.io";
    public const string KubePluralName = "entitlements";
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
    public IList<V1alpha1Entitlements> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecForProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL feature in User Interface and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace as consumer, with limited access to workspace UI.  Couldn't be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecInitProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL feature in User Interface and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace as consumer, with limited access to workspace UI.  Couldn't be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecProviderConfigRefPolicy
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
public partial class V1alpha1EntitlementsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1EntitlementsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1EntitlementsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1EntitlementsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1EntitlementsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EntitlementsSpec defines the desired state of Entitlements</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1EntitlementsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1EntitlementsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1EntitlementsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1EntitlementsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1EntitlementsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsStatusAtProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL feature in User Interface and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace as consumer, with limited access to workspace UI.  Couldn't be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsStatusConditions
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

/// <summary>EntitlementsStatus defines the observed state of Entitlements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EntitlementsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1EntitlementsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EntitlementsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Entitlements is the Schema for the Entitlementss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Entitlements : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EntitlementsSpec>, IStatus<V1alpha1EntitlementsStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Entitlements";
    public const string KubeGroup = "security.databricks.crossplane.io";
    public const string KubePluralName = "entitlements";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EntitlementsSpec defines the desired state of Entitlements</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EntitlementsSpec Spec { get; set; }

    /// <summary>EntitlementsStatus defines the observed state of Entitlements.</summary>
    [JsonPropertyName("status")]
    public V1alpha1EntitlementsStatus? Status { get; set; }
}