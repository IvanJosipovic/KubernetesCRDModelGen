using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.search.azure.m.upbound.io;
/// <summary>Service is the Schema for the Services API. Manages a Search Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Service>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "search.azure.m.upbound.io";
    public const string KubePluralName = "services";
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
    public IList<V1beta1Service> Items { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderIdentity
{
    /// <summary>Specifies the list of User Assigned Managed Service Identity IDs which should be assigned to this Search Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Search Service. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProvider
{
    /// <summary>Specifies a list of inbound IPv4 or CIDRs that are allowed to access the Search Service. If the incoming IP request is from an IP address which is not included in the allowed_ips it will be blocked by the Search Services firewall.</summary>
    [JsonPropertyName("allowedIps")]
    public IList<string>? AllowedIps { get; set; }

    /// <summary>Specifies the response that the Search Service should return for requests that fail authentication. Possible values include http401WithBearerChallenge or http403.</summary>
    [JsonPropertyName("authenticationFailureMode")]
    public string? AuthenticationFailureMode { get; set; }

    /// <summary>Specifies whether the Search Service should enforce that non-customer resources are encrypted. Defaults to false.</summary>
    [JsonPropertyName("customerManagedKeyEnforcementEnabled")]
    public bool? CustomerManagedKeyEnforcementEnabled { get; set; }

    /// <summary>Specifies the Hosting Mode, which allows for High Density partitions (that allow for up to 1000 indexes) should be supported. Possible values are highDensity or default. Defaults to default. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("hostingMode")]
    public string? HostingMode { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ServiceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies whether the Search Service allows authenticating using API Keys? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>The Azure Region where the Search Service should exist. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to allow trusted Azure services to access a network restricted Container Registry? Possible values are None and AzureServices. Defaults to None.</summary>
    [JsonPropertyName("networkRuleBypassOption")]
    public string? NetworkRuleBypassOption { get; set; }

    /// <summary>Specifies the number of partitions which should be created. This field cannot be set when using a free sku (see the Microsoft documentation). Possible values include 1, 2, 3, 4, 6, or 12. Defaults to 1.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>Specifies whether Public Network Access is allowed for this resource. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies the number of Replica's which should be created for this Search Service. This field cannot be set when using a free sku (see the Microsoft documentation).</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>The name of the Resource Group where the Search Service should exist. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ServiceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ServiceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the Semantic Search SKU which should be used for this Search Service. Possible values include free and standard.</summary>
    [JsonPropertyName("semanticSearchSku")]
    public string? SemanticSearchSku { get; set; }

    /// <summary>The SKU which should be used for this Search Service. Possible values include basic, free, standard, standard2, standard3, storage_optimized_l1 and storage_optimized_l2. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies a mapping of tags which should be assigned to this Search Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderIdentity
{
    /// <summary>Specifies the list of User Assigned Managed Service Identity IDs which should be assigned to this Search Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Search Service. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProvider
{
    /// <summary>Specifies a list of inbound IPv4 or CIDRs that are allowed to access the Search Service. If the incoming IP request is from an IP address which is not included in the allowed_ips it will be blocked by the Search Services firewall.</summary>
    [JsonPropertyName("allowedIps")]
    public IList<string>? AllowedIps { get; set; }

    /// <summary>Specifies the response that the Search Service should return for requests that fail authentication. Possible values include http401WithBearerChallenge or http403.</summary>
    [JsonPropertyName("authenticationFailureMode")]
    public string? AuthenticationFailureMode { get; set; }

    /// <summary>Specifies whether the Search Service should enforce that non-customer resources are encrypted. Defaults to false.</summary>
    [JsonPropertyName("customerManagedKeyEnforcementEnabled")]
    public bool? CustomerManagedKeyEnforcementEnabled { get; set; }

    /// <summary>Specifies the Hosting Mode, which allows for High Density partitions (that allow for up to 1000 indexes) should be supported. Possible values are highDensity or default. Defaults to default. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("hostingMode")]
    public string? HostingMode { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ServiceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies whether the Search Service allows authenticating using API Keys? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>The Azure Region where the Search Service should exist. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to allow trusted Azure services to access a network restricted Container Registry? Possible values are None and AzureServices. Defaults to None.</summary>
    [JsonPropertyName("networkRuleBypassOption")]
    public string? NetworkRuleBypassOption { get; set; }

    /// <summary>Specifies the number of partitions which should be created. This field cannot be set when using a free sku (see the Microsoft documentation). Possible values include 1, 2, 3, 4, 6, or 12. Defaults to 1.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>Specifies whether Public Network Access is allowed for this resource. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies the number of Replica's which should be created for this Search Service. This field cannot be set when using a free sku (see the Microsoft documentation).</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Specifies the Semantic Search SKU which should be used for this Search Service. Possible values include free and standard.</summary>
    [JsonPropertyName("semanticSearchSku")]
    public string? SemanticSearchSku { get; set; }

    /// <summary>The SKU which should be used for this Search Service. Possible values include basic, free, standard, standard2, standard3, storage_optimized_l1 and storage_optimized_l2. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies a mapping of tags which should be assigned to this Search Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderIdentity
{
    /// <summary>Specifies the list of User Assigned Managed Service Identity IDs which should be assigned to this Search Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Search Service. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderQueryKeys
{
    /// <summary>The value of this Query Key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The name of this Query Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProvider
{
    /// <summary>Specifies a list of inbound IPv4 or CIDRs that are allowed to access the Search Service. If the incoming IP request is from an IP address which is not included in the allowed_ips it will be blocked by the Search Services firewall.</summary>
    [JsonPropertyName("allowedIps")]
    public IList<string>? AllowedIps { get; set; }

    /// <summary>Specifies the response that the Search Service should return for requests that fail authentication. Possible values include http401WithBearerChallenge or http403.</summary>
    [JsonPropertyName("authenticationFailureMode")]
    public string? AuthenticationFailureMode { get; set; }

    /// <summary>Describes whether the search service is compliant or not with respect to having non-customer encrypted resources. If a service has more than one non-customer encrypted resource and Enforcement is enabled then the service will be marked as NonCompliant. If all the resources are customer encrypted, then the service will be marked as Compliant.</summary>
    [JsonPropertyName("customerManagedKeyEncryptionComplianceStatus")]
    public string? CustomerManagedKeyEncryptionComplianceStatus { get; set; }

    /// <summary>Specifies whether the Search Service should enforce that non-customer resources are encrypted. Defaults to false.</summary>
    [JsonPropertyName("customerManagedKeyEnforcementEnabled")]
    public bool? CustomerManagedKeyEnforcementEnabled { get; set; }

    /// <summary>Specifies the Hosting Mode, which allows for High Density partitions (that allow for up to 1000 indexes) should be supported. Possible values are highDensity or default. Defaults to default. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("hostingMode")]
    public string? HostingMode { get; set; }

    /// <summary>The ID of the Search Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ServiceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies whether the Search Service allows authenticating using API Keys? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>The Azure Region where the Search Service should exist. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to allow trusted Azure services to access a network restricted Container Registry? Possible values are None and AzureServices. Defaults to None.</summary>
    [JsonPropertyName("networkRuleBypassOption")]
    public string? NetworkRuleBypassOption { get; set; }

    /// <summary>Specifies the number of partitions which should be created. This field cannot be set when using a free sku (see the Microsoft documentation). Possible values include 1, 2, 3, 4, 6, or 12. Defaults to 1.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>Specifies whether Public Network Access is allowed for this resource. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A query_keys block as defined below.</summary>
    [JsonPropertyName("queryKeys")]
    public IList<V1beta1ServiceStatusAtProviderQueryKeys>? QueryKeys { get; set; }

    /// <summary>Specifies the number of Replica's which should be created for this Search Service. This field cannot be set when using a free sku (see the Microsoft documentation).</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>The name of the Resource Group where the Search Service should exist. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the Semantic Search SKU which should be used for this Search Service. Possible values include free and standard.</summary>
    [JsonPropertyName("semanticSearchSku")]
    public string? SemanticSearchSku { get; set; }

    /// <summary>The SKU which should be used for this Search Service. Possible values include basic, free, standard, standard2, standard3, storage_optimized_l1 and storage_optimized_l2. Changing this forces a new Search Service to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies a mapping of tags which should be assigned to this Search Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. Manages a Search Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceSpec>, IStatus<V1beta1ServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Service";
    public const string KubeGroup = "search.azure.m.upbound.io";
    public const string KubePluralName = "services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceStatus? Status { get; set; }
}