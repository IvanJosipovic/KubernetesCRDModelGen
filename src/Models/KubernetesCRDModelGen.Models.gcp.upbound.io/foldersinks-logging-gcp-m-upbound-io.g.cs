using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.gcp.m.upbound.io;
/// <summary>FolderSink is the Schema for the FolderSinks API. Manages a folder-level logging sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FolderSinkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FolderSink>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FolderSinkList";
    public const string KubeGroup = "logging.gcp.m.upbound.io";
    public const string KubePluralName = "foldersinks";
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
    public IList<V1beta1FolderSink> Items { get; set; }
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderBigqueryOptions
{
    /// <summary>Whether to use BigQuery's partition tables. By default, Logging creates dated tables based on the log entries' timestamps, e.g. syslog_20170523. With partitioned tables, the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.</summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderFolderRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Folder in cloudplatform to populate folder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderFolderRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FolderSinkSpecForProviderFolderRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderFolderSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Folder in cloudplatform to populate folder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProviderFolderSelector
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
    public V1beta1FolderSinkSpecForProviderFolderSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecForProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta1FolderSinkSpecForProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta1FolderSinkSpecForProviderExclusions>? Exclusions { get; set; }

    /// <summary>The filter to apply when exporting logs. Only log entries that match the filter are exported. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The folder to be exported to the sink. Note that either [FOLDER_ID] or folders/[FOLDER_ID] is accepted.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>Reference to a Folder in cloudplatform to populate folder.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1FolderSinkSpecForProviderFolderRef? FolderRef { get; set; }

    /// <summary>Selector for a Folder in cloudplatform to populate folder.</summary>
    [JsonPropertyName("folderSelector")]
    public V1beta1FolderSinkSpecForProviderFolderSelector? FolderSelector { get; set; }

    /// <summary>Whether or not to include children folders in the sink export. If true, logs associated with child projects are also exported; otherwise only logs relating to the provided folder are included.</summary>
    [JsonPropertyName("includeChildren")]
    public bool? IncludeChildren { get; set; }

    /// <summary>Whether or not to intercept logs from child projects. If true, matching logs will not match with sinks in child resources, except _Required sinks. This sink will be visible to child resources when listing sinks.</summary>
    [JsonPropertyName("interceptChildren")]
    public bool? InterceptChildren { get; set; }
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecInitProviderBigqueryOptions
{
    /// <summary>Whether to use BigQuery's partition tables. By default, Logging creates dated tables based on the log entries' timestamps, e.g. syslog_20170523. With partitioned tables, the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.</summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecInitProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecInitProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta1FolderSinkSpecInitProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta1FolderSinkSpecInitProviderExclusions>? Exclusions { get; set; }

    /// <summary>The filter to apply when exporting logs. Only log entries that match the filter are exported. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether or not to include children folders in the sink export. If true, logs associated with child projects are also exported; otherwise only logs relating to the provided folder are included.</summary>
    [JsonPropertyName("includeChildren")]
    public bool? IncludeChildren { get; set; }

    /// <summary>Whether or not to intercept logs from child projects. If true, matching logs will not match with sinks in child resources, except _Required sinks. This sink will be visible to child resources when listing sinks.</summary>
    [JsonPropertyName("interceptChildren")]
    public bool? InterceptChildren { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpecProviderConfigRef
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
public partial class V1beta1FolderSinkSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FolderSinkSpec defines the desired state of FolderSink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FolderSinkSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FolderSinkSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FolderSinkSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FolderSinkSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkStatusAtProviderBigqueryOptions
{
    /// <summary>Whether to use BigQuery's partition tables. By default, Logging creates dated tables based on the log entries' timestamps, e.g. syslog_20170523. With partitioned tables, the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.</summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkStatusAtProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkStatusAtProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta1FolderSinkStatusAtProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta1FolderSinkStatusAtProviderExclusions>? Exclusions { get; set; }

    /// <summary>The filter to apply when exporting logs. Only log entries that match the filter are exported. See Advanced Log Filters for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The folder to be exported to the sink. Note that either [FOLDER_ID] or folders/[FOLDER_ID] is accepted.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>an identifier for the resource with format folders/{{folder_id}}/sinks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether or not to include children folders in the sink export. If true, logs associated with child projects are also exported; otherwise only logs relating to the provided folder are included.</summary>
    [JsonPropertyName("includeChildren")]
    public bool? IncludeChildren { get; set; }

    /// <summary>Whether or not to intercept logs from child projects. If true, matching logs will not match with sinks in child resources, except _Required sinks. This sink will be visible to child resources when listing sinks.</summary>
    [JsonPropertyName("interceptChildren")]
    public bool? InterceptChildren { get; set; }

    /// <summary>The identity associated with this sink. This identity must be granted write access to the configured destination.</summary>
    [JsonPropertyName("writerIdentity")]
    public string? WriterIdentity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkStatusConditions
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

/// <summary>FolderSinkStatus defines the observed state of FolderSink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FolderSinkStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FolderSinkStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FolderSinkStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FolderSink is the Schema for the FolderSinks API. Manages a folder-level logging sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FolderSink : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FolderSinkSpec>, IStatus<V1beta1FolderSinkStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FolderSink";
    public const string KubeGroup = "logging.gcp.m.upbound.io";
    public const string KubePluralName = "foldersinks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FolderSinkSpec defines the desired state of FolderSink</summary>
    [JsonPropertyName("spec")]
    public V1beta1FolderSinkSpec Spec { get; set; }

    /// <summary>FolderSinkStatus defines the observed state of FolderSink.</summary>
    [JsonPropertyName("status")]
    public V1beta1FolderSinkStatus? Status { get; set; }
}