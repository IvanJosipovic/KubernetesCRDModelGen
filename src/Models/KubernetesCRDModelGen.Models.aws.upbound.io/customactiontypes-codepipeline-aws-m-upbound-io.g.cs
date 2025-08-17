using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codepipeline.aws.m.upbound.io;
#nullable enable
/// <summary>CustomActionType is the Schema for the CustomActionTypes API. Provides a CodePipeline CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomActionTypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CustomActionType>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomActionTypeList";
    public const string KubeGroup = "codepipeline.aws.m.upbound.io";
    public const string KubePluralName = "customactiontypes";
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
    public IList<V1beta1CustomActionType> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecForProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecForProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecForProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecForProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecForProvider
{
    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta1CustomActionTypeSpecForProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta1CustomActionTypeSpecForProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta1CustomActionTypeSpecForProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta1CustomActionTypeSpecForProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecInitProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecInitProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecInitProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecInitProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecInitProvider
{
    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta1CustomActionTypeSpecInitProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta1CustomActionTypeSpecInitProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta1CustomActionTypeSpecInitProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta1CustomActionTypeSpecInitProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpecProviderConfigRef
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
public partial class V1beta1CustomActionTypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CustomActionTypeSpec defines the desired state of CustomActionType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CustomActionTypeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CustomActionTypeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomActionTypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomActionTypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusAtProviderConfigurationProperty
{
    /// <summary>The description of the action configuration property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the configuration property is a key.</summary>
    [JsonPropertyName("key")]
    public bool? Key { get; set; }

    /// <summary>The name of the action configuration property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates that the property will be used in conjunction with PollForJobs.</summary>
    [JsonPropertyName("queryable")]
    public bool? Queryable { get; set; }

    /// <summary>Whether the configuration property is a required value.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Whether the configuration property is secret.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>The type of the configuration property. Valid values: String, Number, Boolean</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the input artifact for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusAtProviderInputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The details of the output artifact of the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusAtProviderOutputArtifactDetails
{
    /// <summary>The maximum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of artifacts allowed for the action type. Min: 0, Max: 5</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The settings for an action type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusAtProviderSettings
{
    /// <summary>The URL returned to the AWS CodePipeline console that provides a deep link to the resources of the external system.</summary>
    [JsonPropertyName("entityUrlTemplate")]
    public string? EntityUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the top-level landing page for the external system.</summary>
    [JsonPropertyName("executionUrlTemplate")]
    public string? ExecutionUrlTemplate { get; set; }

    /// <summary>The URL returned to the AWS CodePipeline console that contains a link to the page where customers can update or change the configuration of the external action.</summary>
    [JsonPropertyName("revisionUrlTemplate")]
    public string? RevisionUrlTemplate { get; set; }

    /// <summary>The URL of a sign-up page where users can sign up for an external service and perform initial configuration of the action provided by that service.</summary>
    [JsonPropertyName("thirdPartyConfigurationUrl")]
    public string? ThirdPartyConfigurationUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusAtProvider
{
    /// <summary>The action ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The category of the custom action. Valid values: Source, Build, Deploy, Test, Invoke, Approval</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The configuration properties for the custom action. Max 10 items.</summary>
    [JsonPropertyName("configurationProperty")]
    public IList<V1beta1CustomActionTypeStatusAtProviderConfigurationProperty>? ConfigurationProperty { get; set; }

    /// <summary>Composed of category, provider and version</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The details of the input artifact for the action.</summary>
    [JsonPropertyName("inputArtifactDetails")]
    public V1beta1CustomActionTypeStatusAtProviderInputArtifactDetails? InputArtifactDetails { get; set; }

    /// <summary>The details of the output artifact of the action.</summary>
    [JsonPropertyName("outputArtifactDetails")]
    public V1beta1CustomActionTypeStatusAtProviderOutputArtifactDetails? OutputArtifactDetails { get; set; }

    /// <summary>The creator of the action being called.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service used in the custom action</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for an action type.</summary>
    [JsonPropertyName("settings")]
    public V1beta1CustomActionTypeStatusAtProviderSettings? Settings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The version identifier of the custom action.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatusConditions
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
/// <summary>CustomActionTypeStatus defines the observed state of CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomActionTypeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CustomActionTypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomActionTypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CustomActionType is the Schema for the CustomActionTypes API. Provides a CodePipeline CustomActionType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomActionType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomActionTypeSpec>, IStatus<V1beta1CustomActionTypeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomActionType";
    public const string KubeGroup = "codepipeline.aws.m.upbound.io";
    public const string KubePluralName = "customactiontypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomActionTypeSpec defines the desired state of CustomActionType</summary>
    [JsonPropertyName("spec")]
    public V1beta1CustomActionTypeSpec Spec { get; set; }

    /// <summary>CustomActionTypeStatus defines the observed state of CustomActionType.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomActionTypeStatus? Status { get; set; }
}
#nullable disable
