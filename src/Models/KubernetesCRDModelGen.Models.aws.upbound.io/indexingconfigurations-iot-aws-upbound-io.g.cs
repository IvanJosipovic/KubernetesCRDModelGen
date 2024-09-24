using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

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

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1IndexingConfigurationSpecForProviderThingIndexingConfigurationFilter>? Filter { get; set; }

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
    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingGroupIndexingConfiguration>? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public IList<V1beta1IndexingConfigurationSpecForProviderThingIndexingConfiguration>? ThingIndexingConfiguration { get; set; }
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

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfigurationFilter>? Filter { get; set; }

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
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingGroupIndexingConfiguration>? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public IList<V1beta1IndexingConfigurationSpecInitProviderThingIndexingConfiguration>? ThingIndexingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexingConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1IndexingConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IndexingConfigurationSpec defines the desired state of IndexingConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexingConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexingConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1IndexingConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IndexingConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IndexingConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IndexingConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IndexingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IndexingConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfigurationFilter>? Filter { get; set; }

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

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingGroupIndexingConfiguration>? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public IList<V1beta1IndexingConfigurationStatusAtProviderThingIndexingConfiguration>? ThingIndexingConfiguration { get; set; }
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
    public const string KubeGroup = "iot.aws.upbound.io";
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