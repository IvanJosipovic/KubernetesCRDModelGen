using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.com;
/// <summary>Storage version of v1api20220301.ServerFarm Generator information: - Generated from: /web/resource-manager/Microsoft.Web/stable/2022-03-01/AppServicePlans.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301storageServerFarmList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301storageServerFarm>
{
    public const string KubeApiVersion = "v1api20220301storage";
    public const string KubeKind = "ServerFarmList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
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
    public IList<V1api20220301storageServerFarm> Items { get; set; }
}

/// <summary>Storage version of v1api20220301.ExtendedLocation Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID of the App Service Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecHostingEnvironmentProfileReference
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

/// <summary>Storage version of v1api20220301.HostingEnvironmentProfile Specification for an App Service Environment to use for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecHostingEnvironmentProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageServerFarmSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecKubeEnvironmentProfileReference
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

/// <summary>Storage version of v1api20220301.KubeEnvironmentProfile Specification for a Kubernetes Environment to use for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecKubeEnvironmentProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageServerFarmSpecKubeEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20220301.ServerFarmOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301storageServerFarmSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301storageServerFarmSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.Capability Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecSkuCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20220301.SkuCapacity Description of the App Service plan scale options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecSkuSkuCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Storage version of v1api20220301.SkuDescription Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20220301storageServerFarmSpecSkuCapabilities>? Capabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Storage version of v1api20220301.SkuCapacity Description of the App Service plan scale options.</summary>
    [JsonPropertyName("skuCapacity")]
    public V1api20220301storageServerFarmSpecSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.ServerFarm_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageServerFarmSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary>Storage version of v1api20220301.HostingEnvironmentProfile Specification for an App Service Environment to use for this resource.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301storageServerFarmSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Storage version of v1api20220301.KubeEnvironmentProfile Specification for a Kubernetes Environment to use for this resource.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V1api20220301storageServerFarmSpecKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary>Storage version of v1api20220301.ServerFarmOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301storageServerFarmSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220301storageServerFarmSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>Storage version of v1api20220301.SkuDescription Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageServerFarmSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusConditions
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

/// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220301.HostingEnvironmentProfile_STATUS Specification for an App Service Environment to use for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusHostingEnvironmentProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220301.KubeEnvironmentProfile_STATUS Specification for a Kubernetes Environment to use for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusKubeEnvironmentProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220301.Capability_STATUS Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusSkuCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20220301.SkuCapacity_STATUS Description of the App Service plan scale options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusSkuSkuCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Storage version of v1api20220301.SkuDescription_STATUS Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20220301storageServerFarmStatusSkuCapabilities>? Capabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Storage version of v1api20220301.SkuCapacity_STATUS Description of the App Service plan scale options.</summary>
    [JsonPropertyName("skuCapacity")]
    public V1api20220301storageServerFarmStatusSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.ServerFarm_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageServerFarmStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301storageServerFarmStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageServerFarmStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("geoRegion")]
    public string? GeoRegion { get; set; }

    /// <summary>Storage version of v1api20220301.HostingEnvironmentProfile_STATUS Specification for an App Service Environment to use for this resource.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301storageServerFarmStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Storage version of v1api20220301.KubeEnvironmentProfile_STATUS Specification for a Kubernetes Environment to use for this resource.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V1api20220301storageServerFarmStatusKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximumNumberOfWorkers")]
    public int? MaximumNumberOfWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numberOfSites")]
    public int? NumberOfSites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Storage version of v1api20220301.SkuDescription_STATUS Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageServerFarmStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Storage version of v1api20220301.ServerFarm Generator information: - Generated from: /web/resource-manager/Microsoft.Web/stable/2022-03-01/AppServicePlans.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301storageServerFarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301storageServerFarmSpec>, IStatus<V1api20220301storageServerFarmStatus>
{
    public const string KubeApiVersion = "v1api20220301storage";
    public const string KubeKind = "ServerFarm";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220301.ServerFarm_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220301storageServerFarmSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220301.ServerFarm_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageServerFarmStatus? Status { get; set; }
}