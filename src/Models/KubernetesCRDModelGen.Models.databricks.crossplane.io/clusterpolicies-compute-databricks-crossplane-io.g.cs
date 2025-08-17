using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
#nullable enable
/// <summary>ClusterPolicy is the Schema for the ClusterPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterPolicyList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "clusterpolicies";
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
    public IList<V1alpha1ClusterPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecForProviderLibrariesCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecForProviderLibrariesMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecForProviderLibrariesPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecForProviderLibraries
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterPolicySpecForProviderLibrariesCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterPolicySpecForProviderLibrariesMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterPolicySpecForProviderLibrariesPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecForProvider
{
    /// <summary>Policy definition: JSON document expressed in Databricks Policy Definition Language. Cannot be used with policy_family_id</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Additional human-readable description of the cluster policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libraries")]
    public IList<V1alpha1ClusterPolicySpecForProviderLibraries>? Libraries { get; set; }

    /// <summary>Maximum number of clusters allowed per user. When omitted, there is no limit. If specified, value must be greater than zero.</summary>
    [JsonPropertyName("maxClustersPerUser")]
    public double? MaxClustersPerUser { get; set; }

    /// <summary>the name of the built-in cluster policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>settings to override in the built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyDefinitionOverrides")]
    public string? PolicyFamilyDefinitionOverrides { get; set; }

    /// <summary>the ID of the cluster policy family used for built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyId")]
    public string? PolicyFamilyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecInitProviderLibrariesCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecInitProviderLibrariesMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecInitProviderLibrariesPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecInitProviderLibraries
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterPolicySpecInitProviderLibrariesCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterPolicySpecInitProviderLibrariesMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterPolicySpecInitProviderLibrariesPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecInitProvider
{
    /// <summary>Policy definition: JSON document expressed in Databricks Policy Definition Language. Cannot be used with policy_family_id</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Additional human-readable description of the cluster policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libraries")]
    public IList<V1alpha1ClusterPolicySpecInitProviderLibraries>? Libraries { get; set; }

    /// <summary>Maximum number of clusters allowed per user. When omitted, there is no limit. If specified, value must be greater than zero.</summary>
    [JsonPropertyName("maxClustersPerUser")]
    public double? MaxClustersPerUser { get; set; }

    /// <summary>the name of the built-in cluster policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>settings to override in the built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyDefinitionOverrides")]
    public string? PolicyFamilyDefinitionOverrides { get; set; }

    /// <summary>the ID of the cluster policy family used for built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyId")]
    public string? PolicyFamilyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecProviderConfigRefPolicy
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
public partial class V1alpha1ClusterPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ClusterPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecPublishConnectionDetailsToConfigRefPolicy
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
/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ClusterPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecPublishConnectionDetailsToMetadata
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
#nullable disable

#nullable enable
/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1ClusterPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpecWriteConnectionSecretToRef
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
/// <summary>ClusterPolicySpec defines the desired state of ClusterPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1ClusterPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1ClusterPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ClusterPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1ClusterPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ClusterPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusAtProviderLibrariesCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusAtProviderLibrariesMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusAtProviderLibrariesPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusAtProviderLibraries
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterPolicyStatusAtProviderLibrariesCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterPolicyStatusAtProviderLibrariesMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterPolicyStatusAtProviderLibrariesPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusAtProvider
{
    /// <summary>Policy definition: JSON document expressed in Databricks Policy Definition Language. Cannot be used with policy_family_id</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Additional human-readable description of the cluster policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Canonical unique identifier for the cluster policy. This is equal to policy_id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libraries")]
    public IList<V1alpha1ClusterPolicyStatusAtProviderLibraries>? Libraries { get; set; }

    /// <summary>Maximum number of clusters allowed per user. When omitted, there is no limit. If specified, value must be greater than zero.</summary>
    [JsonPropertyName("maxClustersPerUser")]
    public double? MaxClustersPerUser { get; set; }

    /// <summary>the name of the built-in cluster policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>settings to override in the built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyDefinitionOverrides")]
    public string? PolicyFamilyDefinitionOverrides { get; set; }

    /// <summary>the ID of the cluster policy family used for built-in cluster policy.</summary>
    [JsonPropertyName("policyFamilyId")]
    public string? PolicyFamilyId { get; set; }

    /// <summary>Canonical unique identifier for the cluster policy.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatusConditions
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
/// <summary>ClusterPolicyStatus defines the observed state of ClusterPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ClusterPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterPolicy is the Schema for the ClusterPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterPolicySpec>, IStatus<V1alpha1ClusterPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterPolicy";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "clusterpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterPolicySpec defines the desired state of ClusterPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterPolicySpec Spec { get; set; }

    /// <summary>ClusterPolicyStatus defines the observed state of ClusterPolicy.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterPolicyStatus? Status { get; set; }
}
#nullable disable
