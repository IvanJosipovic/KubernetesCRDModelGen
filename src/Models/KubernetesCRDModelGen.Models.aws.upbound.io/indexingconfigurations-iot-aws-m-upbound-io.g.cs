using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecForProvider
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta1IndexingConfigurationSpecForProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecInitProvider
{
    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecProviderConfigRef
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
public partial class V1beta1IndexingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>IndexingConfigurationSpec defines the desired state of IndexingConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IndexingConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IndexingConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IndexingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IndexingConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatusConditions
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

/// <summary>IndexingConfigurationStatus defines the observed state of IndexingConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IndexingConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IndexingConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IndexingConfiguration is the Schema for the IndexingConfigurations API. Managing IoT Thing indexing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IndexingConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IndexingConfigurationSpec>, IStatus<V1beta1IndexingConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IndexingConfiguration";
    public const string KubeGroup = "iot.aws.m.upbound.io";
    public const string KubePluralName = "indexingconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IndexingConfigurationSpec defines the desired state of IndexingConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1IndexingConfigurationSpec Spec { get; set; }

    /// <summary>IndexingConfigurationStatus defines the observed state of IndexingConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1IndexingConfigurationStatus? Status { get; set; }
}

/// <summary>IndexingConfiguration is the Schema for the IndexingConfigurations API. Managing IoT Thing indexing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IndexingConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IndexingConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IndexingConfigurationList";
    public const string KubeGroup = "iot.aws.m.upbound.io";
    public const string KubePluralName = "indexingconfigurations";
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
    public IList<V1beta1IndexingConfiguration> Items { get; set; }
}