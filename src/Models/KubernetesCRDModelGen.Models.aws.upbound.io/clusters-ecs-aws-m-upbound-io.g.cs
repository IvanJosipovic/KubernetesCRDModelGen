using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.m.upbound.io;
#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Provides an ECS cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationExecuteCommandConfigurationLogConfiguration
{
    /// <summary>Whether to enable encryption on the CloudWatch logs. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("cloudWatchEncryptionEnabled")]
    public bool? CloudWatchEncryptionEnabled { get; set; }

    /// <summary>The name of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("cloudWatchLogGroupName")]
    public string? CloudWatchLogGroupName { get; set; }

    /// <summary>Whether to enable encryption on the logs sent to S3. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("s3BucketEncryptionEnabled")]
    public bool? S3BucketEncryptionEnabled { get; set; }

    /// <summary>Name of the S3 bucket to send logs to.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Optional folder in the S3 bucket to place logs in.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationExecuteCommandConfiguration
{
    /// <summary>AWS Key Management Service key ID to encrypt the data between the local client and the container.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1ClusterSpecForProviderConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Log setting to use for redirecting logs for your execute command results. Valid values: NONE, DEFAULT, OVERRIDE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationManagedStorageConfiguration
{
    /// <summary>AWS Key Management Service key ID for the Fargate ephemeral storage.</summary>
    [JsonPropertyName("fargateEphemeralStorageKmsKeyId")]
    public string? FargateEphemeralStorageKmsKeyId { get; set; }

    /// <summary>AWS Key Management Service key ID to encrypt the managed storage.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfiguration
{
    /// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
    [JsonPropertyName("executeCommandConfiguration")]
    public V1beta1ClusterSpecForProviderConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration { get; set; }

    /// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
    [JsonPropertyName("managedStorageConfiguration")]
    public V1beta1ClusterSpecForProviderConfigurationManagedStorageConfiguration? ManagedStorageConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderServiceConnectDefaults
{
    /// <summary>ARN of the aws_service_discovery_http_namespace that's used when you create a service and don't specify a Service Connect configuration.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSetting
{
    /// <summary>Name of the setting to manage. Valid values: containerInsights.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value to assign to the setting. Valid values: enhanced, enabled, disabled.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1ClusterSpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
    [JsonPropertyName("serviceConnectDefaults")]
    public V1beta1ClusterSpecForProviderServiceConnectDefaults? ServiceConnectDefaults { get; set; }

    /// <summary>Configuration block(s) with cluster settings. For example, this can be used to enable CloudWatch Container Insights for a cluster. See setting Block for details.</summary>
    [JsonPropertyName("setting")]
    public IList<V1beta1ClusterSpecForProviderSetting>? Setting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationExecuteCommandConfigurationLogConfiguration
{
    /// <summary>Whether to enable encryption on the CloudWatch logs. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("cloudWatchEncryptionEnabled")]
    public bool? CloudWatchEncryptionEnabled { get; set; }

    /// <summary>The name of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("cloudWatchLogGroupName")]
    public string? CloudWatchLogGroupName { get; set; }

    /// <summary>Whether to enable encryption on the logs sent to S3. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("s3BucketEncryptionEnabled")]
    public bool? S3BucketEncryptionEnabled { get; set; }

    /// <summary>Name of the S3 bucket to send logs to.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Optional folder in the S3 bucket to place logs in.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationExecuteCommandConfiguration
{
    /// <summary>AWS Key Management Service key ID to encrypt the data between the local client and the container.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1ClusterSpecInitProviderConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Log setting to use for redirecting logs for your execute command results. Valid values: NONE, DEFAULT, OVERRIDE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationManagedStorageConfiguration
{
    /// <summary>AWS Key Management Service key ID for the Fargate ephemeral storage.</summary>
    [JsonPropertyName("fargateEphemeralStorageKmsKeyId")]
    public string? FargateEphemeralStorageKmsKeyId { get; set; }

    /// <summary>AWS Key Management Service key ID to encrypt the managed storage.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfiguration
{
    /// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
    [JsonPropertyName("executeCommandConfiguration")]
    public V1beta1ClusterSpecInitProviderConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration { get; set; }

    /// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
    [JsonPropertyName("managedStorageConfiguration")]
    public V1beta1ClusterSpecInitProviderConfigurationManagedStorageConfiguration? ManagedStorageConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderServiceConnectDefaults
{
    /// <summary>ARN of the aws_service_discovery_http_namespace that's used when you create a service and don't specify a Service Connect configuration.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSetting
{
    /// <summary>Name of the setting to manage. Valid values: containerInsights.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value to assign to the setting. Valid values: enhanced, enabled, disabled.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1ClusterSpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
    [JsonPropertyName("serviceConnectDefaults")]
    public V1beta1ClusterSpecInitProviderServiceConnectDefaults? ServiceConnectDefaults { get; set; }

    /// <summary>Configuration block(s) with cluster settings. For example, this can be used to enable CloudWatch Container Insights for a cluster. See setting Block for details.</summary>
    [JsonPropertyName("setting")]
    public IList<V1beta1ClusterSpecInitProviderSetting>? Setting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfigurationExecuteCommandConfigurationLogConfiguration
{
    /// <summary>Whether to enable encryption on the CloudWatch logs. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("cloudWatchEncryptionEnabled")]
    public bool? CloudWatchEncryptionEnabled { get; set; }

    /// <summary>The name of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("cloudWatchLogGroupName")]
    public string? CloudWatchLogGroupName { get; set; }

    /// <summary>Whether to enable encryption on the logs sent to S3. If not specified, encryption will be disabled.</summary>
    [JsonPropertyName("s3BucketEncryptionEnabled")]
    public bool? S3BucketEncryptionEnabled { get; set; }

    /// <summary>Name of the S3 bucket to send logs to.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Optional folder in the S3 bucket to place logs in.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfigurationExecuteCommandConfiguration
{
    /// <summary>AWS Key Management Service key ID to encrypt the data between the local client and the container.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Log configuration for the results of the execute command actions. Required when logging is OVERRIDE. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1ClusterStatusAtProviderConfigurationExecuteCommandConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Log setting to use for redirecting logs for your execute command results. Valid values: NONE, DEFAULT, OVERRIDE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfigurationManagedStorageConfiguration
{
    /// <summary>AWS Key Management Service key ID for the Fargate ephemeral storage.</summary>
    [JsonPropertyName("fargateEphemeralStorageKmsKeyId")]
    public string? FargateEphemeralStorageKmsKeyId { get; set; }

    /// <summary>AWS Key Management Service key ID to encrypt the managed storage.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfiguration
{
    /// <summary>Details of the execute command configuration. See execute_command_configuration Block for details.</summary>
    [JsonPropertyName("executeCommandConfiguration")]
    public V1beta1ClusterStatusAtProviderConfigurationExecuteCommandConfiguration? ExecuteCommandConfiguration { get; set; }

    /// <summary>Details of the managed storage configuration. See managed_storage_configuration Block for details.</summary>
    [JsonPropertyName("managedStorageConfiguration")]
    public V1beta1ClusterStatusAtProviderConfigurationManagedStorageConfiguration? ManagedStorageConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderServiceConnectDefaults
{
    /// <summary>ARN of the aws_service_discovery_http_namespace that's used when you create a service and don't specify a Service Connect configuration.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSetting
{
    /// <summary>Name of the setting to manage. Valid values: containerInsights.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value to assign to the setting. Valid values: enhanced, enabled, disabled.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>ARN that identifies the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Execute command configuration for the cluster. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1ClusterStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Default Service Connect namespace. See service_connect_defaults Block for details.</summary>
    [JsonPropertyName("serviceConnectDefaults")]
    public V1beta1ClusterStatusAtProviderServiceConnectDefaults? ServiceConnectDefaults { get; set; }

    /// <summary>Configuration block(s) with cluster settings. For example, this can be used to enable CloudWatch Container Insights for a cluster. See setting Block for details.</summary>
    [JsonPropertyName("setting")]
    public IList<V1beta1ClusterStatusAtProviderSetting>? Setting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Provides an ECS cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}
#nullable disable
