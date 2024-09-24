using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.azuread.upbound.io;
public enum V1beta1ProviderConfigUsageProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ProviderConfigUsageProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ProviderConfigUsageProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProviderConfigUsageProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ProviderConfigUsageProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ProviderConfigUsageProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ProviderConfigUsageProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference to the provider config being used.</summary>
public partial class V1beta1ProviderConfigUsageProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProviderConfigUsageProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>ResourceReference to the managed resource using the provider config.</summary>
public partial class V1beta1ProviderConfigUsageResourceRef
{
    /// <summary>APIVersion of the referenced object.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>UID of the referenced object.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>A ProviderConfigUsage indicates that a resource is using a ProviderConfig.</summary>
public partial class V1beta1ProviderConfigUsage : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProviderConfigUsage";
    public const string KubeGroup = "azuread.upbound.io";
    public const string KubePluralName = "providerconfigusages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderConfigReference to the provider config being used.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ProviderConfigUsageProviderConfigRef ProviderConfigRef { get; set; }

    /// <summary>ResourceReference to the managed resource using the provider config.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1ProviderConfigUsageResourceRef ResourceRef { get; set; }
}