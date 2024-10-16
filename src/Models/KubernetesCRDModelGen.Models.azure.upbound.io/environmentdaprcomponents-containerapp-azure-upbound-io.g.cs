using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderMetadata
{
    /// <summary>The name of the Metadata configuration item. The name of the Metadata configuration item.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of a secret specified in the secrets block that contains the value for this metadata configuration item. The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this metadata configuration item. The value for this metadata configuration item.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The value for this secret. The value for this secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProviderSecretValueSecretRef
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
public partial class V1beta1EnvironmentDaprComponentSpecForProviderSecret
{
    /// <summary>The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of the Container App Environment Dapr Component The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Secret name. The secret name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The value for this secret.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1EnvironmentDaprComponentSpecForProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecForProvider
{
    /// <summary>The Dapr Component Type. For example state.azure.blobstorage. Changing this forces a new resource to be created. The Dapr Component Type. For example `state.azure.blobstorage`.</summary>
    [JsonPropertyName("componentType")]
    public string? ComponentType { get; set; }

    /// <summary>The ID of the Container App Managed Environment for this Dapr Component. Changing this forces a new resource to be created. The Container App Managed Environment ID to configure this Dapr component on.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta1EnvironmentDaprComponentSpecForProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to false Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`</summary>
    [JsonPropertyName("ignoreErrors")]
    public bool? IgnoreErrors { get; set; }

    /// <summary>The timeout for component initialisation as a ISO8601 formatted string. e.g. 5s, 2h, 1m. Defaults to 5s. The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.</summary>
    [JsonPropertyName("initTimeout")]
    public string? InitTimeout { get; set; }

    /// <summary>One or more metadata blocks as detailed below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1EnvironmentDaprComponentSpecForProviderMetadata>? Metadata { get; set; }

    /// <summary>A list of scopes to which this component applies. A list of scopes to which this component applies. e.g. a Container App's `dapr.app_id` value.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1EnvironmentDaprComponentSpecForProviderSecret>? Secret { get; set; }

    /// <summary>The version of the component. The version of the component.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecInitProviderMetadata
{
    /// <summary>The name of the Metadata configuration item. The name of the Metadata configuration item.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of a secret specified in the secrets block that contains the value for this metadata configuration item. The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this metadata configuration item. The value for this metadata configuration item.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The value for this secret. The value for this secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecInitProviderSecretValueSecretRef
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
public partial class V1beta1EnvironmentDaprComponentSpecInitProviderSecret
{
    /// <summary>The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of the Container App Environment Dapr Component The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Secret name. The secret name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The value for this secret.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1EnvironmentDaprComponentSpecInitProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecInitProvider
{
    /// <summary>The Dapr Component Type. For example state.azure.blobstorage. Changing this forces a new resource to be created. The Dapr Component Type. For example `state.azure.blobstorage`.</summary>
    [JsonPropertyName("componentType")]
    public string? ComponentType { get; set; }

    /// <summary>Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to false Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`</summary>
    [JsonPropertyName("ignoreErrors")]
    public bool? IgnoreErrors { get; set; }

    /// <summary>The timeout for component initialisation as a ISO8601 formatted string. e.g. 5s, 2h, 1m. Defaults to 5s. The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.</summary>
    [JsonPropertyName("initTimeout")]
    public string? InitTimeout { get; set; }

    /// <summary>One or more metadata blocks as detailed below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1EnvironmentDaprComponentSpecInitProviderMetadata>? Metadata { get; set; }

    /// <summary>A list of scopes to which this component applies. A list of scopes to which this component applies. e.g. a Container App's `dapr.app_id` value.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1EnvironmentDaprComponentSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>The version of the component. The version of the component.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecProviderConfigRefPolicy
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
public partial class V1beta1EnvironmentDaprComponentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentDaprComponentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EnvironmentDaprComponentSpec defines the desired state of EnvironmentDaprComponent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EnvironmentDaprComponentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EnvironmentDaprComponentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvironmentDaprComponentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EnvironmentDaprComponentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvironmentDaprComponentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentStatusAtProviderMetadata
{
    /// <summary>The name of the Metadata configuration item. The name of the Metadata configuration item.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of a secret specified in the secrets block that contains the value for this metadata configuration item. The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this metadata configuration item. The value for this metadata configuration item.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentStatusAtProviderSecret
{
    /// <summary>The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of the Container App Environment Dapr Component The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Secret name. The secret name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentStatusAtProvider
{
    /// <summary>The Dapr Component Type. For example state.azure.blobstorage. Changing this forces a new resource to be created. The Dapr Component Type. For example `state.azure.blobstorage`.</summary>
    [JsonPropertyName("componentType")]
    public string? ComponentType { get; set; }

    /// <summary>The ID of the Container App Managed Environment for this Dapr Component. Changing this forces a new resource to be created. The Container App Managed Environment ID to configure this Dapr component on.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>The ID of the Container App Environment Dapr Component</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to false Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`</summary>
    [JsonPropertyName("ignoreErrors")]
    public bool? IgnoreErrors { get; set; }

    /// <summary>The timeout for component initialisation as a ISO8601 formatted string. e.g. 5s, 2h, 1m. Defaults to 5s. The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`.</summary>
    [JsonPropertyName("initTimeout")]
    public string? InitTimeout { get; set; }

    /// <summary>One or more metadata blocks as detailed below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1EnvironmentDaprComponentStatusAtProviderMetadata>? Metadata { get; set; }

    /// <summary>A list of scopes to which this component applies. A list of scopes to which this component applies. e.g. a Container App's `dapr.app_id` value.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1EnvironmentDaprComponentStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>The version of the component. The version of the component.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentStatusConditions
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

/// <summary>EnvironmentDaprComponentStatus defines the observed state of EnvironmentDaprComponent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentDaprComponentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EnvironmentDaprComponentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvironmentDaprComponentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EnvironmentDaprComponent is the Schema for the EnvironmentDaprComponents API. Manages a Dapr Component for a Container App Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentDaprComponent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvironmentDaprComponentSpec>, IStatus<V1beta1EnvironmentDaprComponentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentDaprComponent";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "environmentdaprcomponents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentDaprComponentSpec defines the desired state of EnvironmentDaprComponent</summary>
    [JsonPropertyName("spec")]
    public V1beta1EnvironmentDaprComponentSpec Spec { get; set; }

    /// <summary>EnvironmentDaprComponentStatus defines the observed state of EnvironmentDaprComponent.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvironmentDaprComponentStatus? Status { get; set; }
}