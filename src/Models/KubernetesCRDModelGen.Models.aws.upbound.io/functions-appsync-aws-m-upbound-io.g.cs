using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderApiIdSelector
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
    public V1beta1FunctionSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDataSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDataSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderDataSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDataSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDataSourceSelector
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
    public V1beta1FunctionSpecForProviderDataSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta1FunctionSpecForProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProvider
{
    /// <summary>ID of the associated AppSync API.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1FunctionSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1FunctionSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Function data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1beta1FunctionSpecForProviderDataSourceRef? DataSourceRef { get; set; }

    /// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceSelector")]
    public V1beta1FunctionSpecForProviderDataSourceSelector? DataSourceSelector { get; set; }

    /// <summary>Function description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Version of the request mapping template. Currently the supported value is 2018-05-29. Does not apply when specifying code.</summary>
    [JsonPropertyName("functionVersion")]
    public string? FunctionVersion { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>Function name. The function name does not have to be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Function request mapping template. Functions support only the 2018-05-29 version of the request mapping template.</summary>
    [JsonPropertyName("requestMappingTemplate")]
    public string? RequestMappingTemplate { get; set; }

    /// <summary>Function response mapping template.</summary>
    [JsonPropertyName("responseMappingTemplate")]
    public string? ResponseMappingTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
    [JsonPropertyName("runtime")]
    public V1beta1FunctionSpecForProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta1FunctionSpecForProviderSyncConfig? SyncConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderApiIdSelector
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
    public V1beta1FunctionSpecInitProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDataSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDataSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderDataSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDataSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDataSourceSelector
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
    public V1beta1FunctionSpecInitProviderDataSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta1FunctionSpecInitProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProvider
{
    /// <summary>ID of the associated AppSync API.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1FunctionSpecInitProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1FunctionSpecInitProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Function data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1beta1FunctionSpecInitProviderDataSourceRef? DataSourceRef { get; set; }

    /// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceSelector")]
    public V1beta1FunctionSpecInitProviderDataSourceSelector? DataSourceSelector { get; set; }

    /// <summary>Function description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Version of the request mapping template. Currently the supported value is 2018-05-29. Does not apply when specifying code.</summary>
    [JsonPropertyName("functionVersion")]
    public string? FunctionVersion { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>Function name. The function name does not have to be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Function request mapping template. Functions support only the 2018-05-29 version of the request mapping template.</summary>
    [JsonPropertyName("requestMappingTemplate")]
    public string? RequestMappingTemplate { get; set; }

    /// <summary>Function response mapping template.</summary>
    [JsonPropertyName("responseMappingTemplate")]
    public string? ResponseMappingTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
    [JsonPropertyName("runtime")]
    public V1beta1FunctionSpecInitProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta1FunctionSpecInitProviderSyncConfig? SyncConfig { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecProviderConfigRef
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
public partial class V1beta1FunctionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See lambda_conflict_handler_config Block for details.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta1FunctionStatusAtProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProvider
{
    /// <summary>ID of the associated AppSync API.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ARN of the Function object.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Function data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Function description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Unique ID representing the Function object.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Version of the request mapping template. Currently the supported value is 2018-05-29. Does not apply when specifying code.</summary>
    [JsonPropertyName("functionVersion")]
    public string? FunctionVersion { get; set; }

    /// <summary>API Function ID (Formatted as ApiId-FunctionId)</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>Function name. The function name does not have to be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Function request mapping template. Functions support only the 2018-05-29 version of the request mapping template.</summary>
    [JsonPropertyName("requestMappingTemplate")]
    public string? RequestMappingTemplate { get; set; }

    /// <summary>Function response mapping template.</summary>
    [JsonPropertyName("responseMappingTemplate")]
    public string? ResponseMappingTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See runtime Block for details.</summary>
    [JsonPropertyName("runtime")]
    public V1beta1FunctionStatusAtProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See sync_config Block for details.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta1FunctionStatusAtProviderSyncConfig? SyncConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusConditions
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

/// <summary>FunctionStatus defines the observed state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Function is the Schema for the Functions API. Provides an AppSync Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionSpec>, IStatus<V1beta1FunctionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "appsync.aws.m.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec defines the desired state of Function</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionSpec Spec { get; set; }

    /// <summary>FunctionStatus defines the observed state of Function.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionStatus? Status { get; set; }
}

/// <summary>Function is the Schema for the Functions API. Provides an AppSync Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Function>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "appsync.aws.m.upbound.io";
    public const string KubePluralName = "functions";
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
    public IList<V1beta1Function> Items { get; set; }
}