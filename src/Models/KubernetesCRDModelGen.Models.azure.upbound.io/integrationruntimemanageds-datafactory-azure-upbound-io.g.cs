using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>Administrator login password for the SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderCatalogInfoAdministratorPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrator login password for the SQL Server.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderCatalogInfoAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, Standard, Premium and PremiumRS. Defaults to Basic.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderCustomSetupScriptSasTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }

    /// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderCustomSetupScriptSasTokenSecretRef SasTokenSecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegration
{
    /// <summary>Name of the subnet to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecForProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public IList<V1beta1IntegrationRuntimeManagedSpecForProviderCatalogInfo>? CatalogInfo { get; set; }

    /// <summary>The name of the credential to use for the Managed Integration Runtime.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public IList<V1beta1IntegrationRuntimeManagedSpecForProviderCustomSetupScript>? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1IntegrationRuntimeManagedSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Managed Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Managed Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Managed Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public IList<V1beta1IntegrationRuntimeManagedSpecForProviderVnetIntegration>? VnetIntegration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, Standard, Premium and PremiumRS. Defaults to Basic.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegration
{
    /// <summary>Name of the subnet to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecInitProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public IList<V1beta1IntegrationRuntimeManagedSpecInitProviderCatalogInfo>? CatalogInfo { get; set; }

    /// <summary>The name of the credential to use for the Managed Integration Runtime.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public IList<V1beta1IntegrationRuntimeManagedSpecInitProviderCustomSetupScript>? CustomSetupScript { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Managed Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Managed Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Managed Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public IList<V1beta1IntegrationRuntimeManagedSpecInitProviderVnetIntegration>? VnetIntegration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IntegrationRuntimeManagedSpec defines the desired state of IntegrationRuntimeManaged</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IntegrationRuntimeManagedSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IntegrationRuntimeManagedSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IntegrationRuntimeManagedSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IntegrationRuntimeManagedSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IntegrationRuntimeManagedSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatusAtProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, Standard, Premium and PremiumRS. Defaults to Basic.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatusAtProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatusAtProviderVnetIntegration
{
    /// <summary>Name of the subnet to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Managed Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatusAtProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public IList<V1beta1IntegrationRuntimeManagedStatusAtProviderCatalogInfo>? CatalogInfo { get; set; }

    /// <summary>The name of the credential to use for the Managed Integration Runtime.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public IList<V1beta1IntegrationRuntimeManagedStatusAtProviderCustomSetupScript>? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Managed Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>The ID of the Data Factory Integration Managed Runtime.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Managed Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Managed Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public IList<V1beta1IntegrationRuntimeManagedStatusAtProviderVnetIntegration>? VnetIntegration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatusConditions
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

/// <summary>IntegrationRuntimeManagedStatus defines the observed state of IntegrationRuntimeManaged.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeManagedStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IntegrationRuntimeManagedStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IntegrationRuntimeManagedStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IntegrationRuntimeManaged is the Schema for the IntegrationRuntimeManageds API. Manages an Azure Data Factory Managed Integration Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IntegrationRuntimeManaged : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IntegrationRuntimeManagedSpec>, IStatus<V1beta1IntegrationRuntimeManagedStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IntegrationRuntimeManaged";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "integrationruntimemanageds";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IntegrationRuntimeManagedSpec defines the desired state of IntegrationRuntimeManaged</summary>
    [JsonPropertyName("spec")]
    public V1beta1IntegrationRuntimeManagedSpec Spec { get; set; }

    /// <summary>IntegrationRuntimeManagedStatus defines the observed state of IntegrationRuntimeManaged.</summary>
    [JsonPropertyName("status")]
    public V1beta1IntegrationRuntimeManagedStatus? Status { get; set; }
}