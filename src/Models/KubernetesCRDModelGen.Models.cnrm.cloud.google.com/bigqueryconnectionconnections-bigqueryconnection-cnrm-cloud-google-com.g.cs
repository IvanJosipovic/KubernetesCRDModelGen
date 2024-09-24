using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryconnection.cnrm.cloud.google.com;
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudResource
{
}

public partial class V1alpha1BigQueryConnectionConnectionSpecProjectRef
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

public partial class V1alpha1BigQueryConnectionConnectionSpec
{
    /// <summary>Use Cloud Resource properties.</summary>
    [JsonPropertyName("cloudResource")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudResource? CloudResource { get; set; }

    /// <summary>User provided description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User provided display name for the connection.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryConnectionConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BigQuery ConnectionID. This is a server-generated ID in the UUID format. If not provided, ConfigConnector will create a new Connection and store the UUID in `status.serviceGeneratedID` field.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1BigQueryConnectionConnectionStatusConditions
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

public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudResource
{
    /// <summary>Output only. The account ID of the service created for the purpose of this  connection.   The service account does not have any permissions associated with it  when it is created. After creation, customers delegate permissions  to the service account. When the connection is used in the context of an  operation in BigQuery, the service account will be used to connect to the  desired resources in GCP.   The account ID is in the form of:    &lt;service-1234&gt;@gcp-sa-bigquery-cloudresource.iam.gserviceaccount.com</summary>
    [JsonPropertyName("serviceAccountID")]
    public string? ServiceAccountID { get; set; }
}

public partial class V1alpha1BigQueryConnectionConnectionStatusObservedState
{
    /// <summary></summary>
    [JsonPropertyName("cloudResource")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudResource? CloudResource { get; set; }

    /// <summary>The description for the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for the connection.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Output only. True, if credential is configured for this connection.</summary>
    [JsonPropertyName("hasCredential")]
    public bool? HasCredential { get; set; }
}

public partial class V1alpha1BigQueryConnectionConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryConnectionConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryConnectionConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedState? ObservedState { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryConnectionConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryConnectionConnectionSpec>, IStatus<V1alpha1BigQueryConnectionConnectionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryConnectionConnection";
    public const string KubeGroup = "bigqueryconnection.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryconnectionconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryConnectionConnectionSpec defines the desired state to connect BigQuery to external resources</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigQueryConnectionConnectionSpec? Spec { get; set; }

    /// <summary>BigQueryConnectionConnectionStatus defines the config connector machine state of BigQueryConnectionConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryConnectionConnectionStatus? Status { get; set; }
}