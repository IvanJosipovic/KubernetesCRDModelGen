using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
#nullable enable
/// <summary>BackupDRManagementServer is the Schema for the BackupDRManagementServer API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRManagementServerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BackupDRManagementServer>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRManagementServerList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrmanagementservers";
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
    public IList<V1alpha1BackupDRManagementServer> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The resource name of the Google Compute Engine VPC network to which the ManagementServer instance is connected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerSpecNetworksNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerSpecNetworks
{
    /// <summary>Optional. The resource name of the Google Compute Engine VPC network to which the ManagementServer instance is connected.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1BackupDRManagementServerSpecNetworksNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. The network connect mode of the ManagementServer instance. For this version, only PRIVATE_SERVICE_ACCESS is supported.</summary>
    [JsonPropertyName("peeringMode")]
    public string? PeeringMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>BackupDRManagementServerSpec defines the desired state of BackupDRManagementServer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerSpec
{
    /// <summary>Optional. The description of the ManagementServer instance (2048 characters or less).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. Resource labels to represent user provided metadata. Labels currently defined: 1. migrate_from_go=&lt;false|true&gt; If set to true, the MS is created in migration ready mode.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. VPC networks to which the ManagementServer instance is connected. For this version, only a single network is supported. This field is optional if MS is created without PSA</summary>
    [JsonPropertyName("networks")]
    public IList<V1alpha1BackupDRManagementServerSpecNetworks>? Networks { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BackupDRManagementServerSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BackupDRManagementServer name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The type of the ManagementServer resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatusConditions
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
/// <summary>Output only. The hostname or ip address of the exposed AGM endpoints, used by clients to connect to AGM/RD graphical user interface and APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatusObservedStateManagementURI
{
    /// <summary>Output only. The ManagementServer AGM/RD API URL.</summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary>Output only. The ManagementServer AGM/RD WebUI URL.</summary>
    [JsonPropertyName("webUI")]
    public string? WebUI { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The hostnames of the exposed AGM endpoints for both types of user i.e. 1p and 3p, used to connect AGM/RM UI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatusObservedStateWorkforceIdentityBasedManagementURI
{
    /// <summary>Output only. First party Management URI for Google Identities.</summary>
    [JsonPropertyName("firstPartyManagementURI")]
    public string? FirstPartyManagementURI { get; set; }

    /// <summary>Output only. Third party Management URI for External Identity Providers.</summary>
    [JsonPropertyName("thirdPartyManagementURI")]
    public string? ThirdPartyManagementURI { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The OAuth client IDs for both types of user i.e. 1p and 3p.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatusObservedStateWorkforceIdentityBasedOAuth2ClientID
{
    /// <summary>Output only. First party OAuth Client ID for Google Identities.</summary>
    [JsonPropertyName("firstPartyOAuth2ClientID")]
    public string? FirstPartyOAuth2ClientID { get; set; }

    /// <summary>Output only. Third party OAuth Client ID for External Identity Providers.</summary>
    [JsonPropertyName("thirdPartyOAuth2ClientID")]
    public string? ThirdPartyOAuth2ClientID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatusObservedState
{
    /// <summary>Output only. The hostname or ip address of the exposed AGM endpoints, used by BAs to connect to BA proxy.</summary>
    [JsonPropertyName("baProxyURIs")]
    public IList<string>? BaProxyURIs { get; set; }

    /// <summary>Output only. The time when the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The hostname or ip address of the exposed AGM endpoints, used by clients to connect to AGM/RD graphical user interface and APIs.</summary>
    [JsonPropertyName("managementURI")]
    public V1alpha1BackupDRManagementServerStatusObservedStateManagementURI? ManagementURI { get; set; }

    /// <summary>Output only. The OAuth 2.0 client id is required to make API calls to the BackupDR instance API of this ManagementServer. This is the value that should be provided in the 'aud' field of the OIDC ID Token (see openid specification https://openid.net/specs/openid-connect-core-1_0.html#IDToken).</summary>
    [JsonPropertyName("oauth2ClientID")]
    public string? Oauth2ClientID { get; set; }

    /// <summary>Output only. The ManagementServer state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the instance was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The hostnames of the exposed AGM endpoints for both types of user i.e. 1p and 3p, used to connect AGM/RM UI.</summary>
    [JsonPropertyName("workforceIdentityBasedManagementURI")]
    public V1alpha1BackupDRManagementServerStatusObservedStateWorkforceIdentityBasedManagementURI? WorkforceIdentityBasedManagementURI { get; set; }

    /// <summary>Output only. The OAuth client IDs for both types of user i.e. 1p and 3p.</summary>
    [JsonPropertyName("workforceIdentityBasedOAuth2ClientID")]
    public V1alpha1BackupDRManagementServerStatusObservedStateWorkforceIdentityBasedOAuth2ClientID? WorkforceIdentityBasedOAuth2ClientID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BackupDRManagementServerStatus defines the config connector machine state of BackupDRManagementServer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRManagementServerStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BackupDRManagementServerStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRManagementServer resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BackupDRManagementServerStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BackupDRManagementServer is the Schema for the BackupDRManagementServer API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRManagementServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BackupDRManagementServerSpec>, IStatus<V1alpha1BackupDRManagementServerStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRManagementServer";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrmanagementservers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRManagementServerSpec defines the desired state of BackupDRManagementServer</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BackupDRManagementServerSpec Spec { get; set; }

    /// <summary>BackupDRManagementServerStatus defines the config connector machine state of BackupDRManagementServer</summary>
    [JsonPropertyName("status")]
    public V1alpha1BackupDRManagementServerStatus? Status { get; set; }
}
#nullable disable
