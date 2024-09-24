using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcare.cnrm.cloud.google.com;
/// <summary>A nested object resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecNotificationConfig
{
    /// <summary>The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client. PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecNotificationConfigs
{
    /// <summary>The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client. PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }

    /// <summary>Whether to send full FHIR resource to this Pub/Sub topic for Create and Update operation. Note that setting this to true does not guarantee that all resources will be sent in the format of full FHIR resource. When a resource change is too large or during heavy traffic, only the resource name will be sent. Clients should always check the "payloadType" label from a Pub/Sub message to determine whether it needs to fetch the full resource as a separate operation.</summary>
    [JsonPropertyName("sendFullResource")]
    public bool? SendFullResource { get; set; }

    /// <summary>Whether to send full FHIR resource to this Pub/Sub topic for deleting FHIR resource. Note that setting this to true does not guarantee that all previous resources will be sent in the format of full FHIR resource. When a resource change is too large or during heavy traffic, only the resource name will be sent. Clients should always check the "payloadType" label from a Pub/Sub message to determine whether it needs to fetch the full previous resource as a separate operation.</summary>
    [JsonPropertyName("sendPreviousResourceOnDelete")]
    public bool? SendPreviousResourceOnDelete { get; set; }
}

/// <summary>The configuration for exported BigQuery tables to be partitioned by FHIR resource's last updated time column.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestinationSchemaConfigLastUpdatedPartitionConfig
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>Type of partitioning. Possible values: ["PARTITION_TYPE_UNSPECIFIED", "HOUR", "DAY", "MONTH", "YEAR"].</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The configuration for the exported BigQuery schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestinationSchemaConfig
{
    /// <summary>The configuration for exported BigQuery tables to be partitioned by FHIR resource's last updated time column.</summary>
    [JsonPropertyName("lastUpdatedPartitionConfig")]
    public V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestinationSchemaConfigLastUpdatedPartitionConfig? LastUpdatedPartitionConfig { get; set; }

    /// <summary>The depth for all recursive structures in the output analytics schema. For example, concept in the CodeSystem resource is a recursive structure; when the depth is 2, the CodeSystem table will have a column called concept.concept but not concept.concept.concept. If not specified or set to 0, the server will use the default value 2. The maximum depth allowed is 5.</summary>
    [JsonPropertyName("recursiveStructureDepth")]
    public int RecursiveStructureDepth { get; set; }

    /// <summary>Specifies the output schema type.  * ANALYTICS: Analytics schema defined by the FHIR community.   See https://github.com/FHIR/sql-on-fhir/blob/master/sql-on-fhir.md.  * ANALYTICS_V2: Analytics V2, similar to schema defined by the FHIR community, with added support for extensions with one or more occurrences and contained resources in stringified JSON.  * LOSSLESS: A data-driven schema generated from the fields present in the FHIR data being exported, with no additional simplification. Default value: "ANALYTICS" Possible values: ["ANALYTICS", "ANALYTICS_V2", "LOSSLESS"].</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>The destination BigQuery structure that contains both the dataset location and corresponding schema config. The output is organized in one table per resource type. The server reuses the existing tables (if any) that are named after the resource types, e.g. "Patient", "Observation". When there is no existing table for a given resource type, the server attempts to create one. See the [streaming config reference](https://cloud.google.com/healthcare/docs/reference/rest/v1beta1/projects.locations.datasets.fhirStores#streamconfig) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestination
{
    /// <summary>BigQuery URI to a dataset, up to 2000 characters long, in the format bq://projectId.bqDatasetId.</summary>
    [JsonPropertyName("datasetUri")]
    public string DatasetUri { get; set; }

    /// <summary>The configuration for the exported BigQuery schema.</summary>
    [JsonPropertyName("schemaConfig")]
    public V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestinationSchemaConfig SchemaConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpecStreamConfigs
{
    /// <summary>The destination BigQuery structure that contains both the dataset location and corresponding schema config. The output is organized in one table per resource type. The server reuses the existing tables (if any) that are named after the resource types, e.g. "Patient", "Observation". When there is no existing table for a given resource type, the server attempts to create one. See the [streaming config reference](https://cloud.google.com/healthcare/docs/reference/rest/v1beta1/projects.locations.datasets.fhirStores#streamconfig) for more details.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1alpha1HealthcareFHIRStoreSpecStreamConfigsBigqueryDestination BigqueryDestination { get; set; }

    /// <summary>Supply a FHIR resource type (such as "Patient" or "Observation"). See https://www.hl7.org/fhir/valueset-resource-types.html for a list of all FHIR resource types. The server treats an empty list as an intent to stream all the supported resource types in this FHIR store.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreSpec
{
    /// <summary>Enable parsing of references within complex FHIR data types such as Extensions. If this value is set to ENABLED, then features like referential integrity and Bundle reference rewriting apply to all references. If this flag has not been specified the behavior of the FHIR store will not change, references in complex data types will not be parsed. New stores will have this value set to ENABLED by default after a notification period. Warning: turning on this flag causes processing existing resources to fail if they contain references to non-existent resources. Possible values: ["COMPLEX_DATA_TYPE_REFERENCE_PARSING_UNSPECIFIED", "DISABLED", "ENABLED"].</summary>
    [JsonPropertyName("complexDataTypeReferenceParsing")]
    public string? ComplexDataTypeReferenceParsing { get; set; }

    /// <summary>Immutable. Identifies the dataset addressed by this request. Must be in the format 'projects/{project}/locations/{location}/datasets/{dataset}'.</summary>
    [JsonPropertyName("dataset")]
    public string Dataset { get; set; }

    /// <summary>If true, overrides the default search behavior for this FHIR store to handling=strict which returns an error for unrecognized search parameters. If false, uses the FHIR specification default handling=lenient which ignores unrecognized search parameters. The handling can always be changed from the default on an individual API call by setting the HTTP header Prefer: handling=strict or Prefer: handling=lenient.</summary>
    [JsonPropertyName("defaultSearchHandlingStrict")]
    public bool? DefaultSearchHandlingStrict { get; set; }

    /// <summary>Immutable. Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The default value is false, meaning that the API will enforce referential integrity and fail the requests that will result in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check. Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if broken references exist.  ** Changing this property may recreate the FHIR store (removing all data) **.</summary>
    [JsonPropertyName("disableReferentialIntegrity")]
    public bool? DisableReferentialIntegrity { get; set; }

    /// <summary>Immutable. Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR store. If set to false, which is the default behavior, all write operations will cause historical versions to be recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set to true, no historical versions will be kept. The server will send back errors for attempts to read the historical versions.  ** Changing this property may recreate the FHIR store (removing all data) **.</summary>
    [JsonPropertyName("disableResourceVersioning")]
    public bool? DisableResourceVersioning { get; set; }

    /// <summary>Immutable. Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which clients may not want to allow. If set to false, history bundles within an import will fail with an error.  ** Changing this property may recreate the FHIR store (removing all data) **  ** This property can be changed manually in the Google Cloud Healthcare admin console without recreating the FHIR store **.</summary>
    [JsonPropertyName("enableHistoryImport")]
    public bool? EnableHistoryImport { get; set; }

    /// <summary>Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.</summary>
    [JsonPropertyName("enableUpdateCreate")]
    public bool? EnableUpdateCreate { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1alpha1HealthcareFHIRStoreSpecNotificationConfig? NotificationConfig { get; set; }

    /// <summary>A list of notifcation configs that configure the notification for every resource mutation in this FHIR store.</summary>
    [JsonPropertyName("notificationConfigs")]
    public IList<V1alpha1HealthcareFHIRStoreSpecNotificationConfigs>? NotificationConfigs { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A list of streaming configs that configure the destinations of streaming export for every resource mutation in this FHIR store. Each store is allowed to have up to 10 streaming configs. After a new config is added, the next resource mutation is streamed to the new location in addition to the existing ones. When a location is removed from the list, the server stops streaming to that location. Before adding a new config, you must add the required bigquery.dataEditor role to your project's Cloud Healthcare Service Agent service account. Some lag (typically on the order of dozens of seconds) is expected before the results show up in the streaming destination.</summary>
    [JsonPropertyName("streamConfigs")]
    public IList<V1alpha1HealthcareFHIRStoreSpecStreamConfigs>? StreamConfigs { get; set; }

    /// <summary>Immutable. The FHIR specification version. Default value: "STU3" Possible values: ["DSTU2", "STU3", "R4"].</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareFHIRStoreStatusConditions
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
public partial class V1alpha1HealthcareFHIRStoreStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HealthcareFHIRStoreStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The fully qualified name of this dataset.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthcareFHIRStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HealthcareFHIRStoreSpec>, IStatus<V1alpha1HealthcareFHIRStoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthcareFHIRStore";
    public const string KubeGroup = "healthcare.cnrm.cloud.google.com";
    public const string KubePluralName = "healthcarefhirstores";
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
    public V1alpha1HealthcareFHIRStoreSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1HealthcareFHIRStoreStatus? Status { get; set; }
}