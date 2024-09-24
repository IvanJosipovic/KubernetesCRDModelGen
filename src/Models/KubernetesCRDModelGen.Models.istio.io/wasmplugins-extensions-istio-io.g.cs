using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.extensions.istio.io;
public enum V1alpha1WasmPluginSpecFailStrategyEnum
{
    [EnumMember(Value = "FAIL_CLOSE"), JsonStringEnumMemberName("FAIL_CLOSE")]
    /// <summary>FAIL_CLOSE</summary>
    FAILCLOSE,
    [EnumMember(Value = "FAIL_OPEN"), JsonStringEnumMemberName("FAIL_OPEN")]
    /// <summary>FAIL_OPEN</summary>
    FAILOPEN
}

public enum V1alpha1WasmPluginSpecImagePullPolicyEnum
{
    [EnumMember(Value = "UNSPECIFIED_POLICY"), JsonStringEnumMemberName("UNSPECIFIED_POLICY")]
    /// <summary>UNSPECIFIED_POLICY</summary>
    UNSPECIFIEDPOLICY,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always
}

public enum V1alpha1WasmPluginSpecMatchModeEnum
{
    [EnumMember(Value = "UNDEFINED"), JsonStringEnumMemberName("UNDEFINED")]
    /// <summary>UNDEFINED</summary>
    UNDEFINED,
    [EnumMember(Value = "CLIENT"), JsonStringEnumMemberName("CLIENT")]
    /// <summary>CLIENT</summary>
    CLIENT,
    [EnumMember(Value = "SERVER"), JsonStringEnumMemberName("SERVER")]
    /// <summary>SERVER</summary>
    SERVER,
    [EnumMember(Value = "CLIENT_AND_SERVER"), JsonStringEnumMemberName("CLIENT_AND_SERVER")]
    /// <summary>CLIENT_AND_SERVER</summary>
    CLIENTANDSERVER
}

public partial class V1alpha1WasmPluginSpecMatchPorts
{
    /// <summary></summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }
}

public partial class V1alpha1WasmPluginSpecMatch
{
    /// <summary>Criteria for selecting traffic by their direction.  Valid Options: CLIENT, SERVER, CLIENT_AND_SERVER</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecMatchModeEnum>))]
    public V1alpha1WasmPluginSpecMatchModeEnum? Mode { get; set; }

    /// <summary>Criteria for selecting traffic by their destination port.</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1WasmPluginSpecMatchPorts>? Ports { get; set; }
}

public enum V1alpha1WasmPluginSpecPhaseEnum
{
    [EnumMember(Value = "UNSPECIFIED_PHASE"), JsonStringEnumMemberName("UNSPECIFIED_PHASE")]
    /// <summary>UNSPECIFIED_PHASE</summary>
    UNSPECIFIEDPHASE,
    [EnumMember(Value = "AUTHN"), JsonStringEnumMemberName("AUTHN")]
    /// <summary>AUTHN</summary>
    AUTHN,
    [EnumMember(Value = "AUTHZ"), JsonStringEnumMemberName("AUTHZ")]
    /// <summary>AUTHZ</summary>
    AUTHZ,
    [EnumMember(Value = "STATS"), JsonStringEnumMemberName("STATS")]
    /// <summary>STATS</summary>
    STATS
}

public partial class V1alpha1WasmPluginSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

public partial class V1alpha1WasmPluginSpecTargetRef
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1WasmPluginSpecTargetRefs
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public enum V1alpha1WasmPluginSpecTypeEnum
{
    [EnumMember(Value = "UNSPECIFIED_PLUGIN_TYPE"), JsonStringEnumMemberName("UNSPECIFIED_PLUGIN_TYPE")]
    /// <summary>UNSPECIFIED_PLUGIN_TYPE</summary>
    UNSPECIFIEDPLUGINTYPE,
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    /// <summary>HTTP</summary>
    HTTP,
    [EnumMember(Value = "NETWORK"), JsonStringEnumMemberName("NETWORK")]
    /// <summary>NETWORK</summary>
    NETWORK
}

public enum V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum
{
    [EnumMember(Value = "INLINE"), JsonStringEnumMemberName("INLINE")]
    /// <summary>INLINE</summary>
    INLINE,
    [EnumMember(Value = "HOST"), JsonStringEnumMemberName("HOST")]
    /// <summary>HOST</summary>
    HOST
}

public partial class V1alpha1WasmPluginSpecVmConfigEnv
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value for the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value.  Valid Options: INLINE, HOST</summary>
    [JsonPropertyName("valueFrom")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum>))]
    public V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum? ValueFrom { get; set; }
}

public partial class V1alpha1WasmPluginSpecVmConfig
{
    /// <summary>Specifies environment variables to be injected to this VM.</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1WasmPluginSpecVmConfigEnv>? Env { get; set; }
}

public partial class V1alpha1WasmPluginSpec
{
    /// <summary>Specifies the failure behavior for the plugin due to fatal errors.  Valid Options: FAIL_CLOSE, FAIL_OPEN</summary>
    [JsonPropertyName("failStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecFailStrategyEnum>))]
    public V1alpha1WasmPluginSpecFailStrategyEnum? FailStrategy { get; set; }

    /// <summary>The pull behaviour to be applied when fetching Wasm module by either OCI image or `http/https`.  Valid Options: IfNotPresent, Always</summary>
    [JsonPropertyName("imagePullPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecImagePullPolicyEnum>))]
    public V1alpha1WasmPluginSpecImagePullPolicyEnum? ImagePullPolicy { get; set; }

    /// <summary>Credentials to use for OCI image pulling.</summary>
    [JsonPropertyName("imagePullSecret")]
    public string? ImagePullSecret { get; set; }

    /// <summary>Specifies the criteria to determine which traffic is passed to WasmPlugin.</summary>
    [JsonPropertyName("match")]
    public IList<V1alpha1WasmPluginSpecMatch>? Match { get; set; }

    /// <summary>Determines where in the filter chain this `WasmPlugin` is to be injected.  Valid Options: AUTHN, AUTHZ, STATS</summary>
    [JsonPropertyName("phase")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecPhaseEnum>))]
    public V1alpha1WasmPluginSpecPhaseEnum? Phase { get; set; }

    /// <summary>The configuration that will be passed on to the plugin.</summary>
    [JsonPropertyName("pluginConfig")]
    public JsonNode? PluginConfig { get; set; }

    /// <summary>The plugin name to be used in the Envoy configuration (used to be called `rootID`).</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>Determines ordering of `WasmPlugins` in the same `phase`.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this plugin configuration should be applied.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1WasmPluginSpecSelector? Selector { get; set; }

    /// <summary>SHA256 checksum that will be used to verify Wasm module or OCI container.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRef")]
    public V1alpha1WasmPluginSpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1WasmPluginSpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>Specifies the type of Wasm Extension to be used.  Valid Options: HTTP, NETWORK</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecTypeEnum>))]
    public V1alpha1WasmPluginSpecTypeEnum? Type { get; set; }

    /// <summary>URL of a Wasm module or OCI container.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("verificationKey")]
    public string? VerificationKey { get; set; }

    /// <summary>Configuration for a Wasm VM.</summary>
    [JsonPropertyName("vmConfig")]
    public V1alpha1WasmPluginSpecVmConfig? VmConfig { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WasmPlugin : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WasmPluginSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WasmPlugin";
    public const string KubeGroup = "extensions.istio.io";
    public const string KubePluralName = "wasmplugins";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Extend the functionality provided by the Istio proxy through WebAssembly filters. See more details at: https://istio.io/docs/reference/config/proxy_extensions/wasm-plugin.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha1WasmPluginSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}