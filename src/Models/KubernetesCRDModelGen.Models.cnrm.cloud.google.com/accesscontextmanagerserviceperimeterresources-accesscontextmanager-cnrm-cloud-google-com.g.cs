using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary>Only the `external` field is supported to configure the reference.  The name of the Service Perimeter to add this resource to.  Referencing a resource name leads to recursive reference and Config Connector does not support the feature for now.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceSpecPerimeterNameRef
{
    /// <summary>Allowed value: The `name` field of an `AccessContextManagerServicePerimeter` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A GCP resource that is inside of the service perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceSpecResourceRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceSpec
{
    /// <summary>Only the `external` field is supported to configure the reference.  The name of the Service Perimeter to add this resource to.  Referencing a resource name leads to recursive reference and Config Connector does not support the feature for now.</summary>
    [JsonPropertyName("perimeterNameRef")]
    public V1alpha1AccessContextManagerServicePerimeterResourceSpecPerimeterNameRef PerimeterNameRef { get; set; }

    /// <summary>A GCP resource that is inside of the service perimeter.</summary>
    [JsonPropertyName("resourceRef")]
    public V1alpha1AccessContextManagerServicePerimeterResourceSpecResourceRef ResourceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AccessContextManagerServicePerimeterResourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessContextManagerServicePerimeterResource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccessContextManagerServicePerimeterResourceSpec>, IStatus<V1alpha1AccessContextManagerServicePerimeterResourceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessContextManagerServicePerimeterResource";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanagerserviceperimeterresources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AccessContextManagerServicePerimeterResourceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AccessContextManagerServicePerimeterResourceStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessContextManagerServicePerimeterResourceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AccessContextManagerServicePerimeterResource>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessContextManagerServicePerimeterResourceList";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanagerserviceperimeterresources";
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
    public IList<V1alpha1AccessContextManagerServicePerimeterResource> Items { get; set; }
}