using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeInterconnect is the Schema for the ComputeInterconnect API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeInterconnectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeInterconnect>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeInterconnectList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeinterconnects";
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
    public IList<V1alpha1ComputeInterconnect> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectSpecMacsecPreSharedKeys
{
    /// <summary>Required. A name for this pre-shared key. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A RFC3339 timestamp on or after which the key is valid. startTime can be in the future. If the keychain has a single key, startTime can be omitted. If the keychain has multiple keys, startTime is mandatory for each key. The start times of keys must be in increasing order. The start times of two consecutive keys must be at least 6 hours apart.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Configuration that enables Media Access Control security (MACsec) on the Cloud Interconnect connection between Google and your on-premises router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectSpecMacsec
{
    /// <summary>If set to true, the Interconnect connection is configured with a should-secure MACsec security policy, that allows the Google router to fallback to cleartext traffic if the MKA session cannot be established. By default, the Interconnect connection is configured with a must-secure security policy that drops all traffic if the MKA session cannot be established with your router.</summary>
    [JsonPropertyName("failOpen")]
    public bool? FailOpen { get; set; }

    /// <summary>Required. A keychain placeholder describing a set of named key objects along with their start times. A MACsec CKN/CAK is generated for each key in the key chain. Google router automatically picks the key with the most recent startTime when establishing or re-establishing a MACsec secure link.</summary>
    [JsonPropertyName("preSharedKeys")]
    public IList<V1alpha1ComputeInterconnectSpecMacsecPreSharedKeys>? PreSharedKeys { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectSpecProjectRef
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

/// <summary>ComputeInterconnectSpec defines the desired state of ComputeInterconnect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectSpec
{
    /// <summary>Administrative status of the interconnect. When this is set to true, the Interconnect is functional and can carry traffic. When set to false, no packets can be carried over the interconnect and no BGP routes are exchanged over it. By default, the status is set to true.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>Customer name, to put in the Letter of Authorization as the party authorized to request a crossconnect.</summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Type of interconnect, which can take one of the following values: - PARTNER: A partner-managed interconnection shared between customers though a partner. - DEDICATED: A dedicated physical interconnection with the customer. Note that a value IT_PRIVATE has been deprecated in favor of DEDICATED. Check the InterconnectType enum for the list of possible values.</summary>
    [JsonPropertyName("interconnectType")]
    public string? InterconnectType { get; set; }

    /// <summary>A fingerprint for the labels being applied to this Interconnect, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet. To see the latest fingerprint, make a get() request to retrieve an Interconnect.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type of link requested, which can take one of the following values: - LINK_TYPE_ETHERNET_10G_LR: A 10G Ethernet with LR optics - LINK_TYPE_ETHERNET_100G_LR: A 100G Ethernet with LR optics. Note that this field indicates the speed of each of the links in the bundle, not the speed of the entire bundle. Check the LinkType enum for the list of possible values.</summary>
    [JsonPropertyName("linkType")]
    public string? LinkType { get; set; }

    /// <summary>URL of the InterconnectLocation object that represents where this connection is to be provisioned.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Configuration that enables Media Access Control security (MACsec) on the Cloud Interconnect connection between Google and your on-premises router.</summary>
    [JsonPropertyName("macsec")]
    public V1alpha1ComputeInterconnectSpecMacsec? Macsec { get; set; }

    /// <summary>Enable or disable MACsec on this Interconnect connection. MACsec enablement fails if the MACsec object is not specified.</summary>
    [JsonPropertyName("macsecEnabled")]
    public bool? MacsecEnabled { get; set; }

    /// <summary>Email address to contact the customer NOC for operations and maintenance notifications regarding this Interconnect. If specified, this will be used for notifications in addition to all other forms described, such as Cloud Monitoring logs alerting and Cloud Notifications. This field is required for users who sign up for Cloud Interconnect using workforce identity federation.</summary>
    [JsonPropertyName("nocContactEmail")]
    public string? NocContactEmail { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeInterconnectSpecProjectRef ProjectRef { get; set; }

    /// <summary>Indicates that this is a Cross-Cloud Interconnect. This field specifies the location outside of Google's network that the interconnect is connected to.</summary>
    [JsonPropertyName("remoteLocation")]
    public string? RemoteLocation { get; set; }

    /// <summary>Optional. List of features requested for this Interconnect connection, which can take one of the following values: - IF_MACSEC If specified then the connection is created on MACsec capable hardware ports. If not specified, the default value is false, which allocates non-MACsec capable ports first if available. This parameter can be provided only with Interconnect INSERT. It isn't valid for Interconnect PATCH. Check the RequestedFeatures enum for the list of possible values.</summary>
    [JsonPropertyName("requestedFeatures")]
    public IList<string>? RequestedFeatures { get; set; }

    /// <summary>Target number of physical links in the link bundle, as requested by the customer.</summary>
    [JsonPropertyName("requestedLinkCount")]
    public int? RequestedLinkCount { get; set; }

    /// <summary>The ComputeInterconnect name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectStatusConditions
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
public partial class V1alpha1ComputeInterconnectStatusObservedStateCircuitInfos
{
    /// <summary>Customer-side demarc ID for this circuit.</summary>
    [JsonPropertyName("customerDemarcID")]
    public string? CustomerDemarcID { get; set; }

    /// <summary>Google-assigned unique ID for this circuit. Assigned at circuit turn-up.</summary>
    [JsonPropertyName("googleCircuitID")]
    public string? GoogleCircuitID { get; set; }

    /// <summary>Google-side demarc ID for this circuit. Assigned at circuit turn-up and provided by Google to the customer in the LOA.</summary>
    [JsonPropertyName("googleDemarcID")]
    public string? GoogleDemarcID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectStatusObservedStateExpectedOutages
{
    /// <summary>If issue_type is IT_PARTIAL_OUTAGE, a list of the Google-side circuit IDs that will be affected.</summary>
    [JsonPropertyName("affectedCircuits")]
    public IList<string>? AffectedCircuits { get; set; }

    /// <summary>A description about the purpose of the outage.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Scheduled end time for the outage (milliseconds since Unix epoch).</summary>
    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    /// <summary>Form this outage is expected to take, which can take one of the following values: - OUTAGE: The Interconnect may be completely out of service for some or all of the specified window. - PARTIAL_OUTAGE: Some circuits comprising the Interconnect as a whole should remain up, but with reduced bandwidth. Note that the versions of this enum prefixed with "IT_" have been deprecated in favor of the unprefixed values. Check the IssueType enum for the list of possible values.</summary>
    [JsonPropertyName("issueType")]
    public string? IssueType { get; set; }

    /// <summary>Unique identifier for this outage notification.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The party that generated this notification, which can take the following value: - GOOGLE: this notification as generated by Google. Note that the value of NSRC_GOOGLE has been deprecated in favor of GOOGLE. Check the Source enum for the list of possible values.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Scheduled start time for the outage (milliseconds since Unix epoch).</summary>
    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    /// <summary>State of this notification, which can take one of the following values: - ACTIVE: This outage notification is active. The event could be in the past, present, or future. See start_time and end_time for scheduling. - CANCELLED: The outage associated with this notification was cancelled before the outage was due to start. - COMPLETED: The outage associated with this notification is complete. Note that the versions of this enum prefixed with "NS_" have been deprecated in favor of the unprefixed values. Check the State enum for the list of possible values.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectStatusObservedState
{
    /// <summary>[Output only] List of features available for this Interconnect connection, which can take one of the following values: - IF_MACSEC If present then the Interconnect connection is provisioned on MACsec capable hardware ports. If not present then the Interconnect connection is provisioned on non-MACsec capable ports and MACsec isn't supported and enabling MACsec fails. Check the AvailableFeatures enum for the list of possible values.</summary>
    [JsonPropertyName("availableFeatures")]
    public IList<string>? AvailableFeatures { get; set; }

    /// <summary>[Output Only] A list of CircuitInfo objects, that describe the individual circuits in this LAG.</summary>
    [JsonPropertyName("circuitInfos")]
    public IList<V1alpha1ComputeInterconnectStatusObservedStateCircuitInfos>? CircuitInfos { get; set; }

    /// <summary>[Output Only] Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>[Output Only] A list of outages expected for this Interconnect.</summary>
    [JsonPropertyName("expectedOutages")]
    public IList<V1alpha1ComputeInterconnectStatusObservedStateExpectedOutages>? ExpectedOutages { get; set; }

    /// <summary>[Output Only] IP address configured on the Google side of the Interconnect link. This can be used only for ping tests.</summary>
    [JsonPropertyName("googleIPAddress")]
    public string? GoogleIPAddress { get; set; }

    /// <summary>[Output Only] Google reference ID to be used when raising support tickets with Google or otherwise to debug backend connectivity issues.</summary>
    [JsonPropertyName("googleReferenceID")]
    public string? GoogleReferenceID { get; set; }

    /// <summary>[Output Only] The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>[Output Only] A list of the URLs of all InterconnectAttachments configured to use this Interconnect.</summary>
    [JsonPropertyName("interconnectAttachments")]
    public IList<string>? InterconnectAttachments { get; set; }

    /// <summary>[Output Only] Type of the resource. Always compute#interconnect for interconnects.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>[Output Only] The current status of this Interconnect's functionality, which can take one of the following values: - OS_ACTIVE: A valid Interconnect, which is turned up and is ready to use. Attachments may be provisioned on this Interconnect. - OS_UNPROVISIONED: An Interconnect that has not completed turnup. No attachments may be provisioned on this Interconnect. - OS_UNDER_MAINTENANCE: An Interconnect that is undergoing internal maintenance. No attachments may be provisioned or updated on this Interconnect. Check the OperationalStatus enum for the list of possible values.</summary>
    [JsonPropertyName("operationalStatus")]
    public string? OperationalStatus { get; set; }

    /// <summary>[Output Only] IP address configured on the customer side of the Interconnect link. The customer should configure this IP address during turnup when prompted by Google NOC. This can be used only for ping tests.</summary>
    [JsonPropertyName("peerIPAddress")]
    public string? PeerIPAddress { get; set; }

    /// <summary>[Output Only] Number of links actually provisioned in this interconnect.</summary>
    [JsonPropertyName("provisionedLinkCount")]
    public int? ProvisionedLinkCount { get; set; }

    /// <summary>[Output Only] Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzs")]
    public bool? SatisfiesPzs { get; set; }

    /// <summary>[Output Only] Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>[Output Only] The current state of Interconnect functionality, which can take one of the following values: - ACTIVE: The Interconnect is valid, turned up and ready to use. Attachments may be provisioned on this Interconnect. - UNPROVISIONED: The Interconnect has not completed turnup. No attachments may be provisioned on this Interconnect. - UNDER_MAINTENANCE: The Interconnect is undergoing internal maintenance. No attachments may be provisioned or updated on this Interconnect. Check the State enum for the list of possible values.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ComputeInterconnectStatus defines the config connector machine state of ComputeInterconnect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeInterconnectStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeInterconnectStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComputeInterconnect resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ComputeInterconnectStatusObservedState? ObservedState { get; set; }
}

/// <summary>ComputeInterconnect is the Schema for the ComputeInterconnect API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeInterconnect : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeInterconnectSpec>, IStatus<V1alpha1ComputeInterconnectStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeInterconnect";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeinterconnects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeInterconnectSpec defines the desired state of ComputeInterconnect</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ComputeInterconnectSpec Spec { get; set; }

    /// <summary>ComputeInterconnectStatus defines the config connector machine state of ComputeInterconnect</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeInterconnectStatus? Status { get; set; }
}