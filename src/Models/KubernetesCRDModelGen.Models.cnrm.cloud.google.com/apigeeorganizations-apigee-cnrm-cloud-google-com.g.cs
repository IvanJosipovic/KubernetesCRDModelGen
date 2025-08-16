using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>ApigeeOrganization is the Schema for the ApigeeOrganization API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeOrganizationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApigeeOrganization>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeOrganizationList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ApigeeOrganization> Items { get; set; }
}

/// <summary>Configuration for the Advanced API Ops add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Advanced API Ops add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the Monetization add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Addon configurations of the Apigee organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecAddonsConfig
{
    /// <summary>Configuration for the Advanced API Ops add-on.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}

/// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See [Getting started with the Service Networking API](https://cloud.google.com/service-infrastructure/docs/service-networking/getting-started). Valid only when [RuntimeType](#RuntimeType) is set to `CLOUD`. The value must be set before the creation of a runtime instance and can be updated only when there are no runtime instances. For example: `default`. Apigee also supports shared VPC (that is, the host network project is not the same as the one that is peering with Apigee). See [Shared VPC overview](https://cloud.google.com/vpc/docs/shared-vpc). To use a shared VPC network, use the following format: `projects/{host-project-id}/{region}/networks/{network-name}`. For example: `projects/my-sharedvpc-host/global/networks/mynetwork` **Note:** Not supported for Apigee hybrid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecAuthorizedNetworkRef
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

/// <summary>Required. Name of the GCP project in which to associate the Apigee organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecProjectRef
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

/// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. If not specified or [RuntimeType](#RuntimeType) is `TRIAL`, a Google-Managed encryption key will be used. For example: "projects/foo/locations/us/keyRings/bar/cryptoKeys/baz". **Note:** Not supported for Apigee hybrid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpecRuntimeDatabaseEncryptionKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ApigeeOrganizationSpec defines the desired state of ApigeeOrganization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationSpec
{
    /// <summary>Addon configurations of the Apigee organization.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ApigeeOrganizationSpecAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Required. DEPRECATED: This field will eventually be deprecated and replaced with a differently-named field. Primary Google Cloud region for analytics data storage. For valid values, see [Create an Apigee organization](https://cloud.google.com/apigee/docs/api-platform/get-started/create-org).</summary>
    [JsonPropertyName("analyticsRegion")]
    public string AnalyticsRegion { get; set; }

    /// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See [Getting started with the Service Networking API](https://cloud.google.com/service-infrastructure/docs/service-networking/getting-started). Valid only when [RuntimeType](#RuntimeType) is set to `CLOUD`. The value must be set before the creation of a runtime instance and can be updated only when there are no runtime instances. For example: `default`. Apigee also supports shared VPC (that is, the host network project is not the same as the one that is peering with Apigee). See [Shared VPC overview](https://cloud.google.com/vpc/docs/shared-vpc). To use a shared VPC network, use the following format: `projects/{host-project-id}/{region}/networks/{network-name}`. For example: `projects/my-sharedvpc-host/global/networks/mynetwork` **Note:** Not supported for Apigee hybrid.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1ApigeeOrganizationSpecAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Description of the Apigee organization.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for the Apigee organization. Unused, but reserved for future use.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Name of the GCP project in which to associate the Apigee organization.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ApigeeOrganizationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Properties defined in the Apigee organization profile.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The ApigeeOrganization name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. If not specified or [RuntimeType](#RuntimeType) is `TRIAL`, a Google-Managed encryption key will be used. For example: "projects/foo/locations/us/keyRings/bar/cryptoKeys/baz". **Note:** Not supported for Apigee hybrid.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyRef")]
    public V1beta1ApigeeOrganizationSpecRuntimeDatabaseEncryptionKeyRef? RuntimeDatabaseEncryptionKeyRef { get; set; }

    /// <summary>Required. Runtime type of the Apigee organization based on the Apigee subscription purchased.</summary>
    [JsonPropertyName("runtimeType")]
    public string RuntimeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationStatusObservedState
{
}

/// <summary>ApigeeOrganizationStatus defines the config connector machine state of ApigeeOrganization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeOrganizationStatus
{
    /// <summary>Billing type of the Apigee organization. See [Apigee pricing](https://cloud.google.com/apigee/pricing).</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>Output only. Base64-encoded public certificate for the root CA of the Apigee organization. Valid only when [RuntimeType](#RuntimeType) is `CLOUD`.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
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

    /// <summary>A unique specifier for the ApigeeOrganization resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Output only. Time that the Apigee organization was last modified in milliseconds since epoch.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public long? LastModifiedAt { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ApigeeOrganizationStatusObservedState? ObservedState { get; set; }

    /// <summary>Output only. Project ID associated with the Apigee organization.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Output only. State of the organization. Values other than ACTIVE means the resource is not ready to use.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. DEPRECATED: This will eventually be replaced by BillingType. Subscription type of the Apigee organization. Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased). See [Apigee pricing](https://cloud.google.com/apigee/pricing/).</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

/// <summary>ApigeeOrganization is the Schema for the ApigeeOrganization API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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

    /// <summary>ApigeeOrganizationSpec defines the desired state of ApigeeOrganization</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApigeeOrganizationSpec Spec { get; set; }

    /// <summary>ApigeeOrganizationStatus defines the config connector machine state of ApigeeOrganization</summary>
    [JsonPropertyName("status")]
    public V1beta1ApigeeOrganizationStatus? Status { get; set; }
}