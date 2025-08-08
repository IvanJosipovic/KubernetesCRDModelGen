using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.m.upbound.io;
/// <summary>Administrator login password for the SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderCatalogInfoAdministratorPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrator login password for the SQL Server.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderCatalogInfoAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScriptSasTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }

    /// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScriptSasTokenSecretRef? SasTokenSecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The password for the target device.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The password for the target device.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKeyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The license used for the Component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentLicenseSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>The license used for the Component.</summary>
    [JsonPropertyName("licenseSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponentLicenseSecretRef? LicenseSecretRef { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecForProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecForProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>Administrator login password for the SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfoAdministratorPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Administrator login password for the SQL Server.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfoAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScriptSasTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }

    /// <summary>A container SAS token that gives access to the files. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScriptSasTokenSecretRef SasTokenSecretRef { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The password for the target device.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The password for the target device.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKeyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>The license used for the Component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentLicenseSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>The license used for the Component.</summary>
    [JsonPropertyName("licenseSecretRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponentLicenseSecretRef? LicenseSecretRef { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelector
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
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegrationSubnetNameSelector? SubnetNameSelector { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecInitProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The type of the license that is used. Valid values are LicenseIncluded and BasePrice. Defaults to LicenseIncluded.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the maximum parallel executions per node. Defaults to 1. Max is 1.</summary>
    [JsonPropertyName("maxParallelExecutionsPerNode")]
    public double? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta1IntegrationRuntimeAzureSSISSpecInitProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpecProviderConfigRef
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
public partial class V1beta1IntegrationRuntimeAzureSSISSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>IntegrationRuntimeAzureSSISSpec defines the desired state of IntegrationRuntimeAzureSSIS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IntegrationRuntimeAzureSSISSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IntegrationRuntimeAzureSSISSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IntegrationRuntimeAzureSSISSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A catalog_info block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCatalogInfo
{
    /// <summary>Administrator login name for the SQL Server.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The dual standby Azure-SSIS Integration Runtime pair with SSISDB failover.</summary>
    [JsonPropertyName("dualStandbyPairName")]
    public string? DualStandbyPairName { get; set; }

    /// <summary>The name of SQL elastic pool where the database will be created for the SSIS catalog. Mutually exclusive with pricing_tier.</summary>
    [JsonPropertyName("elasticPoolName")]
    public string? ElasticPoolName { get; set; }

    /// <summary>Pricing tier for the database that will be created for the SSIS catalog. Valid values are: Basic, S0, S1, S2, S3, S4, S6, S7, S9, S12, P1, P2, P4, P6, P11, P15, GP_S_Gen5_1, GP_S_Gen5_2, GP_S_Gen5_4, GP_S_Gen5_6, GP_S_Gen5_8, GP_S_Gen5_10, GP_S_Gen5_12, GP_S_Gen5_14, GP_S_Gen5_16, GP_S_Gen5_18, GP_S_Gen5_20, GP_S_Gen5_24, GP_S_Gen5_32, GP_S_Gen5_40, GP_Gen5_2, GP_Gen5_4, GP_Gen5_6, GP_Gen5_8, GP_Gen5_10, GP_Gen5_12, GP_Gen5_14, GP_Gen5_16, GP_Gen5_18, GP_Gen5_20, GP_Gen5_24, GP_Gen5_32, GP_Gen5_40, GP_Gen5_80, BC_Gen5_2, BC_Gen5_4, BC_Gen5_6, BC_Gen5_8, BC_Gen5_10, BC_Gen5_12, BC_Gen5_14, BC_Gen5_16, BC_Gen5_18, BC_Gen5_20, BC_Gen5_24, BC_Gen5_32, BC_Gen5_40, BC_Gen5_80, HS_Gen5_2, HS_Gen5_4, HS_Gen5_6, HS_Gen5_8, HS_Gen5_10, HS_Gen5_12, HS_Gen5_14, HS_Gen5_16, HS_Gen5_18, HS_Gen5_20, HS_Gen5_24, HS_Gen5_32, HS_Gen5_40 and HS_Gen5_80. Mutually exclusive with elastic_pool_name.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>The endpoint of an Azure SQL Server that will be used to host the SSIS catalog.</summary>
    [JsonPropertyName("serverEndpoint")]
    public string? ServerEndpoint { get; set; }
}

/// <summary>One copy_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCopyComputeScale
{
    /// <summary>Specifies the data integration unit number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256.</summary>
    [JsonPropertyName("dataIntegrationUnit")]
    public double? DataIntegrationUnit { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A custom_setup_script block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCustomSetupScript
{
    /// <summary>The blob endpoint for the container which contains a custom setup script that will be run on every node on startup. See https://docs.microsoft.com/azure/data-factory/how-to-configure-azure-ssis-ir-custom-setup for more information.</summary>
    [JsonPropertyName("blobContainerUri")]
    public string? BlobContainerUri { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKeyKeyVaultPassword
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKey
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKeyKeyVaultPassword? KeyVaultPassword { get; set; }

    /// <summary>The target computer or domain name.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The username for the target device.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A key_vault_secret_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponentKeyVaultLicense
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Specifies the secret version in Azure Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponent
{
    /// <summary>A key_vault_secret_reference block as defined below.</summary>
    [JsonPropertyName("keyVaultLicense")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponentKeyVaultLicense? KeyVaultLicense { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An express_custom_setup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetup
{
    /// <summary>One or more command_key blocks as defined below.</summary>
    [JsonPropertyName("commandKey")]
    public IList<V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupCommandKey>? CommandKey { get; set; }

    /// <summary>One or more component blocks as defined below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetupComponent>? Component { get; set; }

    /// <summary>The Environment Variables for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The version of Azure Powershell installed for the Azure-SSIS Integration Runtime.</summary>
    [JsonPropertyName("powershellVersion")]
    public string? PowershellVersion { get; set; }
}

/// <summary>A express_vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressVnetIntegration
{
    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderPackageStore
{
    /// <summary>Name of the Linked Service to associate with the packages.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Name of the package store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One pipeline_external_compute_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderPipelineExternalComputeScale
{
    /// <summary>Specifies the number of the external nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfExternalNodes")]
    public double? NumberOfExternalNodes { get; set; }

    /// <summary>Specifies the number of the pipeline nodes, which should be greater than 0 and less than 11.</summary>
    [JsonPropertyName("numberOfPipelineNodes")]
    public double? NumberOfPipelineNodes { get; set; }

    /// <summary>Specifies the time to live (in minutes) setting of integration runtime which will execute copy activity. Possible values are at least 5.</summary>
    [JsonPropertyName("timeToLive")]
    public double? TimeToLive { get; set; }
}

/// <summary>A proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderProxy
{
    /// <summary>The path in the data store to be used when moving data between Self-Hosted and Azure-SSIS Integration Runtimes.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name of Self Hosted Integration Runtime as a proxy.</summary>
    [JsonPropertyName("selfHostedIntegrationRuntimeName")]
    public string? SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>Name of Azure Blob Storage linked service to reference the staging data store to be used when moving data between self-hosted and Azure-SSIS integration runtimes.</summary>
    [JsonPropertyName("stagingStorageLinkedServiceName")]
    public string? StagingStorageLinkedServiceName { get; set; }
}

/// <summary>A vnet_integration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProviderVnetIntegration
{
    /// <summary>Static public IP addresses for the Azure-SSIS Integration Runtime. The size must be 2.</summary>
    [JsonPropertyName("publicIps")]
    public IList<string>? PublicIps { get; set; }

    /// <summary>id of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Name of the subnet to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>ID of the virtual network to which the nodes of the Azure-SSIS Integration Runtime will be added.</summary>
    [JsonPropertyName("vnetId")]
    public string? VnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusAtProvider
{
    /// <summary>A catalog_info block as defined below.</summary>
    [JsonPropertyName("catalogInfo")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCatalogInfo? CatalogInfo { get; set; }

    /// <summary>One copy_compute_scale block as defined below.</summary>
    [JsonPropertyName("copyComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCopyComputeScale? CopyComputeScale { get; set; }

    /// <summary>The name of a Data Factory Credential that the SSIS integration will use to access data sources. For example, azurerm_data_factory_credential_user_managed_identity</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>A custom_setup_script block as defined below.</summary>
    [JsonPropertyName("customSetupScript")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderCustomSetupScript? CustomSetupScript { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Integration runtime description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure-SSIS Integration Runtime edition. Valid values are Standard and Enterprise. Defaults to Standard.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>An express_custom_setup block as defined below.</summary>
    [JsonPropertyName("expressCustomSetup")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressCustomSetup? ExpressCustomSetup { get; set; }

    /// <summary>A express_vnet_integration block as defined below.</summary>
    [JsonPropertyName("expressVnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderExpressVnetIntegration? ExpressVnetIntegration { get; set; }

    /// <summary>The ID of the Data Factory Azure-SSIS Integration Runtime.</summary>
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

    /// <summary>The size of the nodes on which the Azure-SSIS Integration Runtime runs. Valid values are: Standard_D2_v3, Standard_D4_v3, Standard_D8_v3, Standard_D16_v3, Standard_D32_v3, Standard_D64_v3, Standard_E2_v3, Standard_E4_v3, Standard_E8_v3, Standard_E16_v3, Standard_E32_v3, Standard_E64_v3, Standard_D1_v2, Standard_D2_v2, Standard_D3_v2, Standard_D4_v2, Standard_A4_v2 and Standard_A8_v2</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>Number of nodes for the Azure-SSIS Integration Runtime. Max is 10. Defaults to 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>One or more package_store block as defined below.</summary>
    [JsonPropertyName("packageStore")]
    public IList<V1beta1IntegrationRuntimeAzureSSISStatusAtProviderPackageStore>? PackageStore { get; set; }

    /// <summary>One pipeline_external_compute_scale block as defined below.</summary>
    [JsonPropertyName("pipelineExternalComputeScale")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderPipelineExternalComputeScale? PipelineExternalComputeScale { get; set; }

    /// <summary>A proxy block as defined below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderProxy? Proxy { get; set; }

    /// <summary>A vnet_integration block as defined below.</summary>
    [JsonPropertyName("vnetIntegration")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProviderVnetIntegration? VnetIntegration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatusConditions
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

/// <summary>IntegrationRuntimeAzureSSISStatus defines the observed state of IntegrationRuntimeAzureSSIS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntegrationRuntimeAzureSSISStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IntegrationRuntimeAzureSSISStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IntegrationRuntimeAzureSSISStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IntegrationRuntimeAzureSSIS is the Schema for the IntegrationRuntimeAzureSSISs API. Manages a Data Factory Azure-SSIS Integration Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IntegrationRuntimeAzureSSIS : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IntegrationRuntimeAzureSSISSpec>, IStatus<V1beta1IntegrationRuntimeAzureSSISStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IntegrationRuntimeAzureSSIS";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "integrationruntimeazuressis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IntegrationRuntimeAzureSSISSpec defines the desired state of IntegrationRuntimeAzureSSIS</summary>
    [JsonPropertyName("spec")]
    public V1beta1IntegrationRuntimeAzureSSISSpec Spec { get; set; }

    /// <summary>IntegrationRuntimeAzureSSISStatus defines the observed state of IntegrationRuntimeAzureSSIS.</summary>
    [JsonPropertyName("status")]
    public V1beta1IntegrationRuntimeAzureSSISStatus? Status { get; set; }
}

/// <summary>IntegrationRuntimeAzureSSIS is the Schema for the IntegrationRuntimeAzureSSISs API. Manages a Data Factory Azure-SSIS Integration Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IntegrationRuntimeAzureSSISList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IntegrationRuntimeAzureSSIS>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IntegrationRuntimeAzureSSISList";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "integrationruntimeazuressis";
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
    public IList<V1beta1IntegrationRuntimeAzureSSIS> Items { get; set; }
}