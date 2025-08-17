using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.m.upbound.io;
#nullable enable
/// <summary>SpringCloudBuildPackBinding is the Schema for the SpringCloudBuildPackBindings API. Manages a Spring Cloud Build Pack Binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudBuildPackBindingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudBuildPackBinding>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudBuildPackBindingList";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudbuildpackbindings";
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
    public IList<V1beta1SpringCloudBuildPackBinding> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A launch block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProviderLaunch
{
    /// <summary>Specifies a map of non-sensitive properties for launchProperties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Specifies a map of sensitive properties for launchProperties.</summary>
    [JsonPropertyName("secrets")]
    public IDictionary<string, string>? Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdRefPolicy
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
/// <summary>Reference to a SpringCloudBuilder in appplatform to populate springCloudBuilderId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdSelectorPolicy
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
/// <summary>Selector for a SpringCloudBuilder in appplatform to populate springCloudBuilderId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdSelector
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
    public V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecForProvider
{
    /// <summary>Specifies the Build Pack Binding Type. Allowed values are ApacheSkyWalking, AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("bindingType")]
    public string? BindingType { get; set; }

    /// <summary>A launch block as defined below.</summary>
    [JsonPropertyName("launch")]
    public V1beta1SpringCloudBuildPackBindingSpecForProviderLaunch? Launch { get; set; }

    /// <summary>The ID of the Spring Cloud Builder. Changing this forces a new Spring Cloud Build Pack Binding to be created.</summary>
    [JsonPropertyName("springCloudBuilderId")]
    public string? SpringCloudBuilderId { get; set; }

    /// <summary>Reference to a SpringCloudBuilder in appplatform to populate springCloudBuilderId.</summary>
    [JsonPropertyName("springCloudBuilderIdRef")]
    public V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdRef? SpringCloudBuilderIdRef { get; set; }

    /// <summary>Selector for a SpringCloudBuilder in appplatform to populate springCloudBuilderId.</summary>
    [JsonPropertyName("springCloudBuilderIdSelector")]
    public V1beta1SpringCloudBuildPackBindingSpecForProviderSpringCloudBuilderIdSelector? SpringCloudBuilderIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A launch block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecInitProviderLaunch
{
    /// <summary>Specifies a map of non-sensitive properties for launchProperties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Specifies a map of sensitive properties for launchProperties.</summary>
    [JsonPropertyName("secrets")]
    public IDictionary<string, string>? Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecInitProvider
{
    /// <summary>Specifies the Build Pack Binding Type. Allowed values are ApacheSkyWalking, AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("bindingType")]
    public string? BindingType { get; set; }

    /// <summary>A launch block as defined below.</summary>
    [JsonPropertyName("launch")]
    public V1beta1SpringCloudBuildPackBindingSpecInitProviderLaunch? Launch { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpecProviderConfigRef
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
public partial class V1beta1SpringCloudBuildPackBindingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudBuildPackBindingSpec defines the desired state of SpringCloudBuildPackBinding</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudBuildPackBindingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudBuildPackBindingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudBuildPackBindingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudBuildPackBindingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A launch block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingStatusAtProviderLaunch
{
    /// <summary>Specifies a map of non-sensitive properties for launchProperties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Specifies a map of sensitive properties for launchProperties.</summary>
    [JsonPropertyName("secrets")]
    public IDictionary<string, string>? Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingStatusAtProvider
{
    /// <summary>Specifies the Build Pack Binding Type. Allowed values are ApacheSkyWalking, AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("bindingType")]
    public string? BindingType { get; set; }

    /// <summary>The ID of the Spring Cloud Build Pack Binding.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A launch block as defined below.</summary>
    [JsonPropertyName("launch")]
    public V1beta1SpringCloudBuildPackBindingStatusAtProviderLaunch? Launch { get; set; }

    /// <summary>The ID of the Spring Cloud Builder. Changing this forces a new Spring Cloud Build Pack Binding to be created.</summary>
    [JsonPropertyName("springCloudBuilderId")]
    public string? SpringCloudBuilderId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingStatusConditions
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
/// <summary>SpringCloudBuildPackBindingStatus defines the observed state of SpringCloudBuildPackBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudBuildPackBindingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudBuildPackBindingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudBuildPackBindingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudBuildPackBinding is the Schema for the SpringCloudBuildPackBindings API. Manages a Spring Cloud Build Pack Binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudBuildPackBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudBuildPackBindingSpec>, IStatus<V1beta1SpringCloudBuildPackBindingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudBuildPackBinding";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudbuildpackbindings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudBuildPackBindingSpec defines the desired state of SpringCloudBuildPackBinding</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudBuildPackBindingSpec Spec { get; set; }

    /// <summary>SpringCloudBuildPackBindingStatus defines the observed state of SpringCloudBuildPackBinding.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudBuildPackBindingStatus? Status { get; set; }
}
#nullable disable
