using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>ExternalLocation is the Schema for the ExternalLocations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ExternalLocationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ExternalLocation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ExternalLocationList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "externallocations";
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
    public IList<V1alpha1ExternalLocation> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = "SSE-KMS". Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public IList<V1alpha1ExternalLocationSpecForProviderEncryptionDetailsSseEncryptionDetails>? SseEncryptionDetails { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedAqs>? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedPubsub>? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueManagedSqs>? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedAqs>? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedPubsub>? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueueProvidedSqs>? ProvidedSqs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecForProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionDetails")]
    public IList<V1alpha1ExternalLocationSpecForProviderEncryptionDetails>? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileEventQueue")]
    public IList<V1alpha1ExternalLocationSpecForProviderFileEventQueue>? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = "SSE-KMS". Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public IList<V1alpha1ExternalLocationSpecInitProviderEncryptionDetailsSseEncryptionDetails>? SseEncryptionDetails { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedAqs>? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedPubsub>? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueManagedSqs>? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedAqs>? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedPubsub>? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueueProvidedSqs>? ProvidedSqs { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecInitProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionDetails")]
    public IList<V1alpha1ExternalLocationSpecInitProviderEncryptionDetails>? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileEventQueue")]
    public IList<V1alpha1ExternalLocationSpecInitProviderFileEventQueue>? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecProviderConfigRefPolicy
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
public partial class V1alpha1ExternalLocationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ExternalLocationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1ExternalLocationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ExternalLocationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1ExternalLocationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1ExternalLocationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ExternalLocationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ExternalLocationSpec defines the desired state of ExternalLocation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1ExternalLocationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1ExternalLocationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ExternalLocationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1ExternalLocationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ExternalLocationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = "SSE-KMS". Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public IList<V1alpha1ExternalLocationStatusAtProviderEncryptionDetailsSseEncryptionDetails>? SseEncryptionDetails { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedAqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedPubsub
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedSqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedAqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedPubsub
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedSqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedAqs>? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedPubsub>? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueManagedSqs>? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedAqs>? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedPubsub>? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueueProvidedSqs>? ProvidedSqs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("browseOnly")]
    public bool? BrowseOnly { get; set; }

    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time at which this external location was created, in epoch milliseconds.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>Username of external location creator.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Unique ID of the location's storage credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionDetails")]
    public IList<V1alpha1ExternalLocationStatusAtProviderEncryptionDetails>? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileEventQueue")]
    public IList<V1alpha1ExternalLocationStatusAtProviderFileEventQueue>? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Time at which external location this was last modified, in epoch milliseconds.</summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary>Username of user who last modified the external location.</summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatusConditions
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

/// <summary>ExternalLocationStatus defines the observed state of ExternalLocation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExternalLocationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ExternalLocationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ExternalLocationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExternalLocation is the Schema for the ExternalLocations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ExternalLocation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ExternalLocationSpec>, IStatus<V1alpha1ExternalLocationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ExternalLocation";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "externallocations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExternalLocationSpec defines the desired state of ExternalLocation</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ExternalLocationSpec Spec { get; set; }

    /// <summary>ExternalLocationStatus defines the observed state of ExternalLocation.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ExternalLocationStatus? Status { get; set; }
}