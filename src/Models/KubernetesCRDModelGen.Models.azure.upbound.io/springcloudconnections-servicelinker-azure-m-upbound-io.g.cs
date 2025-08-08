using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicelinker.azure.m.upbound.io;
/// <summary>Service principal certificate for servicePrincipal auth. Should be specified when type is set to servicePrincipalCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderAuthenticationCertificateSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Password or account key for secret auth. secret and name should be either both specified or both not specified when type is set to secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderAuthenticationSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The authentication info. An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderAuthentication
{
    /// <summary>Service principal certificate for servicePrincipal auth. Should be specified when type is set to servicePrincipalCertificate.</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1SpringCloudConnectionSpecForProviderAuthenticationCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Client ID for userAssignedIdentity or servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate. When type is set to userAssignedIdentity, client_id and subscription_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Username or account name for secret auth. name and secret should be either both specified or both not specified when type is set to secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Principal ID for servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Password or account key for secret auth. secret and name should be either both specified or both not specified when type is set to secret.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta1SpringCloudConnectionSpecForProviderAuthenticationSecretSecretRef? SecretSecretRef { get; set; }

    /// <summary>Subscription ID for userAssignedIdentity. subscription_id and client_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The authentication type. Possible values are systemAssignedIdentity, userAssignedIdentity, servicePrincipalSecret, servicePrincipalCertificate, secret. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderSecretStore
{
    /// <summary>The key vault id to store secret.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdSelector
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
    public V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdSelector
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
    public V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecForProvider
{
    /// <summary>The authentication info. An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1SpringCloudConnectionSpecForProviderAuthentication? Authentication { get; set; }

    /// <summary>The application client type. Possible values are none, dotnet, java, python, go, php, ruby, django, nodejs and springBoot. Defaults to none.</summary>
    [JsonPropertyName("clientType")]
    public string? ClientType { get; set; }

    /// <summary>The name of the service connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
    [JsonPropertyName("secretStore")]
    public V1beta1SpringCloudConnectionSpecForProviderSecretStore? SecretStore { get; set; }

    /// <summary>The ID of the data source spring cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudId")]
    public string? SpringCloudId { get; set; }

    /// <summary>Reference to a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
    [JsonPropertyName("springCloudIdRef")]
    public V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdRef? SpringCloudIdRef { get; set; }

    /// <summary>Selector for a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
    [JsonPropertyName("springCloudIdSelector")]
    public V1beta1SpringCloudConnectionSpecForProviderSpringCloudIdSelector? SpringCloudIdSelector { get; set; }

    /// <summary>The ID of the target resource. Changing this forces a new resource to be created. Possible target resources are Postgres, PostgresFlexible, Mysql, Sql, Redis, RedisEnterprise, CosmosCassandra, CosmosGremlin, CosmosMongo, CosmosSql, CosmosTable, StorageBlob, StorageQueue, StorageFile, StorageTable, AppConfig, EventHub, ServiceBus, SignalR, WebPubSub, ConfluentKafka. The integration guide can be found here.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta1SpringCloudConnectionSpecForProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }

    /// <summary>The type of the VNet solution. Possible values are serviceEndpoint, privateLink.</summary>
    [JsonPropertyName("vnetSolution")]
    public string? VnetSolution { get; set; }
}

/// <summary>Service principal certificate for servicePrincipal auth. Should be specified when type is set to servicePrincipalCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderAuthenticationCertificateSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Password or account key for secret auth. secret and name should be either both specified or both not specified when type is set to secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderAuthenticationSecretSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The authentication info. An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderAuthentication
{
    /// <summary>Service principal certificate for servicePrincipal auth. Should be specified when type is set to servicePrincipalCertificate.</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1SpringCloudConnectionSpecInitProviderAuthenticationCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Client ID for userAssignedIdentity or servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate. When type is set to userAssignedIdentity, client_id and subscription_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Username or account name for secret auth. name and secret should be either both specified or both not specified when type is set to secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Principal ID for servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Password or account key for secret auth. secret and name should be either both specified or both not specified when type is set to secret.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta1SpringCloudConnectionSpecInitProviderAuthenticationSecretSecretRef? SecretSecretRef { get; set; }

    /// <summary>Subscription ID for userAssignedIdentity. subscription_id and client_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The authentication type. Possible values are systemAssignedIdentity, userAssignedIdentity, servicePrincipalSecret, servicePrincipalCertificate, secret. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderSecretStore
{
    /// <summary>The key vault id to store secret.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdSelector
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
    public V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdSelector
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
    public V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecInitProvider
{
    /// <summary>The authentication info. An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1SpringCloudConnectionSpecInitProviderAuthentication? Authentication { get; set; }

    /// <summary>The application client type. Possible values are none, dotnet, java, python, go, php, ruby, django, nodejs and springBoot. Defaults to none.</summary>
    [JsonPropertyName("clientType")]
    public string? ClientType { get; set; }

    /// <summary>The name of the service connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
    [JsonPropertyName("secretStore")]
    public V1beta1SpringCloudConnectionSpecInitProviderSecretStore? SecretStore { get; set; }

    /// <summary>The ID of the data source spring cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudId")]
    public string? SpringCloudId { get; set; }

    /// <summary>Reference to a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
    [JsonPropertyName("springCloudIdRef")]
    public V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdRef? SpringCloudIdRef { get; set; }

    /// <summary>Selector for a SpringCloudJavaDeployment in appplatform to populate springCloudId.</summary>
    [JsonPropertyName("springCloudIdSelector")]
    public V1beta1SpringCloudConnectionSpecInitProviderSpringCloudIdSelector? SpringCloudIdSelector { get; set; }

    /// <summary>The ID of the target resource. Changing this forces a new resource to be created. Possible target resources are Postgres, PostgresFlexible, Mysql, Sql, Redis, RedisEnterprise, CosmosCassandra, CosmosGremlin, CosmosMongo, CosmosSql, CosmosTable, StorageBlob, StorageQueue, StorageFile, StorageTable, AppConfig, EventHub, ServiceBus, SignalR, WebPubSub, ConfluentKafka. The integration guide can be found here.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a SQLDatabase in cosmosdb to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta1SpringCloudConnectionSpecInitProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }

    /// <summary>The type of the VNet solution. Possible values are serviceEndpoint, privateLink.</summary>
    [JsonPropertyName("vnetSolution")]
    public string? VnetSolution { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpecProviderConfigRef
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
public partial class V1beta1SpringCloudConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SpringCloudConnectionSpec defines the desired state of SpringCloudConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The authentication info. An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionStatusAtProviderAuthentication
{
    /// <summary>Client ID for userAssignedIdentity or servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate. When type is set to userAssignedIdentity, client_id and subscription_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Username or account name for secret auth. name and secret should be either both specified or both not specified when type is set to secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Principal ID for servicePrincipal auth. Should be specified when type is set to servicePrincipalSecret or servicePrincipalCertificate.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Subscription ID for userAssignedIdentity. subscription_id and client_id should be either both specified or both not specified.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The authentication type. Possible values are systemAssignedIdentity, userAssignedIdentity, servicePrincipalSecret, servicePrincipalCertificate, secret. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionStatusAtProviderSecretStore
{
    /// <summary>The key vault id to store secret.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionStatusAtProvider
{
    /// <summary>The authentication info. An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1SpringCloudConnectionStatusAtProviderAuthentication? Authentication { get; set; }

    /// <summary>The application client type. Possible values are none, dotnet, java, python, go, php, ruby, django, nodejs and springBoot. Defaults to none.</summary>
    [JsonPropertyName("clientType")]
    public string? ClientType { get; set; }

    /// <summary>The ID of the service connector.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the service connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An option to store secret value in secure place. An secret_store block as defined below.</summary>
    [JsonPropertyName("secretStore")]
    public V1beta1SpringCloudConnectionStatusAtProviderSecretStore? SecretStore { get; set; }

    /// <summary>The ID of the data source spring cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudId")]
    public string? SpringCloudId { get; set; }

    /// <summary>The ID of the target resource. Changing this forces a new resource to be created. Possible target resources are Postgres, PostgresFlexible, Mysql, Sql, Redis, RedisEnterprise, CosmosCassandra, CosmosGremlin, CosmosMongo, CosmosSql, CosmosTable, StorageBlob, StorageQueue, StorageFile, StorageTable, AppConfig, EventHub, ServiceBus, SignalR, WebPubSub, ConfluentKafka. The integration guide can be found here.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>The type of the VNet solution. Possible values are serviceEndpoint, privateLink.</summary>
    [JsonPropertyName("vnetSolution")]
    public string? VnetSolution { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionStatusConditions
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

/// <summary>SpringCloudConnectionStatus defines the observed state of SpringCloudConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudConnection is the Schema for the SpringCloudConnections API. Manages a service connector for spring cloud app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudConnectionSpec>, IStatus<V1beta1SpringCloudConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudConnection";
    public const string KubeGroup = "servicelinker.azure.m.upbound.io";
    public const string KubePluralName = "springcloudconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudConnectionSpec defines the desired state of SpringCloudConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudConnectionSpec Spec { get; set; }

    /// <summary>SpringCloudConnectionStatus defines the observed state of SpringCloudConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudConnectionStatus? Status { get; set; }
}

/// <summary>SpringCloudConnection is the Schema for the SpringCloudConnections API. Manages a service connector for spring cloud app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudConnection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudConnectionList";
    public const string KubeGroup = "servicelinker.azure.m.upbound.io";
    public const string KubePluralName = "springcloudconnections";
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
    public IList<V1beta1SpringCloudConnection> Items { get; set; }
}