using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.crossplane.io;
/// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Source of the provider credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ProviderConfigSpecCredentialsSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    /// <summary>Secret</summary>
    Secret,
    [EnumMember(Value = "InjectedIdentity"), JsonStringEnumMemberName("InjectedIdentity")]
    /// <summary>InjectedIdentity</summary>
    InjectedIdentity,
    [EnumMember(Value = "Environment"), JsonStringEnumMemberName("Environment")]
    /// <summary>Environment</summary>
    Environment,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    /// <summary>Filesystem</summary>
    Filesystem
}

/// <summary>Credentials used to connect to the Kubernetes API. Typically a kubeconfig file. Use InjectedIdentity for in-cluster config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecCredentials
{
    /// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("env")]
    public V1beta1ProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProviderConfigSpecCredentialsSourceEnum>))]
    public V1beta1ProviderConfigSpecCredentialsSourceEnum Source { get; set; }
}

/// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecIdentityEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecIdentityFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecIdentitySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Source of the provider credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ProviderConfigSpecIdentitySourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    /// <summary>Secret</summary>
    Secret,
    [EnumMember(Value = "InjectedIdentity"), JsonStringEnumMemberName("InjectedIdentity")]
    /// <summary>InjectedIdentity</summary>
    InjectedIdentity,
    [EnumMember(Value = "Environment"), JsonStringEnumMemberName("Environment")]
    /// <summary>Environment</summary>
    Environment,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    /// <summary>Filesystem</summary>
    Filesystem
}

/// <summary>Type of identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ProviderConfigSpecIdentityTypeEnum
{
    [EnumMember(Value = "GoogleApplicationCredentials"), JsonStringEnumMemberName("GoogleApplicationCredentials")]
    /// <summary>GoogleApplicationCredentials</summary>
    GoogleApplicationCredentials,
    [EnumMember(Value = "AzureServicePrincipalCredentials"), JsonStringEnumMemberName("AzureServicePrincipalCredentials")]
    /// <summary>AzureServicePrincipalCredentials</summary>
    AzureServicePrincipalCredentials,
    [EnumMember(Value = "AzureWorkloadIdentityCredentials"), JsonStringEnumMemberName("AzureWorkloadIdentityCredentials")]
    /// <summary>AzureWorkloadIdentityCredentials</summary>
    AzureWorkloadIdentityCredentials,
    [EnumMember(Value = "UpboundTokens"), JsonStringEnumMemberName("UpboundTokens")]
    /// <summary>UpboundTokens</summary>
    UpboundTokens
}

/// <summary>Identity used to authenticate to the Kubernetes API. The identity credentials can be used to supplement kubeconfig 'credentials', for example by configuring a bearer token source such as OAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpecIdentity
{
    /// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("env")]
    public V1beta1ProviderConfigSpecIdentityEnv? Env { get; set; }

    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("fs")]
    public V1beta1ProviderConfigSpecIdentityFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ProviderConfigSpecIdentitySecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProviderConfigSpecIdentitySourceEnum>))]
    public V1beta1ProviderConfigSpecIdentitySourceEnum Source { get; set; }

    /// <summary>Type of identity.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProviderConfigSpecIdentityTypeEnum>))]
    public V1beta1ProviderConfigSpecIdentityTypeEnum Type { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigSpec
{
    /// <summary>Credentials used to connect to the Kubernetes API. Typically a kubeconfig file. Use InjectedIdentity for in-cluster config.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1ProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>Identity used to authenticate to the Kubernetes API. The identity credentials can be used to supplement kubeconfig 'credentials', for example by configuring a bearer token source such as OAuth.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ProviderConfigSpecIdentity? Identity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus defines the status of a Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ProviderConfig configures a Helm 'provider', i.e. a connection to a particular</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProviderConfigSpec>, IStatus<V1beta1ProviderConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProviderConfig";
    public const string KubeGroup = "helm.crossplane.io";
    public const string KubePluralName = "providerconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus defines the status of a Provider.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProviderConfigStatus? Status { get; set; }
}