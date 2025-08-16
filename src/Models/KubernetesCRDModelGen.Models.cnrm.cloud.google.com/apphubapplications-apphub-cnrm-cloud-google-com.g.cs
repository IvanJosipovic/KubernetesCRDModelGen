using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apphub.cnrm.cloud.google.com;
/// <summary>AppHubApplication is the Schema for the AppHubApplication API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppHubApplication>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubApplicationList";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubapplications";
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
    public IList<V1alpha1AppHubApplication> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributesBusinessOwners
{
    /// <summary>Optional. Contact's name. Can have a maximum length of 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Email address of the contacts.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Optional. User-defined criticality information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributesCriticality
{
    /// <summary>Required. Criticality Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributesDeveloperOwners
{
    /// <summary>Optional. Contact's name. Can have a maximum length of 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Email address of the contacts.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Optional. User-defined environment information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributesEnvironment
{
    /// <summary>Required. Environment Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributesOperatorOwners
{
    /// <summary>Optional. Contact's name. Can have a maximum length of 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Email address of the contacts.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Optional. Consumer provided attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecAttributes
{
    /// <summary>Optional. Business team that ensures user needs are met and value is delivered</summary>
    [JsonPropertyName("businessOwners")]
    public IList<V1alpha1AppHubApplicationSpecAttributesBusinessOwners>? BusinessOwners { get; set; }

    /// <summary>Optional. User-defined criticality information.</summary>
    [JsonPropertyName("criticality")]
    public V1alpha1AppHubApplicationSpecAttributesCriticality? Criticality { get; set; }

    /// <summary>Optional. Developer team that owns development and coding.</summary>
    [JsonPropertyName("developerOwners")]
    public IList<V1alpha1AppHubApplicationSpecAttributesDeveloperOwners>? DeveloperOwners { get; set; }

    /// <summary>Optional. User-defined environment information.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1AppHubApplicationSpecAttributesEnvironment? Environment { get; set; }

    /// <summary>Optional. Operator team that ensures runtime and operations.</summary>
    [JsonPropertyName("operatorOwners")]
    public IList<V1alpha1AppHubApplicationSpecAttributesOperatorOwners>? OperatorOwners { get; set; }
}

/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Immutable. Defines what data can be included into this Application. Limits which Services and Workloads can be registered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpecScope
{
    /// <summary>Required. Scope Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>AppHubApplicationSpec defines the desired state of AppHubApplication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationSpec
{
    /// <summary>Optional. Consumer provided attributes.</summary>
    [JsonPropertyName("attributes")]
    public V1alpha1AppHubApplicationSpecAttributes? Attributes { get; set; }

    /// <summary>Optional. User-defined description of an Application. Can have a maximum length of 2048 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User-defined name for the Application. Can have a maximum length of 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AppHubApplicationSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The AppHubApplication name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. Defines what data can be included into this Application. Limits which Services and Workloads can be registered.</summary>
    [JsonPropertyName("scope")]
    public V1alpha1AppHubApplicationSpecScope? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationStatusObservedState
{
    /// <summary>Output only. Create time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Application state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. A universally unique identifier (in UUID4 format) for the `Application`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Update time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>AppHubApplicationStatus defines the config connector machine state of AppHubApplication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubApplicationStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppHubApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AppHubApplication resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AppHubApplicationStatusObservedState? ObservedState { get; set; }
}

/// <summary>AppHubApplication is the Schema for the AppHubApplication API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubApplication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppHubApplicationSpec>, IStatus<V1alpha1AppHubApplicationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubApplication";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubapplications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppHubApplicationSpec defines the desired state of AppHubApplication</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AppHubApplicationSpec Spec { get; set; }

    /// <summary>AppHubApplicationStatus defines the config connector machine state of AppHubApplication</summary>
    [JsonPropertyName("status")]
    public V1alpha1AppHubApplicationStatus? Status { get; set; }
}