using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>LinkedServiceAzureDatabricks is the Schema for the LinkedServiceAzureDatabrickss API. Manages a Linked Service (connection) between Azure Databricks and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceAzureDatabricksList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LinkedServiceAzureDatabricks>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceAzureDatabricksList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "linkedserviceazuredatabricks";
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
    public IList<V1beta1LinkedServiceAzureDatabricks> Items { get; set; }
}

/// <summary>Authenticate to ADB via an access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderAccessTokenSecretRef
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdRefPolicy
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
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdSelectorPolicy
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
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderInstancePool
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Identifier of the instance pool within the linked ADB instance.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>The max number of worker nodes. Set this value if you want to enable autoscaling between the min_number_of_workers and this value. Omit this value to use a fixed number of workers defined in the min_number_of_workers property.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>The minimum number of worker nodes. Defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores ADB access token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProviderNewClusterConfig
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Tags for the cluster resource.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Driver node type for the cluster.</summary>
    [JsonPropertyName("driverNodeType")]
    public string? DriverNodeType { get; set; }

    /// <summary>User defined initialization scripts for the cluster.</summary>
    [JsonPropertyName("initScripts")]
    public IList<string>? InitScripts { get; set; }

    /// <summary>Location to deliver Spark driver, worker, and event logs.</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Specifies the maximum number of worker nodes. It should be between 1 and 25000.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>Specifies the minimum number of worker nodes. It should be between 1 and 25000. It defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }

    /// <summary>Node type for the new cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>User-specified Spark configuration variables key-value pairs.</summary>
    [JsonPropertyName("sparkConfig")]
    public IDictionary<string, string>? SparkConfig { get; set; }

    /// <summary>User-specified Spark environment variables key-value pairs.</summary>
    [JsonPropertyName("sparkEnvironmentVariables")]
    public IDictionary<string, string>? SparkEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecForProvider
{
    /// <summary>Authenticate to ADB via an access token.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>The domain URL of the databricks instance.</summary>
    [JsonPropertyName("adbDomain")]
    public string? AdbDomain { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The cluster_id of an existing cluster within the linked ADB instance.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>Leverages an instance pool within the linked ADB instance as one instance_pool block defined below.</summary>
    [JsonPropertyName("instancePool")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecForProviderInstancePool>? InstancePool { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>Authenticate to ADB via Azure Key Vault Linked Service as defined in the key_vault_password block below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecForProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>Authenticate to ADB via managed service identity.</summary>
    [JsonPropertyName("msiWorkSpaceResourceId")]
    public string? MsiWorkSpaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
    [JsonPropertyName("msiWorkSpaceResourceIdRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdRef? MsiWorkSpaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
    [JsonPropertyName("msiWorkSpaceResourceIdSelector")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProviderMsiWorkSpaceResourceIdSelector? MsiWorkSpaceResourceIdSelector { get; set; }

    /// <summary>Creates new clusters within the linked ADB instance as defined in the new_cluster_config block below.</summary>
    [JsonPropertyName("newClusterConfig")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecForProviderNewClusterConfig>? NewClusterConfig { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderInstancePool
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Identifier of the instance pool within the linked ADB instance.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>The max number of worker nodes. Set this value if you want to enable autoscaling between the min_number_of_workers and this value. Omit this value to use a fixed number of workers defined in the min_number_of_workers property.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>The minimum number of worker nodes. Defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores ADB access token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProviderNewClusterConfig
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Tags for the cluster resource.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Driver node type for the cluster.</summary>
    [JsonPropertyName("driverNodeType")]
    public string? DriverNodeType { get; set; }

    /// <summary>User defined initialization scripts for the cluster.</summary>
    [JsonPropertyName("initScripts")]
    public IList<string>? InitScripts { get; set; }

    /// <summary>Location to deliver Spark driver, worker, and event logs.</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Specifies the maximum number of worker nodes. It should be between 1 and 25000.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>Specifies the minimum number of worker nodes. It should be between 1 and 25000. It defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }

    /// <summary>Node type for the new cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>User-specified Spark configuration variables key-value pairs.</summary>
    [JsonPropertyName("sparkConfig")]
    public IDictionary<string, string>? SparkConfig { get; set; }

    /// <summary>User-specified Spark environment variables key-value pairs.</summary>
    [JsonPropertyName("sparkEnvironmentVariables")]
    public IDictionary<string, string>? SparkEnvironmentVariables { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecInitProvider
{
    /// <summary>The domain URL of the databricks instance.</summary>
    [JsonPropertyName("adbDomain")]
    public string? AdbDomain { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The cluster_id of an existing cluster within the linked ADB instance.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>Leverages an instance pool within the linked ADB instance as one instance_pool block defined below.</summary>
    [JsonPropertyName("instancePool")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecInitProviderInstancePool>? InstancePool { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>Authenticate to ADB via Azure Key Vault Linked Service as defined in the key_vault_password block below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecInitProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>Authenticate to ADB via managed service identity.</summary>
    [JsonPropertyName("msiWorkSpaceResourceId")]
    public string? MsiWorkSpaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
    [JsonPropertyName("msiWorkSpaceResourceIdRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdRef? MsiWorkSpaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in databricks to populate msiWorkSpaceResourceId.</summary>
    [JsonPropertyName("msiWorkSpaceResourceIdSelector")]
    public V1beta1LinkedServiceAzureDatabricksSpecInitProviderMsiWorkSpaceResourceIdSelector? MsiWorkSpaceResourceIdSelector { get; set; }

    /// <summary>Creates new clusters within the linked ADB instance as defined in the new_cluster_config block below.</summary>
    [JsonPropertyName("newClusterConfig")]
    public IList<V1beta1LinkedServiceAzureDatabricksSpecInitProviderNewClusterConfig>? NewClusterConfig { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecProviderConfigRefPolicy
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
public partial class V1beta1LinkedServiceAzureDatabricksSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureDatabricksSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinkedServiceAzureDatabricksSpec defines the desired state of LinkedServiceAzureDatabricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinkedServiceAzureDatabricksSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinkedServiceAzureDatabricksSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinkedServiceAzureDatabricksSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatusAtProviderInstancePool
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Identifier of the instance pool within the linked ADB instance.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>The max number of worker nodes. Set this value if you want to enable autoscaling between the min_number_of_workers and this value. Omit this value to use a fixed number of workers defined in the min_number_of_workers property.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>The minimum number of worker nodes. Defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatusAtProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores ADB access token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatusAtProviderNewClusterConfig
{
    /// <summary>Spark version of a the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>Tags for the cluster resource.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Driver node type for the cluster.</summary>
    [JsonPropertyName("driverNodeType")]
    public string? DriverNodeType { get; set; }

    /// <summary>User defined initialization scripts for the cluster.</summary>
    [JsonPropertyName("initScripts")]
    public IList<string>? InitScripts { get; set; }

    /// <summary>Location to deliver Spark driver, worker, and event logs.</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Specifies the maximum number of worker nodes. It should be between 1 and 25000.</summary>
    [JsonPropertyName("maxNumberOfWorkers")]
    public double? MaxNumberOfWorkers { get; set; }

    /// <summary>Specifies the minimum number of worker nodes. It should be between 1 and 25000. It defaults to 1.</summary>
    [JsonPropertyName("minNumberOfWorkers")]
    public double? MinNumberOfWorkers { get; set; }

    /// <summary>Node type for the new cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>User-specified Spark configuration variables key-value pairs.</summary>
    [JsonPropertyName("sparkConfig")]
    public IDictionary<string, string>? SparkConfig { get; set; }

    /// <summary>User-specified Spark environment variables key-value pairs.</summary>
    [JsonPropertyName("sparkEnvironmentVariables")]
    public IDictionary<string, string>? SparkEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatusAtProvider
{
    /// <summary>The domain URL of the databricks instance.</summary>
    [JsonPropertyName("adbDomain")]
    public string? AdbDomain { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The cluster_id of an existing cluster within the linked ADB instance.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>The ID of the Data Factory Linked Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Leverages an instance pool within the linked ADB instance as one instance_pool block defined below.</summary>
    [JsonPropertyName("instancePool")]
    public IList<V1beta1LinkedServiceAzureDatabricksStatusAtProviderInstancePool>? InstancePool { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>Authenticate to ADB via Azure Key Vault Linked Service as defined in the key_vault_password block below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureDatabricksStatusAtProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>Authenticate to ADB via managed service identity.</summary>
    [JsonPropertyName("msiWorkSpaceResourceId")]
    public string? MsiWorkSpaceResourceId { get; set; }

    /// <summary>Creates new clusters within the linked ADB instance as defined in the new_cluster_config block below.</summary>
    [JsonPropertyName("newClusterConfig")]
    public IList<V1beta1LinkedServiceAzureDatabricksStatusAtProviderNewClusterConfig>? NewClusterConfig { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatusConditions
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

/// <summary>LinkedServiceAzureDatabricksStatus defines the observed state of LinkedServiceAzureDatabricks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureDatabricksStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinkedServiceAzureDatabricksStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinkedServiceAzureDatabricksStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinkedServiceAzureDatabricks is the Schema for the LinkedServiceAzureDatabrickss API. Manages a Linked Service (connection) between Azure Databricks and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceAzureDatabricks : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinkedServiceAzureDatabricksSpec>, IStatus<V1beta1LinkedServiceAzureDatabricksStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceAzureDatabricks";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "linkedserviceazuredatabricks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinkedServiceAzureDatabricksSpec defines the desired state of LinkedServiceAzureDatabricks</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinkedServiceAzureDatabricksSpec Spec { get; set; }

    /// <summary>LinkedServiceAzureDatabricksStatus defines the observed state of LinkedServiceAzureDatabricks.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinkedServiceAzureDatabricksStatus? Status { get; set; }
}