using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/Profile resource</summary>
public partial class V1api20230501storageSecretSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230501.AzureFirstPartyManagedCertificateParameters</summary>
public partial class V1api20230501storageSecretSpecParametersAzureFirstPartyManagedCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20230501storageSecretSpecParametersCustomerCertificateSecretSourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
public partial class V1api20230501storageSecretSpecParametersCustomerCertificateSecretSource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageSecretSpecParametersCustomerCertificateSecretSourceReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.CustomerCertificateParameters</summary>
public partial class V1api20230501storageSecretSpecParametersCustomerCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("secretSource")]
    public V1api20230501storageSecretSpecParametersCustomerCertificateSecretSource? SecretSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useLatestVersion")]
    public bool? UseLatestVersion { get; set; }
}

/// <summary>Storage version of v1api20230501.ManagedCertificateParameters</summary>
public partial class V1api20230501storageSecretSpecParametersManagedCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20230501storageSecretSpecParametersUrlSigningKeySecretSourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
public partial class V1api20230501storageSecretSpecParametersUrlSigningKeySecretSource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageSecretSpecParametersUrlSigningKeySecretSourceReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningKeyParameters</summary>
public partial class V1api20230501storageSecretSpecParametersUrlSigningKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("secretSource")]
    public V1api20230501storageSecretSpecParametersUrlSigningKeySecretSource? SecretSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.SecretParameters</summary>
public partial class V1api20230501storageSecretSpecParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.AzureFirstPartyManagedCertificateParameters</summary>
    [JsonPropertyName("azureFirstPartyManagedCertificate")]
    public V1api20230501storageSecretSpecParametersAzureFirstPartyManagedCertificate? AzureFirstPartyManagedCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.CustomerCertificateParameters</summary>
    [JsonPropertyName("customerCertificate")]
    public V1api20230501storageSecretSpecParametersCustomerCertificate? CustomerCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.ManagedCertificateParameters</summary>
    [JsonPropertyName("managedCertificate")]
    public V1api20230501storageSecretSpecParametersManagedCertificate? ManagedCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningKeyParameters</summary>
    [JsonPropertyName("urlSigningKey")]
    public V1api20230501storageSecretSpecParametersUrlSigningKey? UrlSigningKey { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_Secret_Spec</summary>
public partial class V1api20230501storageSecretSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/Profile resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230501storageSecretSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230501.SecretParameters</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageSecretSpecParameters? Parameters { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20230501storageSecretStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
public partial class V1api20230501storageSecretStatusParametersAzureFirstPartyManagedCertificateSecretSource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.AzureFirstPartyManagedCertificateParameters_STATUS</summary>
public partial class V1api20230501storageSecretStatusParametersAzureFirstPartyManagedCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("secretSource")]
    public V1api20230501storageSecretStatusParametersAzureFirstPartyManagedCertificateSecretSource? SecretSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
public partial class V1api20230501storageSecretStatusParametersCustomerCertificateSecretSource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.CustomerCertificateParameters_STATUS</summary>
public partial class V1api20230501storageSecretStatusParametersCustomerCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("secretSource")]
    public V1api20230501storageSecretStatusParametersCustomerCertificateSecretSource? SecretSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useLatestVersion")]
    public bool? UseLatestVersion { get; set; }
}

/// <summary>Storage version of v1api20230501.ManagedCertificateParameters_STATUS</summary>
public partial class V1api20230501storageSecretStatusParametersManagedCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
public partial class V1api20230501storageSecretStatusParametersUrlSigningKeySecretSource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningKeyParameters_STATUS</summary>
public partial class V1api20230501storageSecretStatusParametersUrlSigningKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("secretSource")]
    public V1api20230501storageSecretStatusParametersUrlSigningKeySecretSource? SecretSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.SecretParameters_STATUS</summary>
public partial class V1api20230501storageSecretStatusParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.AzureFirstPartyManagedCertificateParameters_STATUS</summary>
    [JsonPropertyName("azureFirstPartyManagedCertificate")]
    public V1api20230501storageSecretStatusParametersAzureFirstPartyManagedCertificate? AzureFirstPartyManagedCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.CustomerCertificateParameters_STATUS</summary>
    [JsonPropertyName("customerCertificate")]
    public V1api20230501storageSecretStatusParametersCustomerCertificate? CustomerCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.ManagedCertificateParameters_STATUS</summary>
    [JsonPropertyName("managedCertificate")]
    public V1api20230501storageSecretStatusParametersManagedCertificate? ManagedCertificate { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningKeyParameters_STATUS</summary>
    [JsonPropertyName("urlSigningKey")]
    public V1api20230501storageSecretStatusParametersUrlSigningKey? UrlSigningKey { get; set; }
}

/// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
public partial class V1api20230501storageSecretStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_Secret_STATUS</summary>
public partial class V1api20230501storageSecretStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageSecretStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.SecretParameters_STATUS</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageSecretStatusParameters? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501storageSecretStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20230501.Secret Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</summary>
public partial class V1api20230501storageSecret : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageSecretSpec>, IStatus<V1api20230501storageSecretStatus>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "Secret";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "secrets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_Secret_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageSecretSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_Secret_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230501storageSecretStatus? Status { get; set; }
}