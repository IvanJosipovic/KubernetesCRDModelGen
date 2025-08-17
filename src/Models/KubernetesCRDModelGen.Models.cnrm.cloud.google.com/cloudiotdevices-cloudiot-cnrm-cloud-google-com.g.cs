using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudiot.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIOTDeviceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudIOTDevice>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIOTDeviceList";
    public const string KubeGroup = "cloudiot.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudiotdevices";
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
    public IList<V1alpha1CloudIOTDevice> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A public key used to verify the signature of JSON Web Tokens (JWTs).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceSpecCredentialsPublicKey
{
    /// <summary>The format of the key. Possible values: ["RSA_PEM", "RSA_X509_PEM", "ES256_PEM", "ES256_X509_PEM"].</summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>The key data.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceSpecCredentials
{
    /// <summary>The time at which this credential becomes invalid.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A public key used to verify the signature of JSON Web Tokens (JWTs).</summary>
    [JsonPropertyName("publicKey")]
    public V1alpha1CloudIOTDeviceSpecCredentialsPublicKey PublicKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Gateway-related configuration and state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceSpecGatewayConfig
{
    /// <summary>Indicates whether the device is a gateway. Possible values: ["ASSOCIATION_ONLY", "DEVICE_AUTH_TOKEN_ONLY", "ASSOCIATION_AND_DEVICE_AUTH_TOKEN"].</summary>
    [JsonPropertyName("gatewayAuthMethod")]
    public string? GatewayAuthMethod { get; set; }

    /// <summary>Immutable. Indicates whether the device is a gateway. Default value: "NON_GATEWAY" Possible values: ["GATEWAY", "NON_GATEWAY"].</summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary>The ID of the gateway the device accessed most recently.</summary>
    [JsonPropertyName("lastAccessedGatewayId")]
    public string? LastAccessedGatewayId { get; set; }

    /// <summary>The most recent time at which the device accessed the gateway specified in last_accessed_gateway.</summary>
    [JsonPropertyName("lastAccessedGatewayTime")]
    public string? LastAccessedGatewayTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceSpec
{
    /// <summary>If a device is blocked, connections or requests from this device will fail.</summary>
    [JsonPropertyName("blocked")]
    public bool? Blocked { get; set; }

    /// <summary>The credentials used to authenticate this device.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1alpha1CloudIOTDeviceSpecCredentials>? Credentials { get; set; }

    /// <summary>Gateway-related configuration and state.</summary>
    [JsonPropertyName("gatewayConfig")]
    public V1alpha1CloudIOTDeviceSpecGatewayConfig? GatewayConfig { get; set; }

    /// <summary>The logging verbosity for device activity. Possible values: ["NONE", "ERROR", "INFO", "DEBUG"].</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>The metadata key-value pairs assigned to the device.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Immutable. The name of the device registry where this device should be created.</summary>
    [JsonPropertyName("registry")]
    public string Registry { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceStatusConfig
{
    /// <summary>The device configuration data.</summary>
    [JsonPropertyName("binaryData")]
    public string? BinaryData { get; set; }

    /// <summary>The time at which this configuration version was updated in Cloud IoT Core.</summary>
    [JsonPropertyName("cloudUpdateTime")]
    public string? CloudUpdateTime { get; set; }

    /// <summary>The time at which Cloud IoT Core received the acknowledgment from the device, indicating that the device has received this configuration version.</summary>
    [JsonPropertyName("deviceAckTime")]
    public string? DeviceAckTime { get; set; }

    /// <summary>The version of this update.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceStatusLastErrorStatus
{
    /// <summary>A list of messages that carry the error details.</summary>
    [JsonPropertyName("details")]
    public IList<JsonNode>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceStatusState
{
    /// <summary>The device state data.</summary>
    [JsonPropertyName("binaryData")]
    public string? BinaryData { get; set; }

    /// <summary>The time at which this state version was updated in Cloud IoT Core.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudIOTDeviceStatusConditions>? Conditions { get; set; }

    /// <summary>The most recent device configuration, which is eventually sent from Cloud IoT Core to the device.</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1CloudIOTDeviceStatusConfig>? Config { get; set; }

    /// <summary>The last time a cloud-to-device config version acknowledgment was received from the device.</summary>
    [JsonPropertyName("lastConfigAckTime")]
    public string? LastConfigAckTime { get; set; }

    /// <summary>The last time a cloud-to-device config version was sent to the device.</summary>
    [JsonPropertyName("lastConfigSendTime")]
    public string? LastConfigSendTime { get; set; }

    /// <summary>The error message of the most recent error, such as a failure to publish to Cloud Pub/Sub.</summary>
    [JsonPropertyName("lastErrorStatus")]
    public IList<V1alpha1CloudIOTDeviceStatusLastErrorStatus>? LastErrorStatus { get; set; }

    /// <summary>The time the most recent error occurred, such as a failure to publish to Cloud Pub/Sub.</summary>
    [JsonPropertyName("lastErrorTime")]
    public string? LastErrorTime { get; set; }

    /// <summary>The last time a telemetry event was received.</summary>
    [JsonPropertyName("lastEventTime")]
    public string? LastEventTime { get; set; }

    /// <summary>The last time an MQTT PINGREQ was received.</summary>
    [JsonPropertyName("lastHeartbeatTime")]
    public string? LastHeartbeatTime { get; set; }

    /// <summary>The last time a state event was received.</summary>
    [JsonPropertyName("lastStateTime")]
    public string? LastStateTime { get; set; }

    /// <summary>A server-defined unique numeric ID for the device. This is a more compact way to identify devices, and it is globally unique.</summary>
    [JsonPropertyName("numId")]
    public string? NumId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The state most recently received from the device.</summary>
    [JsonPropertyName("state")]
    public IList<V1alpha1CloudIOTDeviceStatusState>? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIOTDevice : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudIOTDeviceSpec>, IStatus<V1alpha1CloudIOTDeviceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIOTDevice";
    public const string KubeGroup = "cloudiot.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudiotdevices";
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
    public V1alpha1CloudIOTDeviceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudIOTDeviceStatus? Status { get; set; }
}
#nullable disable
