using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>CertSecretRef specifies the Secret containing a PEM-encoded CA certificate (in the `ca.crt` key).   Note: Support for the `caFile` key has been deprecated.</summary>
public partial class V1beta3ProviderSpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretRef specifies the Secret containing the authentication credentials for this Provider.</summary>
public partial class V1beta3ProviderSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public enum V1beta3ProviderSpecTypeEnum
{
    [EnumMember(Value = "slack"), JsonStringEnumMemberName("slack")]
    /// <summary>slack</summary>
    Slack,
    [EnumMember(Value = "discord"), JsonStringEnumMemberName("discord")]
    /// <summary>discord</summary>
    Discord,
    [EnumMember(Value = "msteams"), JsonStringEnumMemberName("msteams")]
    /// <summary>msteams</summary>
    Msteams,
    [EnumMember(Value = "rocket"), JsonStringEnumMemberName("rocket")]
    /// <summary>rocket</summary>
    Rocket,
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    /// <summary>generic</summary>
    Generic,
    [EnumMember(Value = "generic-hmac"), JsonStringEnumMemberName("generic-hmac")]
    /// <summary>generic-hmac</summary>
    GenericHmac,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    /// <summary>github</summary>
    Github,
    [EnumMember(Value = "gitlab"), JsonStringEnumMemberName("gitlab")]
    /// <summary>gitlab</summary>
    Gitlab,
    [EnumMember(Value = "gitea"), JsonStringEnumMemberName("gitea")]
    /// <summary>gitea</summary>
    Gitea,
    [EnumMember(Value = "bitbucketserver"), JsonStringEnumMemberName("bitbucketserver")]
    /// <summary>bitbucketserver</summary>
    Bitbucketserver,
    [EnumMember(Value = "bitbucket"), JsonStringEnumMemberName("bitbucket")]
    /// <summary>bitbucket</summary>
    Bitbucket,
    [EnumMember(Value = "azuredevops"), JsonStringEnumMemberName("azuredevops")]
    /// <summary>azuredevops</summary>
    Azuredevops,
    [EnumMember(Value = "googlechat"), JsonStringEnumMemberName("googlechat")]
    /// <summary>googlechat</summary>
    Googlechat,
    [EnumMember(Value = "googlepubsub"), JsonStringEnumMemberName("googlepubsub")]
    /// <summary>googlepubsub</summary>
    Googlepubsub,
    [EnumMember(Value = "webex"), JsonStringEnumMemberName("webex")]
    /// <summary>webex</summary>
    Webex,
    [EnumMember(Value = "sentry"), JsonStringEnumMemberName("sentry")]
    /// <summary>sentry</summary>
    Sentry,
    [EnumMember(Value = "azureeventhub"), JsonStringEnumMemberName("azureeventhub")]
    /// <summary>azureeventhub</summary>
    Azureeventhub,
    [EnumMember(Value = "telegram"), JsonStringEnumMemberName("telegram")]
    /// <summary>telegram</summary>
    Telegram,
    [EnumMember(Value = "lark"), JsonStringEnumMemberName("lark")]
    /// <summary>lark</summary>
    Lark,
    [EnumMember(Value = "matrix"), JsonStringEnumMemberName("matrix")]
    /// <summary>matrix</summary>
    Matrix,
    [EnumMember(Value = "opsgenie"), JsonStringEnumMemberName("opsgenie")]
    /// <summary>opsgenie</summary>
    Opsgenie,
    [EnumMember(Value = "alertmanager"), JsonStringEnumMemberName("alertmanager")]
    /// <summary>alertmanager</summary>
    Alertmanager,
    [EnumMember(Value = "grafana"), JsonStringEnumMemberName("grafana")]
    /// <summary>grafana</summary>
    Grafana,
    [EnumMember(Value = "githubdispatch"), JsonStringEnumMemberName("githubdispatch")]
    /// <summary>githubdispatch</summary>
    Githubdispatch,
    [EnumMember(Value = "pagerduty"), JsonStringEnumMemberName("pagerduty")]
    /// <summary>pagerduty</summary>
    Pagerduty,
    [EnumMember(Value = "datadog"), JsonStringEnumMemberName("datadog")]
    /// <summary>datadog</summary>
    Datadog,
    [EnumMember(Value = "nats"), JsonStringEnumMemberName("nats")]
    /// <summary>nats</summary>
    Nats
}

/// <summary>ProviderSpec defines the desired state of the Provider.</summary>
public partial class V1beta3ProviderSpec
{
    /// <summary>Address specifies the endpoint, in a generic sense, to where alerts are sent. What kind of endpoint depends on the specific Provider type being used. For the generic Provider, for example, this is an HTTP/S address. For other Provider types this could be a project ID or a namespace.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>CertSecretRef specifies the Secret containing a PEM-encoded CA certificate (in the `ca.crt` key).   Note: Support for the `caFile` key has been deprecated.</summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta3ProviderSpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Channel specifies the destination channel where events should be posted.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Interval at which to reconcile the Provider with its Secret references. Deprecated and not used in v1beta3.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Proxy the HTTP/S address of the proxy server.</summary>
    [JsonPropertyName("proxy")]
    public string? Proxy { get; set; }

    /// <summary>SecretRef specifies the Secret containing the authentication credentials for this Provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta3ProviderSpecSecretRef? SecretRef { get; set; }

    /// <summary>Suspend tells the controller to suspend subsequent events handling for this Provider.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for sending alerts to the Provider.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Type specifies which Provider implementation to use.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta3ProviderSpecTypeEnum>))]
    public V1beta3ProviderSpecTypeEnum Type { get; set; }

    /// <summary>Username specifies the name under which events are posted.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Provider is the Schema for the providers API</summary>
public partial class V1beta3Provider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta3ProviderSpec>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "Provider";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderSpec defines the desired state of the Provider.</summary>
    [JsonPropertyName("spec")]
    public V1beta3ProviderSpec? Spec { get; set; }
}