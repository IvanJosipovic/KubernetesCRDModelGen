using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
/// <summary>ProxyDefaultTargetGroup is the Schema for the ProxyDefaultTargetGroups API. Manage an RDS DB proxy default target group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProxyDefaultTargetGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ProxyDefaultTargetGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProxyDefaultTargetGroupList";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "proxydefaulttargetgroups";
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
    public IList<V1beta1ProxyDefaultTargetGroup> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProviderConnectionPoolConfig
{
    /// <summary>The number of seconds for a proxy to wait for a connection to become available in the connection pool. Only applies when the proxy has opened its maximum number of connections and all connections are busy with client sessions.</summary>
    [JsonPropertyName("connectionBorrowTimeout")]
    public double? ConnectionBorrowTimeout { get; set; }

    /// <summary>One or more SQL statements for the proxy to run when opening each new database connection. Typically used with SET statements to make sure that each connection has identical settings such as time zone and character set. This setting is empty by default. For multiple statements, use semicolons as the separator. You can also include multiple variables in a single SET statement, such as SET x=1, y=2.</summary>
    [JsonPropertyName("initQuery")]
    public string? InitQuery { get; set; }

    /// <summary>The maximum size of the connection pool for each target in a target group. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxConnectionsPercent")]
    public double? MaxConnectionsPercent { get; set; }

    /// <summary>Controls how actively the proxy closes idle database connections in the connection pool. A high value enables the proxy to leave a high percentage of idle connections open. A low value causes the proxy to close idle client connections and return the underlying database connections to the connection pool. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxIdleConnectionsPercent")]
    public double? MaxIdleConnectionsPercent { get; set; }

    /// <summary>Each item in the list represents a class of SQL operations that normally cause all later statements in a session using a proxy to be pinned to the same underlying database connection. Including an item in the list exempts that class of SQL operations from the pinning behavior. This setting is only supported for MySQL engine family databases. Currently, the only allowed value is EXCLUDE_VARIABLE_SETS.</summary>
    [JsonPropertyName("sessionPinningFilters")]
    public IList<string>? SessionPinningFilters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Proxy in rds to populate dbProxyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Proxy in rds to populate dbProxyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecForProvider
{
    /// <summary>The settings that determine the size and behavior of the connection pool for the target group.</summary>
    [JsonPropertyName("connectionPoolConfig")]
    public IList<V1beta1ProxyDefaultTargetGroupSpecForProviderConnectionPoolConfig>? ConnectionPoolConfig { get; set; }

    /// <summary>Name of the RDS DB Proxy.</summary>
    [JsonPropertyName("dbProxyName")]
    public string? DbProxyName { get; set; }

    /// <summary>Reference to a Proxy in rds to populate dbProxyName.</summary>
    [JsonPropertyName("dbProxyNameRef")]
    public V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameRef? DbProxyNameRef { get; set; }

    /// <summary>Selector for a Proxy in rds to populate dbProxyName.</summary>
    [JsonPropertyName("dbProxyNameSelector")]
    public V1beta1ProxyDefaultTargetGroupSpecForProviderDbProxyNameSelector? DbProxyNameSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProviderConnectionPoolConfig
{
    /// <summary>The number of seconds for a proxy to wait for a connection to become available in the connection pool. Only applies when the proxy has opened its maximum number of connections and all connections are busy with client sessions.</summary>
    [JsonPropertyName("connectionBorrowTimeout")]
    public double? ConnectionBorrowTimeout { get; set; }

    /// <summary>One or more SQL statements for the proxy to run when opening each new database connection. Typically used with SET statements to make sure that each connection has identical settings such as time zone and character set. This setting is empty by default. For multiple statements, use semicolons as the separator. You can also include multiple variables in a single SET statement, such as SET x=1, y=2.</summary>
    [JsonPropertyName("initQuery")]
    public string? InitQuery { get; set; }

    /// <summary>The maximum size of the connection pool for each target in a target group. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxConnectionsPercent")]
    public double? MaxConnectionsPercent { get; set; }

    /// <summary>Controls how actively the proxy closes idle database connections in the connection pool. A high value enables the proxy to leave a high percentage of idle connections open. A low value causes the proxy to close idle client connections and return the underlying database connections to the connection pool. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxIdleConnectionsPercent")]
    public double? MaxIdleConnectionsPercent { get; set; }

    /// <summary>Each item in the list represents a class of SQL operations that normally cause all later statements in a session using a proxy to be pinned to the same underlying database connection. Including an item in the list exempts that class of SQL operations from the pinning behavior. This setting is only supported for MySQL engine family databases. Currently, the only allowed value is EXCLUDE_VARIABLE_SETS.</summary>
    [JsonPropertyName("sessionPinningFilters")]
    public IList<string>? SessionPinningFilters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Proxy in rds to populate dbProxyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Proxy in rds to populate dbProxyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecInitProvider
{
    /// <summary>The settings that determine the size and behavior of the connection pool for the target group.</summary>
    [JsonPropertyName("connectionPoolConfig")]
    public IList<V1beta1ProxyDefaultTargetGroupSpecInitProviderConnectionPoolConfig>? ConnectionPoolConfig { get; set; }

    /// <summary>Name of the RDS DB Proxy.</summary>
    [JsonPropertyName("dbProxyName")]
    public string? DbProxyName { get; set; }

    /// <summary>Reference to a Proxy in rds to populate dbProxyName.</summary>
    [JsonPropertyName("dbProxyNameRef")]
    public V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameRef? DbProxyNameRef { get; set; }

    /// <summary>Selector for a Proxy in rds to populate dbProxyName.</summary>
    [JsonPropertyName("dbProxyNameSelector")]
    public V1beta1ProxyDefaultTargetGroupSpecInitProviderDbProxyNameSelector? DbProxyNameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecProviderConfigRefPolicy
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
public partial class V1beta1ProxyDefaultTargetGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProxyDefaultTargetGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ProxyDefaultTargetGroupSpec defines the desired state of ProxyDefaultTargetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ProxyDefaultTargetGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ProxyDefaultTargetGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ProxyDefaultTargetGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ProxyDefaultTargetGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupStatusAtProviderConnectionPoolConfig
{
    /// <summary>The number of seconds for a proxy to wait for a connection to become available in the connection pool. Only applies when the proxy has opened its maximum number of connections and all connections are busy with client sessions.</summary>
    [JsonPropertyName("connectionBorrowTimeout")]
    public double? ConnectionBorrowTimeout { get; set; }

    /// <summary>One or more SQL statements for the proxy to run when opening each new database connection. Typically used with SET statements to make sure that each connection has identical settings such as time zone and character set. This setting is empty by default. For multiple statements, use semicolons as the separator. You can also include multiple variables in a single SET statement, such as SET x=1, y=2.</summary>
    [JsonPropertyName("initQuery")]
    public string? InitQuery { get; set; }

    /// <summary>The maximum size of the connection pool for each target in a target group. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxConnectionsPercent")]
    public double? MaxConnectionsPercent { get; set; }

    /// <summary>Controls how actively the proxy closes idle database connections in the connection pool. A high value enables the proxy to leave a high percentage of idle connections open. A low value causes the proxy to close idle client connections and return the underlying database connections to the connection pool. For Aurora MySQL, it is expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB cluster used by the target group.</summary>
    [JsonPropertyName("maxIdleConnectionsPercent")]
    public double? MaxIdleConnectionsPercent { get; set; }

    /// <summary>Each item in the list represents a class of SQL operations that normally cause all later statements in a session using a proxy to be pinned to the same underlying database connection. Including an item in the list exempts that class of SQL operations from the pinning behavior. This setting is only supported for MySQL engine family databases. Currently, the only allowed value is EXCLUDE_VARIABLE_SETS.</summary>
    [JsonPropertyName("sessionPinningFilters")]
    public IList<string>? SessionPinningFilters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) representing the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The settings that determine the size and behavior of the connection pool for the target group.</summary>
    [JsonPropertyName("connectionPoolConfig")]
    public IList<V1beta1ProxyDefaultTargetGroupStatusAtProviderConnectionPoolConfig>? ConnectionPoolConfig { get; set; }

    /// <summary>Name of the RDS DB Proxy.</summary>
    [JsonPropertyName("dbProxyName")]
    public string? DbProxyName { get; set; }

    /// <summary>Name of the RDS DB Proxy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the default target group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupStatusConditions
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

/// <summary>ProxyDefaultTargetGroupStatus defines the observed state of ProxyDefaultTargetGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProxyDefaultTargetGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ProxyDefaultTargetGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProxyDefaultTargetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ProxyDefaultTargetGroup is the Schema for the ProxyDefaultTargetGroups API. Manage an RDS DB proxy default target group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProxyDefaultTargetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProxyDefaultTargetGroupSpec>, IStatus<V1beta1ProxyDefaultTargetGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProxyDefaultTargetGroup";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "proxydefaulttargetgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProxyDefaultTargetGroupSpec defines the desired state of ProxyDefaultTargetGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProxyDefaultTargetGroupSpec Spec { get; set; }

    /// <summary>ProxyDefaultTargetGroupStatus defines the observed state of ProxyDefaultTargetGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProxyDefaultTargetGroupStatus? Status { get; set; }
}