using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecr.aws.m.upbound.io;
#nullable enable
/// <summary>ReplicationConfiguration is the Schema for the ReplicationConfigurations API. Provides an Elastic Container Registry Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicationConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReplicationConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicationConfigurationList";
    public const string KubeGroup = "ecr.aws.m.upbound.io";
    public const string KubePluralName = "replicationconfigurations";
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
    public IList<V1beta1ReplicationConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRuleDestination
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The account ID of the destination registry to replicate to.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRuleRepositoryFilter
{
    /// <summary>The repository filter details.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The repository filter type. The only supported value is PREFIX_MATCH, which is a repository name prefix specified with the filter parameter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRule
{
    /// <summary>the details of a replication destination. A maximum of 25 are allowed per rule. See Destination.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRuleDestination>? Destination { get; set; }

    /// <summary>filters for a replication rule. See Repository Filter.</summary>
    [JsonPropertyName("repositoryFilter")]
    public IList<V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRuleRepositoryFilter>? RepositoryFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderReplicationConfiguration
{
    /// <summary>The replication rules for a replication configuration. A maximum of 10 are allowed per replication_configuration. See Rule</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ReplicationConfigurationSpecForProviderReplicationConfigurationRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProvider
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
    [JsonPropertyName("replicationConfiguration")]
    public V1beta1ReplicationConfigurationSpecForProviderReplicationConfiguration? ReplicationConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRuleDestination
{
    /// <summary>The account ID of the destination registry to replicate to.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRuleRepositoryFilter
{
    /// <summary>The repository filter details.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The repository filter type. The only supported value is PREFIX_MATCH, which is a repository name prefix specified with the filter parameter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRule
{
    /// <summary>the details of a replication destination. A maximum of 25 are allowed per rule. See Destination.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRuleDestination>? Destination { get; set; }

    /// <summary>filters for a replication rule. See Repository Filter.</summary>
    [JsonPropertyName("repositoryFilter")]
    public IList<V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRuleRepositoryFilter>? RepositoryFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderReplicationConfiguration
{
    /// <summary>The replication rules for a replication configuration. A maximum of 10 are allowed per replication_configuration. See Rule</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ReplicationConfigurationSpecInitProviderReplicationConfigurationRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProvider
{
    /// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
    [JsonPropertyName("replicationConfiguration")]
    public V1beta1ReplicationConfigurationSpecInitProviderReplicationConfiguration? ReplicationConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ReplicationConfigurationSpec defines the desired state of ReplicationConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReplicationConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReplicationConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReplicationConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReplicationConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRuleDestination
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The account ID of the destination registry to replicate to.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRuleRepositoryFilter
{
    /// <summary>The repository filter details.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The repository filter type. The only supported value is PREFIX_MATCH, which is a repository name prefix specified with the filter parameter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRule
{
    /// <summary>the details of a replication destination. A maximum of 25 are allowed per rule. See Destination.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRuleDestination>? Destination { get; set; }

    /// <summary>filters for a replication rule. See Repository Filter.</summary>
    [JsonPropertyName("repositoryFilter")]
    public IList<V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRuleRepositoryFilter>? RepositoryFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProviderReplicationConfiguration
{
    /// <summary>The replication rules for a replication configuration. A maximum of 10 are allowed per replication_configuration. See Rule</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ReplicationConfigurationStatusAtProviderReplicationConfigurationRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The account ID of the destination registry to replicate to.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }

    /// <summary>Replication configuration for a registry. See Replication Configuration.</summary>
    [JsonPropertyName("replicationConfiguration")]
    public V1beta1ReplicationConfigurationStatusAtProviderReplicationConfiguration? ReplicationConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusConditions
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
/// <summary>ReplicationConfigurationStatus defines the observed state of ReplicationConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReplicationConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReplicationConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ReplicationConfiguration is the Schema for the ReplicationConfigurations API. Provides an Elastic Container Registry Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicationConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReplicationConfigurationSpec>, IStatus<V1beta1ReplicationConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicationConfiguration";
    public const string KubeGroup = "ecr.aws.m.upbound.io";
    public const string KubePluralName = "replicationconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicationConfigurationSpec defines the desired state of ReplicationConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReplicationConfigurationSpec Spec { get; set; }

    /// <summary>ReplicationConfigurationStatus defines the observed state of ReplicationConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReplicationConfigurationStatus? Status { get; set; }
}
#nullable disable
