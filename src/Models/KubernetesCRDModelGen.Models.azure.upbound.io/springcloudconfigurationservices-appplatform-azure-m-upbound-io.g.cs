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
/// <summary>SpringCloudConfigurationService is the Schema for the SpringCloudConfigurationServices API. Manages a Spring Cloud Configuration Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudConfigurationServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudConfigurationService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudConfigurationServiceList";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudconfigurationservices";
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
    public IList<V1beta1SpringCloudConfigurationService> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the password of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderRepositoryPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the SSH private key of git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderRepositoryPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderRepository
{
    /// <summary>Specifies the ID of the Certificate Authority used when retrieving the Git Repository via HTTPS.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the SSH public key of git repository.</summary>
    [JsonPropertyName("hostKey")]
    public string? HostKey { get; set; }

    /// <summary>Specifies the SSH key algorithm of git repository.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the label of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specifies the name which should be used for this repository.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the password of git repository basic auth.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudConfigurationServiceSpecForProviderRepositoryPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Specifies the collection of patterns of the repository.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }

    /// <summary>Specifies the SSH private key of git repository.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1SpringCloudConfigurationServiceSpecForProviderRepositoryPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Specifies a list of searching path of the repository</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>Specifies whether enable the strict host key checking.</summary>
    [JsonPropertyName("strictHostKeyChecking")]
    public bool? StrictHostKeyChecking { get; set; }

    /// <summary>Specifies the URI of the repository.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdRefPolicy
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
/// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdSelectorPolicy
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
/// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdSelector
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
    public V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecForProvider
{
    /// <summary>The generation of the Spring Cloud Configuration Service. Possible values are Gen1 and Gen2.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Specifies how often to check repository updates. Minimum value is 0.</summary>
    [JsonPropertyName("refreshIntervalInSeconds")]
    public double? RefreshIntervalInSeconds { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudConfigurationServiceSpecForProviderRepository>? Repository { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Configuration Service to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdRef")]
    public V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdRef? SpringCloudServiceIdRef { get; set; }

    /// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdSelector")]
    public V1beta1SpringCloudConfigurationServiceSpecForProviderSpringCloudServiceIdSelector? SpringCloudServiceIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the password of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecInitProviderRepositoryPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the SSH private key of git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecInitProviderRepositoryPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecInitProviderRepository
{
    /// <summary>Specifies the ID of the Certificate Authority used when retrieving the Git Repository via HTTPS.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the SSH public key of git repository.</summary>
    [JsonPropertyName("hostKey")]
    public string? HostKey { get; set; }

    /// <summary>Specifies the SSH key algorithm of git repository.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the label of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specifies the name which should be used for this repository.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the password of git repository basic auth.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudConfigurationServiceSpecInitProviderRepositoryPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Specifies the collection of patterns of the repository.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }

    /// <summary>Specifies the SSH private key of git repository.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1SpringCloudConfigurationServiceSpecInitProviderRepositoryPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Specifies a list of searching path of the repository</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>Specifies whether enable the strict host key checking.</summary>
    [JsonPropertyName("strictHostKeyChecking")]
    public bool? StrictHostKeyChecking { get; set; }

    /// <summary>Specifies the URI of the repository.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecInitProvider
{
    /// <summary>The generation of the Spring Cloud Configuration Service. Possible values are Gen1 and Gen2.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Specifies how often to check repository updates. Minimum value is 0.</summary>
    [JsonPropertyName("refreshIntervalInSeconds")]
    public double? RefreshIntervalInSeconds { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudConfigurationServiceSpecInitProviderRepository>? Repository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpecProviderConfigRef
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
public partial class V1beta1SpringCloudConfigurationServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudConfigurationServiceSpec defines the desired state of SpringCloudConfigurationService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudConfigurationServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudConfigurationServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudConfigurationServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudConfigurationServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceStatusAtProviderRepository
{
    /// <summary>Specifies the ID of the Certificate Authority used when retrieving the Git Repository via HTTPS.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the SSH public key of git repository.</summary>
    [JsonPropertyName("hostKey")]
    public string? HostKey { get; set; }

    /// <summary>Specifies the SSH key algorithm of git repository.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the label of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specifies the name which should be used for this repository.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the collection of patterns of the repository.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }

    /// <summary>Specifies a list of searching path of the repository</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>Specifies whether enable the strict host key checking.</summary>
    [JsonPropertyName("strictHostKeyChecking")]
    public bool? StrictHostKeyChecking { get; set; }

    /// <summary>Specifies the URI of the repository.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceStatusAtProvider
{
    /// <summary>The generation of the Spring Cloud Configuration Service. Possible values are Gen1 and Gen2.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>The ID of the Spring Cloud Configuration Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies how often to check repository updates. Minimum value is 0.</summary>
    [JsonPropertyName("refreshIntervalInSeconds")]
    public double? RefreshIntervalInSeconds { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudConfigurationServiceStatusAtProviderRepository>? Repository { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Configuration Service to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceStatusConditions
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
/// <summary>SpringCloudConfigurationServiceStatus defines the observed state of SpringCloudConfigurationService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConfigurationServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudConfigurationServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudConfigurationServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudConfigurationService is the Schema for the SpringCloudConfigurationServices API. Manages a Spring Cloud Configuration Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudConfigurationService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudConfigurationServiceSpec>, IStatus<V1beta1SpringCloudConfigurationServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudConfigurationService";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudconfigurationservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudConfigurationServiceSpec defines the desired state of SpringCloudConfigurationService</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudConfigurationServiceSpec Spec { get; set; }

    /// <summary>SpringCloudConfigurationServiceStatus defines the observed state of SpringCloudConfigurationService.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudConfigurationServiceStatus? Status { get; set; }
}
#nullable disable
