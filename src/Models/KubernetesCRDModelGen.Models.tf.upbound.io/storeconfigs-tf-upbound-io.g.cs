using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tf.upbound.io;
/// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
public partial class V1beta1StoreConfigSpecKubernetesAuthEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
public partial class V1beta1StoreConfigSpecKubernetesAuthFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
public partial class V1beta1StoreConfigSpecKubernetesAuthSecretRef
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

public enum V1beta1StoreConfigSpecKubernetesAuthSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    /// <summary>Secret</summary>
    Secret,
    [EnumMember(Value = "Environment"), JsonStringEnumMemberName("Environment")]
    /// <summary>Environment</summary>
    Environment,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    /// <summary>Filesystem</summary>
    Filesystem
}

/// <summary>Credentials used to connect to the Kubernetes API.</summary>
public partial class V1beta1StoreConfigSpecKubernetesAuth
{
    /// <summary>Env is a reference to an environment variable that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("env")]
    public V1beta1StoreConfigSpecKubernetesAuthEnv? Env { get; set; }

    /// <summary>Fs is a reference to a filesystem location that contains credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("fs")]
    public V1beta1StoreConfigSpecKubernetesAuthFs? Fs { get; set; }

    /// <summary>A SecretRef is a reference to a secret key that contains the credentials that must be used to connect to the provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1StoreConfigSpecKubernetesAuthSecretRef? SecretRef { get; set; }

    /// <summary>Source of the credentials.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StoreConfigSpecKubernetesAuthSourceEnum>))]
    public V1beta1StoreConfigSpecKubernetesAuthSourceEnum Source { get; set; }
}

/// <summary>Kubernetes configures a Kubernetes secret store. If the "type" is "Kubernetes" but no config provided, in cluster config will be used.</summary>
public partial class V1beta1StoreConfigSpecKubernetes
{
    /// <summary>Credentials used to connect to the Kubernetes API.</summary>
    [JsonPropertyName("auth")]
    public V1beta1StoreConfigSpecKubernetesAuth Auth { get; set; }
}

/// <summary>ConfigRef contains store config reference info.</summary>
public partial class V1beta1StoreConfigSpecPluginConfigRef
{
    /// <summary>APIVersion of the referenced config.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the referenced config.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced config.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Plugin configures External secret store as a plugin.</summary>
public partial class V1beta1StoreConfigSpecPlugin
{
    /// <summary>ConfigRef contains store config reference info.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StoreConfigSpecPluginConfigRef? ConfigRef { get; set; }

    /// <summary>Endpoint is the endpoint of the gRPC server.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

public enum V1beta1StoreConfigSpecTypeEnum
{
    [EnumMember(Value = "Kubernetes"), JsonStringEnumMemberName("Kubernetes")]
    /// <summary>Kubernetes</summary>
    Kubernetes,
    [EnumMember(Value = "Vault"), JsonStringEnumMemberName("Vault")]
    /// <summary>Vault</summary>
    Vault,
    [EnumMember(Value = "Plugin"), JsonStringEnumMemberName("Plugin")]
    /// <summary>Plugin</summary>
    Plugin
}

/// <summary>A StoreConfigSpec defines the desired state of a ProviderConfig.</summary>
public partial class V1beta1StoreConfigSpec
{
    /// <summary>DefaultScope used for scoping secrets for "cluster-scoped" resources. If store type is "Kubernetes", this would mean the default namespace to store connection secrets for cluster scoped resources. In case of "Vault", this would be used as the default parent path. Typically, should be set as Crossplane installation namespace.</summary>
    [JsonPropertyName("defaultScope")]
    public string DefaultScope { get; set; }

    /// <summary>Kubernetes configures a Kubernetes secret store. If the "type" is "Kubernetes" but no config provided, in cluster config will be used.</summary>
    [JsonPropertyName("kubernetes")]
    public V1beta1StoreConfigSpecKubernetes? Kubernetes { get; set; }

    /// <summary>Plugin configures External secret store as a plugin.</summary>
    [JsonPropertyName("plugin")]
    public V1beta1StoreConfigSpecPlugin? Plugin { get; set; }

    /// <summary>Type configures which secret store to be used. Only the configuration block for this store will be used and others will be ignored if provided. Default is Kubernetes.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StoreConfigSpecTypeEnum>))]
    public V1beta1StoreConfigSpecTypeEnum? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1StoreConfigStatusConditions
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

/// <summary>A StoreConfigStatus represents the status of a StoreConfig.</summary>
public partial class V1beta1StoreConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StoreConfigStatusConditions>? Conditions { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>A StoreConfig configures how GCP controller should store connection details.</summary>
public partial class V1beta1StoreConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StoreConfigSpec>, IStatus<V1beta1StoreConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StoreConfig";
    public const string KubeGroup = "tf.upbound.io";
    public const string KubePluralName = "storeconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A StoreConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1StoreConfigSpec Spec { get; set; }

    /// <summary>A StoreConfigStatus represents the status of a StoreConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1StoreConfigStatus? Status { get; set; }
}