using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>Configuration for the Advanced API Ops add-on.</summary>
public partial class V1beta1ApigeeOrganizationSpecAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
public partial class V1beta1ApigeeOrganizationSpecAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Addon configurations of the Apigee organization.</summary>
public partial class V1beta1ApigeeOrganizationSpecAddonsConfig
{
    /// <summary>Configuration for the Advanced API Ops add-on.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1ApigeeOrganizationSpecAuthorizedNetworkRef
{
    /// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See (https://cloud.google.com/vpc/docs/shared-vpc). To use a shared VPC network, use the following format: `projects/{host-project-id}/{region}/networks/{network-name}`. For example: `projects/my-sharedvpc-host/global/networks/mynetwork` **Note:** Not supported for Apigee hybrid.  Allowed value: The Google Cloud resource name of a `ComputeNetwork` resource (format: `projects/{{project}}/global/networks/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
public partial class V1beta1ApigeeOrganizationSpecProjectRef
{
    /// <summary>Required. Name of the GCP project in which to associate the Apigee organization. Pass the information as a query parameter using the following structure in your request: projects/&lt;project&gt; Authorization requires the following IAM permission on the specified resource parent: apigee.organizations.create  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ApigeeOrganizationSpecRuntimeDatabaseEncryptionKeyRef
{
    /// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. Required when (#RuntimeType) is `TRIAL`, a Google-Managed encryption key will be used. For example: "projects/foo/locations/us/keyRings/bar/cryptoKeys/baz". **Note:** Not supported for Apigee hybrid.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ApigeeOrganizationSpec
{
    /// <summary>Addon configurations of the Apigee organization.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Immutable. Required. Primary GCP region for analytics data storage. For valid values, see (https://cloud.google.com/apigee/docs/api-platform/get-started/create-org).</summary>
    [JsonPropertyName("analyticsRegion")]
    public string AnalyticsRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1ApigeeOrganizationSpecAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Description of the Apigee organization.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for the Apigee organization.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ApigeeOrganizationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Properties defined in the Apigee organization profile.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyRef")]
    public V1beta1ApigeeOrganizationSpecRuntimeDatabaseEncryptionKeyRef? RuntimeDatabaseEncryptionKeyRef { get; set; }

    /// <summary>Immutable. Required. Runtime type of the Apigee organization based on the Apigee subscription purchased. Possible values: RUNTIME_TYPE_UNSPECIFIED, CLOUD, HYBRID</summary>
    [JsonPropertyName("runtimeType")]
    public string RuntimeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1ApigeeOrganizationStatusConditions
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
public partial class V1beta1ApigeeOrganizationStatus
{
    /// <summary>Output only. Billing type of the Apigee organization. See (https://cloud.google.com/apigee/pricing). Possible values: BILLING_TYPE_UNSPECIFIED, SUBSCRIPTION, EVALUATION</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>Output only. Base64-encoded public certificate for the root CA of the Apigee organization. Valid only when (#RuntimeType) is `CLOUD`.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApigeeOrganizationStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Time that the Apigee organization was created in milliseconds since epoch.</summary>
    [JsonPropertyName("createdAt")]
    public long? CreatedAt { get; set; }

    /// <summary>Output only. List of environments in the Apigee organization.</summary>
    [JsonPropertyName("environments")]
    public IList<string>? Environments { get; set; }

    /// <summary>Output only. Time that the Apigee organization is scheduled for deletion.</summary>
    [JsonPropertyName("expiresAt")]
    public long? ExpiresAt { get; set; }

    /// <summary>Output only. Time that the Apigee organization was last modified in milliseconds since epoch.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public long? LastModifiedAt { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Project ID associated with the Apigee organization.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Output only. State of the organization. Values other than ACTIVE means the resource is not ready to use. Possible values: SNAPSHOT_STATE_UNSPECIFIED, MISSING, OK_DOCSTORE, OK_SUBMITTED, OK_EXTERNAL, DELETED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. DEPRECATED: This will eventually be replaced by BillingType. Subscription type of the Apigee organization. Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased). See (https://cloud.google.com/apigee/pricing/). Possible values: SUBSCRIPTION_TYPE_UNSPECIFIED, PAID, TRIAL</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1ApigeeOrganization : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApigeeOrganizationSpec>, IStatus<V1beta1ApigeeOrganizationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeOrganization";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeorganizations";
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
    public V1beta1ApigeeOrganizationSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ApigeeOrganizationStatus? Status { get; set; }
}